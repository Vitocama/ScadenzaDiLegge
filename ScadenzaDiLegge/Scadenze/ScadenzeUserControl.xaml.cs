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
        private readonly string _connectionString = "Data Source=C:\\NSL_CHIARA\\marinarescosqlite.sqlite";

        public ScadenzeUserControl()
        {

            InitializeComponent();
            using (var conn = new SqliteConnection(_connectionString)) { 
            
                conn.Open();
                string Sql = @"SELECT 
    id,
    nave,
    GIORNI_MANCANTI_ALLA_SCADENZA,
    TIPOLOGIA_APPARECCHIATURE,
    TIPO_DI_ACCERTAMENTO,
    PROSSIMA_SCADENZA
FROM dbo_MARINARESCO
WHERE GIORNI_MANCANTI_ALLA_SCADENZA > 0 
  AND GIORNI_MANCANTI_ALLA_SCADENZA < 100
ORDER BY GIORNI_MANCANTI_ALLA_SCADENZA ASC;
";

                var dboMArinaresco = conn.Query(Sql).ToList();

                scadenzaDiLeggeDataGrid.ItemsSource = dboMArinaresco;


            }


            }


            
        }

        
    }

