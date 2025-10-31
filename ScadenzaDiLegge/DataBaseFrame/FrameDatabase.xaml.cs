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
                              .Where(x => x.Nave == _nomeTabella).ToList();
                datagrid.ItemsSource = lista;
                datagrid.LoadingRow += Datagrid_LoadingRow;
            }
      

        
        }



        // Usa la riflessione per accedere alla proprietà DbSet dinamicamente



        private void bntSalva(object sender, DataGridRowEditEndingEventArgs e)
        {
           


            if (e.EditAction == DataGridEditAction.Commit)
            {
                Dispatcher.BeginInvoke(new Action(() =>
                {
                    try
                    {
                        var db = new marinarescosqliteContext();
                        var item = e.Row.Item as DboMarinaresco; // Oggetto modificato nel DataGrid

               
                        if (!string.IsNullOrWhiteSpace(item.DataEffettuazione))
                        {
                            DateTime data;
                            bool formatoCorretto = DateTime.TryParseExact(
                                item.DataEffettuazione,
                                "dd/MM/yyyy",                      // formato richiesto
                                CultureInfo.InvariantCulture,      // cultura neutra (o usa it-IT)
                                DateTimeStyles.None,
                                out data
                            );

                            if (!formatoCorretto)
                            {
                                MessageBox.Show(
                    "ERRORE: La DATA non è nel formato corretto (Giorno/Mese/Anno).",
                    "Formato data errato",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error  
                );
                                return; 
                            }
                        }

                        if (!string.IsNullOrWhiteSpace(item.ProssimaScadenza))
                        {
                            DateTime data;
                            bool formatoCorretto = DateTime.TryParseExact(
                                item.DataEffettuazione,
                                "dd/MM/yyyy",                      // formato richiesto
                                CultureInfo.InvariantCulture,      // cultura neutra (o usa it-IT)
                                DateTimeStyles.None,
                                out data
                            );

                            if (!formatoCorretto)
                            {
                                MessageBox.Show(
                    "ERRORE: La DATA non è nel formato corretto (Giorno/Mese/Anno).",
                    "Formato data errato",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error
                );
                                return;
                            }
                        }

                        db.Attach(item);
                        db.Entry(item).State = EntityState.Modified;

                        
                        db.SaveChanges();

                        MessageBox.Show("Modifiche salvate con successo!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Errore durante il salvataggio: " + ex.Message);
                    }
                }), System.Windows.Threading.DispatcherPriority.Background);
            }


        }




        private void Datagrid_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            var item = e.Row.Item as DboMarinaresco;
            if (item == null) return;

            if ( item.GiorniMancantiAllaScadenza < 30 && item.GiorniMancantiAllaScadenza !=0)
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

        private void datagrid_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {

        }
    }

      
    }
