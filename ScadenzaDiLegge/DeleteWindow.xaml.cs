using ScadenzaDiLegge.Models;
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

namespace ScadenzaDiLegge
{
    /// <summary>
    /// Logica di interazione per AggiungiDeleteUserControl.xaml
    /// </summary>
    public partial class DeleteUserControl : Window
    {
        public DeleteUserControl()
        {
            InitializeComponent();
            long number;

            var db = new marinarescosqliteContext();

            List<long> existingIds = db.DboMarinaresco.Select(item => item.Id).OrderBy(n=>n).ToList();

            for (int i = 1; existingIds.Count<i;i++){ 

              if(i==existingIds[i])
                {
                    continue;
                }
              else
                {
                    number = i;
                    textId.Text = "ID "+ number.ToString();
                    break;
                }



            }


            
        }
    }
}
