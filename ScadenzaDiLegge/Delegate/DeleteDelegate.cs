using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScadenzaDiLegge.Delegate
{
    public static class DeleteDelegate
    {
        delegate void deleteDelegate();
       public static void DeleteDel()
        {
            DeleteWindow deleteWindow = new DeleteWindow();
            deleteWindow.Show();
        }
    }
}