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

namespace ScadenzaDiLegge.Setting
{
    /// <summary>
    /// Logica di interazione per SettingWindow.xaml
    /// </summary>
    public partial class SettingWindow : Window
    {
        public SettingWindow()
        {
            InitializeComponent();
            List<int> days = new List<int>();

            for (int i = 1; i <= 150; i++)
            {
                days.Add(i);
            }
            var context = new marinarescosqliteContext();
            int settaggio = context.DataMancante.Select(x => x.setdata).FirstOrDefault();

            settaggiodatatextBox.Text = "Ultimo valore salvato: " + (settaggio + 1).ToString();

            GiorniScadenzaComboBox.ItemsSource = days;
        }

   


        private void Down_MouseDown(object sender, MouseButtonEventArgs e)
        {

            try
            {
                using (var db = new marinarescosqliteContext())
                {
                    var settaggio = db.DataMancante.First(x => x.Id == 1);
                    settaggio.DataEvento = "01/01/1900";
                    settaggio.setdata = int.Parse(GiorniScadenzaComboBox.SelectedIndex.ToString());
                    settaggiodatatextBox.Text = "Ultimo valore salvato: " + (settaggio.setdata + 1).ToString();

                    db.SaveChanges();
                    MessageBox.Show(
    "E' stato settato il valore: "+(settaggio.setdata+1),
    "Attenzione",
    MessageBoxButton.OK,
  MessageBoxImage.Information
);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nel salvataggio delle impostazioni: " + ex.Message, "Errore", MessageBoxButton.OK, MessageBoxImage.Error);

            }

         

            this.Close();

        }
    }
}
