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
                    var item = e.Row.Item as Models.Marinaresco;
                    if (item == null)
                        return;

                    using (var db = new marinarescosqliteContext())
                    {
                        var original = db.Marinaresco.AsNoTracking()
                                                        .FirstOrDefault(x => x.Id == item.Id);
                        if (original == null)
                            return;

                        // ✅ VALIDAZIONE DataVerifica
                        if (!string.IsNullOrWhiteSpace(item.DataVerifica))
                        {
                            if (!DateTime.TryParseExact(item.DataVerifica, "dd/MM/yyyy",
                                CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
                            {
                                MessageBox.Show("ERRORE: La Data Effettuazione non è valida (Formato: Giorno/Mese/Anno)",
                                    "Errore Formato", MessageBoxButton.OK, MessageBoxImage.Error);

                                CopyValues(original, item);
                              //
                                return;
                            }
                        }

                        

                        // ✅ TUTTO OK – SALVATAGGIO
                        db.Update(item);
                        db.SaveChanges();
                        MessageBox.Show("✅ Modifiche salvate correttamente");
                    }

                   // RefreshGrid(grid);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Si è verificato un errore durante il salvataggio:\n{ex.Message}",
                        "Errore", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }), DispatcherPriority.Background);
        }

        // ✅ Metodo per ricaricare la griglia
        /**
        private static void RefreshGrid(DataGrid grid)
        {
            using (var refreshDb = new marinarescosqliteContext())
            {
                grid.ItemsSource = refreshDb.Marinaresco.ToList();
                grid.Items.Refresh();
            }
        }
        **/
        // ✅ Copia valori originali se inseriti errati
        private static void CopyValues(Models.Marinaresco source, Models.Marinaresco target)
        {
            target.UnitaNavale = source.UnitaNavale;
            target.Comando = source.Comando;
            target.Base = source.Base;
            target.Fattibilita = source.Fattibilita;
            target.CategoriaNav70 = source.CategoriaNav70;
            target.DescrizioneSistemazione = source.DescrizioneSistemazione;
            target.Posizione = source.Posizione;
            target.MarcaModelloMatricolaPortata = source.MarcaModelloMatricolaPortata;
            target.TipoDiAccertamento = source.TipoDiAccertamento;
            target.DataVerifica = source.DataVerifica;
            target.DataVerificaAnni = source.DataVerificaAnni;
            target.ProssimaVerifica= source.ProssimaVerifica;
            target.Scadenza = source.Scadenza;
            target.Note = source.Note;
            target.DocumentiCorrelati = source.DocumentiCorrelati;
            target.Certificati = source.Certificati;
        }
    }
}
