using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ScadenzaDiLegge.Delegate
{
    public static class DeleteDelegate
    {
        delegate void deleteDelegate();
       public static void DeleteDel()
        {
            DeleteWindow deleteWindow = Application.Current.Windows
     .OfType<DeleteWindow>()
     .FirstOrDefault();

            if (deleteWindow == null)
            {
                deleteWindow = new DeleteWindow();
                deleteWindow.Show();
            }
            else
            {
                if (deleteWindow.WindowState == WindowState.Minimized)
                    deleteWindow.WindowState = WindowState.Normal;

                deleteWindow.Focus();
                deleteWindow.Activate();
            }

        }
    }
}