using Dapper;
using Microsoft.Data.Sqlite;
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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace ScadenzaDiLegge.Scadenze
{
    /// <summary>
    /// Logica di interazione per ScadenzeUserControl.xaml
    /// </summary>
    public partial class ScadenzeUserControl : UserControl
    {

        public ScadenzeUserControl()
        {

            InitializeComponent();

            var context = new marinarescosqliteContext();
            var dboMArinaresco = context.Marinaresco.ToList();


            int giorniLim = context.DataMancante.Select(x => x.Setdata).FirstOrDefault();



            List<Models.Marinaresco> lista = dboMArinaresco.Where(x => x.Scadenza< giorniLim).ToList();
            lista = lista.Where(x => x.Scadenza >0).OrderBy(p=>p.Scadenza).ToList();

            scadenzaDiLeggeDataGrid.ItemsSource = lista;


            }
            }
        }

        
    

