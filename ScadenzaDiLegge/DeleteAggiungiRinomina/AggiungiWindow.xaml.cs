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
            
            var lista = db.Marinaresco.OrderBy(n => n.Id).ToList();
            long maxIdLong = db.Marinaresco.Max(x => x.Id)+1;




            idTxt.Text = "ID "+maxIdLong.ToString();
           
        }

        // Popola la ComboBox con le navi ordinate
        private void Aggiungi_MouseDown()
        {


             var db = new marinarescosqliteContext();

            var navi = db.Marinaresco
                .Where(x => x.UnitaNavale != null)
                .Select(x => x.UnitaNavale)
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
            var lista = db.Marinaresco.OrderBy(n => n.Id).ToList();
            int maxIdLong = db.Marinaresco.Max(x => x.Id);
            indice = (int)maxIdLong + 1;





            if (navComboBox.SelectedItem is string UnitaNavaleSelezionata && !string.IsNullOrEmpty(UnitaNavaleSelezionata))
            {
                 

                var nuovoRecord = new Models.Marinaresco
                {
                    UnitaNavale = UnitaNavaleSelezionata,
                    Id = indice,
                    Fattibilita = false

                };

                try
                {
                    db.Marinaresco.Add(nuovoRecord);
                    db.SaveChanges();

                    // EF popola automaticamente l'ID
                    int newId =(int) nuovoRecord.Id;

                    MessageBox.Show($"Record con ID {newId} e UnitaNavale '{UnitaNavaleSelezionata}' aggiunto.");

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
                MessageBox.Show("Selezionare una UnitaNavale dalla lista.");
            }
        }

     
    }
}
