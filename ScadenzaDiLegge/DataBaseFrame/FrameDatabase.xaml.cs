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
      

        
        }



        // Usa la riflessione per accedere alla proprietà DbSet dinamicamente




private void datagrid_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
    {
        if (e.EditAction != DataGridEditAction.Commit)
            return;

        Dispatcher.BeginInvoke(new Action(() =>
        {
            var grid = (DataGrid)sender;

            try
            {
                var db = new marinarescosqliteContext();
                var item = e.Row.Item as DboMarinaresco;

                if (item == null)
                    return;

                // ✅ 1) --- Carico i dati originali dal database ---
                var original = db.DboMarinaresco
                                 .AsNoTracking()
                                 .FirstOrDefault(x => x.Id == item.Id);

                if (original == null)
                    return;

               
              

                // ✅ 3) --- Controllo formato DataEffettuazione ---
                if (!string.IsNullOrWhiteSpace(item.DataEffettuazione))
                {
                    DateTime dataEff;
                    bool formatoCorretto = DateTime.TryParseExact(
                        item.DataEffettuazione,
                        "dd/MM/yyyy",
                        CultureInfo.InvariantCulture,
                        DateTimeStyles.None,
                        out dataEff
                    );

                    if (!formatoCorretto)
                    {
                        MessageBox.Show("ERRORE: La DATA non è nel formato corretto (Giorno/Mese/Anno).",
                            "Formato errato", MessageBoxButton.OK, MessageBoxImage.Error);

                        // Ripristina valori originali
                        db.Entry(item).CurrentValues.SetValues(original);
                        grid.CancelEdit(DataGridEditingUnit.Row);
                        grid.Items.Refresh();
                        return;
                    }

                    // ✅ Controllo intervallo consentito
                    DateTime min = new DateTime(2014, 1, 1);
                    DateTime max = new DateTime(2050, 12, 31);

                    if (dataEff < min || dataEff > max)
                    {
                        MessageBox.Show(
                            "ERRORE: La data deve essere compresa tra il 01/01/2014 e il 31/12/2050.",
                            "Data non valida", MessageBoxButton.OK, MessageBoxImage.Warning);

                        db.Entry(item).CurrentValues.SetValues(original);
                        grid.CancelEdit(DataGridEditingUnit.Row);
                        grid.Items.Refresh();
                        return;
                    }



                    // ✅ 4) --- Controllo ProssimaScadenza ---
                    if (!string.IsNullOrWhiteSpace(item.ProssimaScadenza))
                    {
                        if (!item.ProssimaScadenza.Equals("NON CONFORME"))
                        {
                            if (!DateTime.TryParseExact(item.ProssimaScadenza, "dd/MM/yyyy",
                                CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data))
                            {
                                MessageBox.Show("ERRORE: La DATA non è nel formato corretto (Giorno/Mese/Anno).",
                                    "Formato errato", MessageBoxButton.OK, MessageBoxImage.Error);

                                db.Entry(item).CurrentValues.SetValues(original);
                                grid.CancelEdit(DataGridEditingUnit.Row);
                                grid.Items.Refresh();
                                return;
                            }

                            // Limiti consentiti
                           

                            if (data < min || data > max)
                            {
                            
                                MessageBox.Show(
                                    "ERRORE: La data deve essere compresa tra il 01/01/2014 e il 31/12/2050.",
                                    "Data non valida", MessageBoxButton.OK, MessageBoxImage.Warning);

                                db.Entry(item).CurrentValues.SetValues(original);
                                grid.CancelEdit(DataGridEditingUnit.Row);
                                grid.Items.Refresh();
                                return;
                            }
                        }
                    }
                }

                // ✅ 5) --- TUTTO OK → Salvo nel database ---
                db.Attach(item);
                db.Entry(item).State = EntityState.Modified;
                db.SaveChanges();

                MessageBox.Show("✅ Modifiche salvate con successo!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore durante il salvataggio: " + ex.Message);
            }

            // ✅ Ricarica la griglia
            var reloadDb = new marinarescosqliteContext();
            grid.ItemsSource = reloadDb.DboMarinaresco.ToList();
            grid.Items.Refresh();

        }), System.Windows.Threading.DispatcherPriority.Background);
    }






        private void MyDataGrid_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            // Trova lo ScrollViewer interno
            ScrollViewer scrollViewer = FindVisualChild<ScrollViewer>(datagrid);
            if (scrollViewer != null)
            {
                double scrollFactor = 0.3; // 30% della velocità originale
                scrollViewer.ScrollToVerticalOffset(scrollViewer.VerticalOffset - e.Delta * scrollFactor);
                e.Handled = true; // blocca lo scroll originale
            }
        }

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
                                            .Select(x => x.setdata)
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
