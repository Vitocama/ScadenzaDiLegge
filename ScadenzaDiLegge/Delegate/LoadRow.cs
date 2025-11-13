using ScadenzaDiLegge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace ScadenzaDiLegge.Delegate
{
    public static class LoadRow
    {
        public static void Datagrid_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            var contex = new marinarescosqliteContext();
            int limite = contex.DataMancante.Where(x=>x.Id==1).Select(x=>x.Setdata).FirstOrDefault();
                //Where(x => x.Id == 1)
                  //                          .Select(x => x.Setdata)
                    //                        .FirstOrDefault();



            var item = e.Row.Item as Models.Marinaresco;
            if (item == null) return;

            if (item.Scadenza < limite && item.Scadenza != 0)
            {
                if (item.Scadenza < 0)
                {
                    e.Row.Background = Brushes.White;
                    e.Row.Foreground = Brushes.Red;
                }

                else
                {
                    e.Row.Background = Brushes.Red;
                    e.Row.Foreground = Brushes.Black;
                }
            }
            else if (item.Id % 2 == 0)
            {


                e.Row.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#6C99C4"));
                e.Row.Foreground = Brushes.White;
            }
            else
            {
                e.Row.Background = Brushes.LightCyan;
                e.Row.Foreground = Brushes.Black;

            }

            if (item.Note == null)
                return;

            else if (item.Note.ToString().ToUpper().Contains("NON CONFORME"))
                    {
                item.Note = "NON CONFORME";
                e.Row.Background = Brushes.Black;
                e.Row.Foreground = Brushes.White;

            }



        }
    }
}
