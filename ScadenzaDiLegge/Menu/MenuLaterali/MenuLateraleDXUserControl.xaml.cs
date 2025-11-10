using ScadenzaDiLegge.ClassiUserController;
using ScadenzaDiLegge.DeleteAggiungiRinomina;
using ScadenzaDiLegge.Models;
using ScadenzaDiLegge.Scadenze;
using ScadenzaDiLegge.Setting;
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
    /// Logica di interazione per MenuLateraleDXUserControl.xaml
    /// </summary>
    public partial class MenuLateraleDXUserControl : UserControl
    {
        public MenuLateraleDXUserControl()
        {
            InitializeComponent();




            ScadenzeLabel.Content = "SCADENZA";
                



        }

        private void scadenza_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow main = Window.GetWindow(this) as MainWindow;

            if (main != null)
            {
                main.AreaComune.Content = new ScadenzeUserControl();
            }
        }

        private void scadenza_MouseEnter(object sender, MouseEventArgs e)
        {
            Scadenza.Source = new BitmapImage(new Uri("pack://application:,,,/Img/port-signR.png"));
            ScadenzeLabel.Foreground = Brushes.Red;

        }

        private void scadenza_MouseLeave(object sender, MouseEventArgs e)
        {
            Scadenza.Source = new BitmapImage(new Uri("pack://application:,,,/Img/port-signW.png"));
            ScadenzeLabel.Foreground = Brushes.White;
        }

        private void search_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var serchWindows = Application.Current.Windows.OfType<Search>().FirstOrDefault();
            if (serchWindows != null)
            {
                serchWindows.Focus();
                return;
            }
         
            Search searchWindow = new Search();
            searchWindow.Show();
        }

        private void search_MouseEnter(object sender, MouseEventArgs e)
        {
            Search.Source = new BitmapImage(new Uri("pack://application:,,,/Img/search.png"));
            SearchLabel.Foreground = Brushes.Black;
        }

        private void search_MouseLeave(object sender, MouseEventArgs e)
        {
            Search.Source = new BitmapImage(new Uri("pack://application:,,,/Img/searchW.png"));

            SearchLabel.Foreground = Brushes.White;
        }

        private void setting_MouseDown(object sender, MouseButtonEventArgs e)
        {
            foreach (Window w in Application.Current.Windows)
            {
                if (w is SettingWindow)   // <-- nome della tua finestra
                {
                    w.Focus();     // porta avanti se già aperta
                    return;
                }
            }

            // Se non esiste, la crea e la mostra
            SettingWindow fs = new SettingWindow();
            fs.Show();
        }

        private void setting_MouseEnter(object sender, MouseEventArgs e)
        {
            Setting.Source = new BitmapImage(new Uri("pack://application:,,,/Img/settings.png"));
           SettingLabel.Foreground = Brushes.Black;
        }

        private void setting_MouseLeave(object sender, MouseEventArgs e)
        {
            Setting.Source = new BitmapImage(new Uri("pack://application:,,,/Img/settingsW.png"));
            SettingLabel.Foreground = Brushes.White;

        }
    }
}
