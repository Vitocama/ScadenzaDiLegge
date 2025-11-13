using ScadenzaDiLegge.DeleteAggiungi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ScadenzaDiLegge.Delegate
{
    public static class AggiungiDelegate
    {

      public  delegate void AddDelegate();
        public static void addDel()
        {
            AggiungiWindow aggiungiWindow = Application.Current.Windows
      .OfType<AggiungiWindow>()
      .FirstOrDefault();

            if (aggiungiWindow == null)
            {
                aggiungiWindow = new AggiungiWindow();
                aggiungiWindow.Show();
            }
            else
            {
                // porta in primo piano la finestra già aperta
                if (aggiungiWindow.WindowState == WindowState.Minimized)
                    aggiungiWindow.WindowState = WindowState.Normal;

                aggiungiWindow.Focus();
                aggiungiWindow.Activate();
            }

        }


    }
}
