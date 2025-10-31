using ScadenzaDiLegge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace ScadenzaDiLegge.Delegate
{
    public static class ListaNavi
    {
        public static List<string> Lista() {
            var context = new marinarescosqliteContext();
            List<string> listanavi = context.DboMarinaresco.Select(x => x.Nave.Distinct()).Cast<string>().ToList();
            return listanavi;
        }


    }
}
