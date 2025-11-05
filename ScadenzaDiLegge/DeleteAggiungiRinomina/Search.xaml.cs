using ScadenzaDiLegge.DataBaseFrame;
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
using System.Windows.Shapes;

namespace ScadenzaDiLegge.DeleteAggiungiRinomina
{
    /// <summary>
    /// Logica di interazione per Search.xaml
    /// </summary>
    public partial class Search : Window
    {
        public Search()
        {
            InitializeComponent();
            
        }

        private void Search_MouseDown(object sender, MouseButtonEventArgs e)
        {

            List<string> listaProprietaMarinaresco = new List<string>();

            // Supponendo che listaProprietaMarinaresco sia List<string>
            listaProprietaMarinaresco.Add(id.Text);
            listaProprietaMarinaresco.Add(nave.Text);
            listaProprietaMarinaresco.Add(comando.Text);
            listaProprietaMarinaresco.Add(Base.Text);
            listaProprietaMarinaresco.Add(visto.Text);
            listaProprietaMarinaresco.Add(TipologiaApparecchiature.Text);
            listaProprietaMarinaresco.Add(apparecchiaturaSistemazione.Text);
            listaProprietaMarinaresco.Add(Posizione.Text);
            listaProprietaMarinaresco.Add(MarcaModelloDimensioni.Text);
            listaProprietaMarinaresco.Add(TipoDiAccertamento.Text);
            listaProprietaMarinaresco.Add(DataEffettuazione.Text);
            listaProprietaMarinaresco.Add(ValiditaAnni.Text);
            listaProprietaMarinaresco.Add(ProssimaScadenza.Text);
            listaProprietaMarinaresco.Add(GiorniMancantiAllaScadenza.Text);
            listaProprietaMarinaresco.Add(note.Text);
            listaProprietaMarinaresco.Add(DocumentiCorrelati.Text);
            listaProprietaMarinaresco.Add(certifiCati.Text);
            listaProprietaMarinaresco.Add(column18.Text);
            listaProprietaMarinaresco.Add(column19.Text);








            var serchText = Application.Current.Windows.OfType<SearchDatagridWindow>().FirstOrDefault();
            if (serchText != null)
            {
                SearchDatagridWindow searchDatagridWindow = serchText as SearchDatagridWindow;
                searchDatagridWindow.Show();
            }
            else
                {
                SearchDatagridWindow searchDatagridWindow = new SearchDatagridWindow(listaProprietaMarinaresco);
                searchDatagridWindow.Focus();
            }


        }

    }
}
