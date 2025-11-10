using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace ScadenzaDiLegge.Marinaresco
{
    /// <summary>
    /// Logica di interazione per MarinarescoUserControl.xaml
    /// </summary>
    public partial class MarinarescoUserControl : UserControl
    {
        public MarinarescoUserControl()
        {
            InitializeComponent();
        }

        private void Scire_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string methodName = MethodBase.GetCurrentMethod().Name;

            // Estrai la parte prima di "_MouseDown" → "Foscari"
            string windowName = methodName.Replace("_MouseDown", "");

            // Controlla se esiste già una finestra con quel nome
            foreach (Window window in Application.Current.Windows)
            {
                if (window is FrameDatabase db && db.Title == windowName)
                {
                    db.Activate();
                    return;
                }
            }

            // Se non è aperta, la crea e la mostra
            FrameDatabase database = new FrameDatabase(windowName);
            database.Title = windowName;
            database.Show();
        }

        private void Marinaresco_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string methodName = MethodBase.GetCurrentMethod().Name;

            // Estrai la parte prima di "_MouseDown" → "Foscari"
            string windowName = methodName.Replace("_MouseDown", "");

            // Controlla se esiste già una finestra con quel nome
            foreach (Window window in Application.Current.Windows)
            {
                if (window is FrameDatabase db && db.Title == windowName)
                {
                    db.Activate();
                    return;
                }
            }

            // Se non è aperta, la crea e la mostra
            FrameDatabase database = new FrameDatabase(windowName);
            database.Title = windowName;
            database.Show();

        }
    }
}
