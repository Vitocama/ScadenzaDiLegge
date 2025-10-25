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
    /// Logica di interazione per NaviglioMinoreUserControl1.xaml
    /// </summary>
    public partial class NaviglioMinoreUserControl : UserControl
    {
        public NaviglioMinoreUserControl()
        {
            InitializeComponent();
        }

        private void Lipari_MouseDown(object sender, MouseButtonEventArgs e)
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

        private void Panarea_MouseDown(object sender, MouseButtonEventArgs e)
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

        private void Salina_MouseDown(object sender, MouseButtonEventArgs e)
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

        private void Linosa_MouseDown(object sender, MouseButtonEventArgs e)
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

        private void Ticino_MouseDown(object sender, MouseButtonEventArgs e)
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

        private void Favignana_MouseDown(object sender, MouseButtonEventArgs e)
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

        private void Tirsio_MouseDown(object sender, MouseButtonEventArgs e)
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
