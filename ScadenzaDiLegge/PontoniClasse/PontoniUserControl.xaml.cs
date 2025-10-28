using ScadenzaDiLegge.Delegate;
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
    /// Logica di interazione per PontoniUserControl.xaml
    /// </summary>
    public partial class PontoniUserControl : UserControl
    {
        public PontoniUserControl()
        {
            InitializeComponent();
        }

        private void Gasa1014_MouseDown(object sender, MouseButtonEventArgs e)
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

        private void Gasa1023_MouseDown(object sender, MouseButtonEventArgs e)
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

        private void Gd139_MouseDown(object sender, MouseButtonEventArgs e)
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

        private void Gems16_MouseDown(object sender, MouseButtonEventArgs e)
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

        private void Gg1012_MouseDown(object sender, MouseButtonEventArgs e)
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

        private void Ggs1018_MouseDown(object sender, MouseButtonEventArgs e)
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

        private void Gkm28_MouseDown(object sender, MouseButtonEventArgs e)
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

        private void Grg563_MouseDown(object sender, MouseButtonEventArgs e)
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

        private void Jdg10_MouseDown(object sender, MouseButtonEventArgs e)
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

     

        private void Delete_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DeleteDelegate.DeleteDel();
        }

        private void Aggiungi_MouseDown(object sender, MouseButtonEventArgs e)
        {
            AggiungiDelegate.addDel();
        }
    }
}
