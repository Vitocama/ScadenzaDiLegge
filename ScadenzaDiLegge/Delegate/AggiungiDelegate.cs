using ScadenzaDiLegge.DeleteAggiungi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScadenzaDiLegge.Delegate
{
    public static class AggiungiDelegate
    {

      public  delegate void AddDelegate();
        public static void addDel()
        {
            AggiungiWindow aggiungiWindow = new AggiungiWindow();
            aggiungiWindow.Show();
        }


    }
}
