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

namespace ScadenzaDiLegge.ClassiUserController
{
    /// <summary>
    /// Logica di interazione per RimorchiatoreUserControl.xaml
    /// </summary>
    public partial class RimorchiatoreUserControl : UserControl
    {
        public RimorchiatoreUserControl()
        {
            InitializeComponent();
        }

        private void Polifemo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string methodName = System.Reflection.MethodBase.GetCurrentMethod().Name;

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

        private void PortoConte_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string methodName = System.Reflection.MethodBase.GetCurrentMethod().Name;

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

        private void PortoVenere_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string methodName = System.Reflection.MethodBase.GetCurrentMethod().Name;

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

        private void Porto123_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string methodName = System.Reflection.MethodBase.GetCurrentMethod().Name;

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

        private void Porto130_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string methodName = System.Reflection.MethodBase.GetCurrentMethod().Name;

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

        private void RP102_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string methodName = System.Reflection.MethodBase.GetCurrentMethod().Name;

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

        private void Rp112_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string methodName = System.Reflection.MethodBase.GetCurrentMethod().Name;

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
