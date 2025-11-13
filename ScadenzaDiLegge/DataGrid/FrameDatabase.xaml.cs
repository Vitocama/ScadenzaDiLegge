using Dapper;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using ScadenzaDiLegge.ClassiUserController;
using ScadenzaDiLegge.Delegate;
using ScadenzaDiLegge.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace ScadenzaDiLegge
{
    /// <summary>
    /// Logica di interazione per FrameDatabase.xaml
    /// </summary>
    public partial class FrameDatabase : Window
    {
        private string _nomeTabella;


        public FrameDatabase(string nomeUnitaNavale)
        {
            InitializeComponent();


            _nomeTabella = nomeUnitaNavale.ToUpper();
            
            var db = new marinarescosqliteContext();



            if (_nomeTabella.Equals("MARINARESCO"))
            {


                var  lista = db.Marinaresco.OrderBy(x=>x.Id).ToList();
                datagrid.ItemsSource = lista;
                datagrid.LoadingRow += LoadRow.Datagrid_LoadingRow;

                
            }

            else
            {
                db = new marinarescosqliteContext();
               var lista = db.Marinaresco
                              .Where(x => x.UnitaNavale == _nomeTabella).OrderBy(p=>p.Id).ToList();
                datagrid.ItemsSource = lista;
                
            }

            datagrid.RowEditEnding += Edit_Datagrid.RonRowEditEnding;

            datagrid.LoadingRow += LoadRow.Datagrid_LoadingRow;

        }



        // Usa la riflessione per accedere alla proprietà DbSet dinamicamente




       
      
    }

      
    }
