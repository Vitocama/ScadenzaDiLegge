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

        SearchDatagridWindow _searchDatagridWindow;
        public Search()
        {
            InitializeComponent();


           
        }

        private void Search_MouseDown(object sender, MouseButtonEventArgs e)
        {

            List<string> listaProprietaMarinaresco = new List<string>();

            // Supponendo che listaProprietaMarinaresco sia List<string>
            listaProprietaMarinaresco.Add(id.Text);
            listaProprietaMarinaresco.Add(UnitaNavale.Text);
            listaProprietaMarinaresco.Add(comando.Text);
            listaProprietaMarinaresco.Add(Base.Text);
            listaProprietaMarinaresco.Add(Fattibilita.Text);
            listaProprietaMarinaresco.Add(CategoriaNav70.Text);
            listaProprietaMarinaresco.Add(DescrizioneSistemazione.Text);
            listaProprietaMarinaresco.Add(Posizione.Text);
            listaProprietaMarinaresco.Add(MarcaModelloDimensioniPortatai.Text);
            listaProprietaMarinaresco.Add(TipoDiAccertamento.Text);
            listaProprietaMarinaresco.Add(DataVerifica.Text);
            listaProprietaMarinaresco.Add(VerificaAnni.Text);
            listaProprietaMarinaresco.Add(ProssimaScadenza.Text);
            listaProprietaMarinaresco.Add(Scadenza.Text);
            listaProprietaMarinaresco.Add(note.Text);
            listaProprietaMarinaresco.Add(DocumentiCorrelati.Text);
            listaProprietaMarinaresco.Add(certifiCati.Text);
      








            var serchText = Application.Current.Windows.OfType<SearchDatagridWindow>().FirstOrDefault();
            if (serchText != null)
            {
                _searchDatagridWindow = serchText as SearchDatagridWindow;
                _searchDatagridWindow.Show();
            }
            else
                {
                _searchDatagridWindow = new SearchDatagridWindow(listaProprietaMarinaresco);
                _searchDatagridWindow.Focus();
            }


        }

    }
}
