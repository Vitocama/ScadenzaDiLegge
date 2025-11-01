using ScadenzaDiLegge.ClassiUserController;
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


            var context = new marinarescosqliteContext();
            int giorniLim = context.DataMancante.Select(x=>x.setdata).FirstOrDefault();

            ScadenzeLabel.Content = "SCADENZA A "+giorniLim;
                



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

        }

        private void search_MouseEnter(object sender, MouseEventArgs e)
        {

            ScadenzeLabel.Foreground = Brushes.Black;
        }

        private void search_MouseLeave(object sender, MouseEventArgs e)
        {
            ScadenzeLabel.Foreground = Brushes.White;
        }

        private void setting_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SettingWindow setting = new SettingWindow();
            setting.Show();
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
