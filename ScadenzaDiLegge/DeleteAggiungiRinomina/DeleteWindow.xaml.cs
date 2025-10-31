using ScadenzaDiLegge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ScadenzaDiLegge
{
    /// <summary>
    /// Logica di interazione per AggiungiDeleteUserControl.xaml
    /// </summary>
    public partial class DeleteWindow : Window
    {
        public DeleteWindow()
        {
            InitializeComponent();

            indice();


        }

        private void indice()
        {
            var db = new marinarescosqliteContext();

            List<int> existingIds = db.DboMarinaresco.Select(item => (int)item.Id).OrderBy(n => n).ToList();

            int number = existingIds.Count + 1;

            Dictionary<string, int> naviNome = new Dictionary<string, int>();
            var navi = db.DboMarinaresco
    .Select(item => item.Nave)
    .Where(n => n != null)     // evita valori null
    .Distinct()                // opzionale: evita duplicati
    .ToList();

            List<string> nav = new List<string>();

            foreach (var nome in navi)
            {
                nav.Add(nome);
            }

            navComboBox.ItemsSource = nav;
            idComboBox.ItemsSource = existingIds;

        }

        private void Cancella_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (idComboBox.SelectedItem is int idToDelete && navComboBox.SelectedItem is string naveSelezionata)
            {
                using (var db = new marinarescosqliteContext())
                {
                    // Cerca il record con ID e nave corrispondenti
                    var record = db.DboMarinaresco
                        .SingleOrDefault(x => x.Id == idToDelete && x.Nave == naveSelezionata);

                    if (record != null)
                    {
                        try
                        {
                            db.DboMarinaresco.Remove(record);
                            db.SaveChanges();
                            MessageBox.Show($"Record con ID {idToDelete} e nave '{naveSelezionata}' eliminato.");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Errore durante l'eliminazione: {ex.Message}");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nessun record corrispondente trovato. Nessuna cancellazione effettuata.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Selezionare sia l'ID che la nave.");
            }
        }
    }
}



        



    

