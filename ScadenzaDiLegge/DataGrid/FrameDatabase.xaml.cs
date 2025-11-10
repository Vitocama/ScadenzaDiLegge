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


        public FrameDatabase(string nomeNave)
        {
            InitializeComponent();


            _nomeTabella = nomeNave.ToUpper();
            
            var db = new marinarescosqliteContext();



            if (_nomeTabella.Equals("MARINARESCO"))
            {


                var  lista = db.DboMarinaresco.OrderBy(x=>x.Id).ToList();
                datagrid.ItemsSource = lista;
                datagrid.LoadingRow += Datagrid_LoadingRow;

                
            }

            else
            {
                db = new marinarescosqliteContext();
               var lista = db.DboMarinaresco
                              .Where(x => x.Nave == _nomeTabella).OrderBy(p=>p.Id).ToList();
                datagrid.ItemsSource = lista;
                datagrid.LoadingRow += Datagrid_LoadingRow;
            }

            datagrid.RowEditEnding += Edit_Datagrid.RonRowEditEnding;

            datagrid.LoadingRow += Datagrid_LoadingRow;

        }



        // Usa la riflessione per accedere alla proprietà DbSet dinamicamente




        // Dentro un metodo di un'altra classe

        






        // Metodo helper per trovare lo ScrollViewer interno
        private T FindVisualChild<T>(DependencyObject parent) where T : DependencyObject
        {
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(parent); i++)
            {
                DependencyObject child = VisualTreeHelper.GetChild(parent, i);
                if (child != null && child is T tChild)
                    return tChild;
                else
                {
                    T childOfChild = FindVisualChild<T>(child);
                    if (childOfChild != null)
                        return childOfChild;
                }
            }
            return null;
        }





        private void Datagrid_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            var contex = new marinarescosqliteContext();
            int limite = contex.DataMancante.Where(x=> x.Id == 1)
                                            .Select(x => x.Setdata)
                                            .FirstOrDefault();  



            var item = e.Row.Item as DboMarinaresco;
            if (item == null) return;

            if ( item.GiorniMancantiAllaScadenza < limite && item.GiorniMancantiAllaScadenza !=0)
            {
                if (item.GiorniMancantiAllaScadenza < 0)
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




            }

      
    }

      
    }
