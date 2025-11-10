using Microsoft.EntityFrameworkCore;
using ScadenzaDiLegge.Models;
using System;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace ScadenzaDiLegge.Delegate
{
    public static class Edit_Datagrid
    {
        // ✅ Metodo principale per gestire RowEditEnding
        public static void RonRowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {
            if (e.EditAction != DataGridEditAction.Commit)
                return;

            // Differimento necessario o il commit non parte in WPF
            Dispatcher.CurrentDispatcher.BeginInvoke(new Action(() =>
            {
                var grid = sender as DataGrid;
                if (grid == null)
                    return;

                try
                {
                    var item = e.Row.Item as DboMarinaresco;
                    if (item == null)
                        return;

                    using (var db = new marinarescosqliteContext())
                    {
                        var original = db.DboMarinaresco.AsNoTracking()
                                                        .FirstOrDefault(x => x.Id == item.Id);
                        if (original == null)
                            return;

                        // ✅ VALIDAZIONE DataEffettuazione
                        if (!string.IsNullOrWhiteSpace(item.DataEffettuazione))
                        {
                            if (!DateTime.TryParseExact(item.DataEffettuazione, "dd/MM/yyyy",
                                CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
                            {
                                MessageBox.Show("ERRORE: La Data Effettuazione non è valida (Formato: Giorno/Mese/Anno)",
                                    "Errore Formato", MessageBoxButton.OK, MessageBoxImage.Error);

                                CopyValues(original, item);
                                RefreshGrid(grid);
                                return;
                            }
                        }

                        // ✅ VALIDAZIONE ProssimaScadenza
                        if (!string.IsNullOrWhiteSpace(item.ProssimaScadenza)
                            && item.ProssimaScadenza != "NON CONFORME")
                        {
                            if (!DateTime.TryParseExact(item.ProssimaScadenza, "dd/MM/yyyy",
                                CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
                            {
                                MessageBox.Show("ERRORE: La Prossima Scadenza non è valida (Formato: Giorno/Mese/Anno)",
                                    "Errore Formato", MessageBoxButton.OK, MessageBoxImage.Error);

                                CopyValues(original, item);
                                RefreshGrid(grid);
                                return;
                            }
                        }

                        // ✅ TUTTO OK – SALVATAGGIO
                        db.Update(item);
                        db.SaveChanges();
                        MessageBox.Show("✅ Modifiche salvate correttamente");
                    }

                    RefreshGrid(grid);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Si è verificato un errore durante il salvataggio:\n{ex.Message}",
                        "Errore", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }), DispatcherPriority.Background);
        }

        // ✅ Metodo per ricaricare la griglia
        private static void RefreshGrid(DataGrid grid)
        {
            using (var refreshDb = new marinarescosqliteContext())
            {
                grid.ItemsSource = refreshDb.DboMarinaresco.ToList();
                grid.Items.Refresh();
            }
        }

        // ✅ Copia valori originali se inseriti errati
        private static void CopyValues(DboMarinaresco source, DboMarinaresco target)
        {
            target.Nave = source.Nave;
            target.Comando = source.Comando;
            target.Base = source.Base;
            target.Fattibilita = source.Fattibilita;
            target.TipologiaApparecchiature = source.TipologiaApparecchiature;
            target.ApparecchiaturaSistemazione = source.ApparecchiaturaSistemazione;
            target.Posizione = source.Posizione;
            target.MarcaModelloDimensioni = source.MarcaModelloDimensioni;
            target.TipoDiAccertamento = source.TipoDiAccertamento;
            target.DataEffettuazione = source.DataEffettuazione;
            target.ValiditaAnni = source.ValiditaAnni;
            target.ProssimaScadenza = source.ProssimaScadenza;
            target.GiorniMancantiAllaScadenza = source.GiorniMancantiAllaScadenza;
            target.Note = source.Note;
            target.DocumentiCorrelati = source.DocumentiCorrelati;
            target.Certificati = source.Certificati;
        }
    }
}
