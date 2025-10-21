using ScadenzaDiLegge.ClassiUserController;
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
using static System.Net.Mime.MediaTypeNames;

namespace ScadenzaDiLegge
{
    /// <summary>
    /// Logica di interazione per menuLaterare_usersControler.xaml
    /// </summary>
    public partial class menuLaterare_usersControler : UserControl
    {
        public menuLaterare_usersControler()
        {
            InitializeComponent();
        }

        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            comando.Source = new BitmapImage(new Uri("pack://application:,,,/Img/command.png"));
            comandoLabel.Foreground = Brushes.Black;
        }

        private void comando_MouseLeave(object sender, MouseEventArgs e)
        {
            comando.Source = new BitmapImage(new Uri("pack://application:,,,/Img/commandw.png"));
            comandoLabel.Foreground = Brushes.White;
        }

        private void cassiopea_MouseLeave(object sender, MouseEventArgs e)
        {
            cassiopea.Source = new BitmapImage(new Uri("pack://application:,,,/Img/cassiopeaW.png"));
            cassiopeaLabel.Foreground = Brushes.White;
        }

        private void cassiopea_MouseEnter(object sender, MouseEventArgs e)
        {
            cassiopea.Source = new BitmapImage(new Uri("pack://application:,,,/Img/cassiopea.png"));
            cassiopeaLabel.Foreground = Brushes.Black;
        }

        private void costellazioni_MouseEnter(object sender, MouseEventArgs e)
        {
            costellazioni.Source = new BitmapImage(new Uri("pack://application:,,,/Img/zodiac.png"));
            costellazioniLabel.Foreground = Brushes.Black;

        }

        private void costellazioni_MouseLeave(object sender, MouseEventArgs e)
        {
            costellazioni.Source = new BitmapImage(new Uri("pack://application:,,,/Img/zodiacW.png"));
            costellazioniLabel.Foreground = Brushes.White;
        }

        private void naviglio_MouseEnter(object sender, MouseEventArgs e)
        {
            naviglio.Source = new BitmapImage(new Uri("pack://application:,,,/Img/anchor.png"));
            naviglioLabel.Foreground = Brushes.Black;

        }

        private void naviglio_MouseLeave(object sender, MouseEventArgs e)
        {
            naviglio.Source = new BitmapImage(new Uri("pack://application:,,,/Img/anchorW.png"));
            naviglioLabel.Foreground = Brushes.White;

        }

        private void Rimorchiatore_MouseEnter(object sender, MouseEventArgs e)
        {
            Rimorchiatore.Source = new BitmapImage(new Uri("pack://application:,,,/Img/tug-of-war.png"));
            RimorchiatoreLabel.Foreground = Brushes.Black;
        }

        private void Rimorchiatore_MouseLeave(object sender, MouseEventArgs e)
        {
            Rimorchiatore.Source = new BitmapImage(new Uri("pack://application:,,,/Img/tug-of-warW.png"));
            RimorchiatoreLabel.Foreground = Brushes.White;
        }

        private void Pontoni_MouseEnter(object sender, MouseEventArgs e)
        {
            Pontoni.Source = new BitmapImage(new Uri("pack://application:,,,/Img/ship-wheel.png"));
            PontoniLabel.Foreground = Brushes.Black;
        }

        private void Pontoni_MouseLeave(object sender, MouseEventArgs e)
        {
            Pontoni.Source = new BitmapImage(new Uri("pack://application:,,,/Img/ship-wheelW.png"));
            PontoniLabel.Foreground = Brushes.White;
        }

        private void FuoriSede_MouseEnter(object sender, MouseEventArgs e)
        {
            FuoriSede.Source = new BitmapImage(new Uri("pack://application:,,,/Img/two-vertical-rectangles-with-arrows-pointing-out.png"));
            FuoriSedeLabel.Foreground = Brushes.Black;
        }

        private void FuoriSede_MouseLeave(object sender, MouseEventArgs e)
        {
            FuoriSede.Source = new BitmapImage(new Uri("pack://application:,,,/Img/two-vertical-rectangles-with-arrows-pointing-outW.png"));
            FuoriSedeLabel.Foreground = Brushes.White;
        }

        private void Sommergibile_MouseEnter(object sender, MouseEventArgs e)
        {
            Sommergibile.Source = new BitmapImage(new Uri("pack://application:,,,/Img/submarine.png"));
            SommergibileLabel.Foreground = Brushes.Black;
        }

        private void Sommergibile_MouseLeave(object sender, MouseEventArgs e)
        {
            Sommergibile.Source = new BitmapImage(new Uri("pack://application:,,,/Img/submarineW.png"));
            SommergibileLabel.Foreground = Brushes.White;
        }

        private void Marinaresco_MouseEnter(object sender, MouseEventArgs e)
        {
            Marinaresco.Source = new BitmapImage(new Uri("pack://application:,,,/Img/journey.png"));
            MarinarescoLabel.Foreground = Brushes.Black;
        }

        private void Marinaresco_MouseLeave(object sender, MouseEventArgs e)
        {
            Marinaresco.Source = new BitmapImage(new Uri("pack://application:,,,/Img/journeyW.png"));
            MarinarescoLabel.Foreground = Brushes.White;
        }

        private void comandoLabel_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void comando_Gruppo(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void comando_MouseLeave(object sender, MouseButtonEventArgs e)
        {
            MainWindow mainWindow=new MainWindow();
            mainWindow.AreaComune.Content = new ComadoUserControl();
        }
    }
}
