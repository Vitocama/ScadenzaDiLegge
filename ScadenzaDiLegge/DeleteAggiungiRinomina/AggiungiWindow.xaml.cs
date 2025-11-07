using ScadenzaDiLegge.Models;
using System;
using System.Linq;
using System.Windows;
using System.Collections.Generic;

namespace ScadenzaDiLegge.DeleteAggiungi
{
    /// <summary>
    /// Logica di interazione per AggiungiWindow.xaml
    /// </summary>
    public partial class AggiungiWindow : Window
    {
        public AggiungiWindow()
        {
            InitializeComponent();
            Aggiungi_MouseDown();
            var db = new marinarescosqliteContext();
            
            var lista = db.DboMarinaresco.OrderBy(n => n.Id).ToList();
            long maxIdLong = db.DboMarinaresco.Max(x => x.Id)+1;




            idTxt.Text = "ID "+maxIdLong.ToString();
           
        }

        // Popola la ComboBox con le navi ordinate
        private void Aggiungi_MouseDown()
        {
             var db = new marinarescosqliteContext();

            var navi = db.DboMarinaresco
                .Where(x => x.Nave != null)
                .Select(x => x.Nave)
                .Distinct()
                .OrderBy(n => n)
                .ToList();

            navComboBox.ItemsSource = navi;
            navComboBox.SelectedIndex = -1; // nessuna selezione di default
        }

        // Evento per aggiungere un nuovo record
        private void Aggiungi_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)

        {
            var db = new marinarescosqliteContext();
            int indice = 0;
            var lista = db.DboMarinaresco.OrderBy(n => n.Id).ToList();
            long maxIdLong = db.DboMarinaresco.Max(x => x.Id);
            indice = (int)maxIdLong + 1;





            if (navComboBox.SelectedItem is string naveSelezionata && !string.IsNullOrEmpty(naveSelezionata))
            {
                 

                var nuovoRecord = new DboMarinaresco
                {
                    Nave = naveSelezionata,
                    Id = indice

                };

                try
                {
                    db.DboMarinaresco.Add(nuovoRecord);
                    db.SaveChanges();

                    // EF popola automaticamente l'ID
                    int newId =(int) nuovoRecord.Id;

                    MessageBox.Show($"Record con ID {newId} e nave '{naveSelezionata}' aggiunto.");

                    // Aggiorna ComboBox per eventuali nuovi inserimenti
                    Aggiungi_MouseDown();
                }
                catch (Microsoft.EntityFrameworkCore.DbUpdateException dbEx)
                {
                    MessageBox.Show($"Errore di database: {dbEx.InnerException?.Message ?? dbEx.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Errore durante l'inserimento: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Selezionare una nave dalla lista.");
            }
        }

     
    }
}
