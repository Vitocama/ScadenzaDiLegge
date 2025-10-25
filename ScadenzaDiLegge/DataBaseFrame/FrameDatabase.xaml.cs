using Microsoft.EntityFrameworkCore;
using ScadenzaDiLegge.ClassiUserController;
using ScadenzaDiLegge.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Shapes;
using System.Windows.Threading;


namespace ScadenzaDiLegge
{
    /// <summary>
    /// Logica di interazione per FrameDatabase.xaml
    /// </summary>
    public partial class FrameDatabase : Window
    {
        private marinarescosqliteContext _context;
        private string _nomeTabella;

        public FrameDatabase(string nomeNave)
        {
            InitializeComponent();
            _nomeTabella = nomeNave;

            var nave = new marinarescosqliteContext();

            // Usa la riflessione per accedere alla proprietà DbSet dinamicamente
            var dbSetProperty = typeof(marinarescosqliteContext).GetProperty(_nomeTabella);
            if (dbSetProperty != null)
            {
                var dbSet = dbSetProperty.GetValue(nave) as IQueryable;
                if (dbSet != null)
                {
                    var objetBettica = dbSet.Cast<object>().ToList();
                    datagrid.ItemsSource = objetBettica;
                }
            }
        }


        private void bntSalva(object sender, DataGridRowEditEndingEventArgs e)
        {
            _context = new marinarescosqliteContext();
            if (e.EditAction == DataGridEditAction.Commit)
            {
                Dispatcher.BeginInvoke(new Action(() =>
                {
                    // Ottieni il tipo del modello dalla stringa
                    var modelType = Type.GetType($"ScadenzaDiLegge.Models.{_nomeTabella}");

                    if (modelType != null)
                    {
                        // Cast dinamico usando il tipo ottenuto
                        var edit = Convert.ChangeType(e.Row.Item, modelType);

                        if (edit != null)
                        {
                            // Usa la riflessione per accedere al DbSet dinamicamente
                            var dbSetProperty = typeof(marinarescosqliteContext).GetProperty(_nomeTabella);
                            if (dbSetProperty != null)
                            {
                                var dbSet = dbSetProperty.GetValue(_context);
                                var updateMethod = dbSet.GetType().GetMethod("Update");
                                updateMethod?.Invoke(dbSet, new[] { edit });
                            }

                            // Ottieni l'Id usando la riflessione
                            var idProperty = modelType.GetProperty("Id");
                            var editId = idProperty?.GetValue(edit);

                            // Trova il record corrispondente in DboMarinaresco
                            var marinaresco = _context.DboMarinaresco.FirstOrDefault(m => m.Id == (long?)editId);
                            if (marinaresco != null)
                            {
                                // Rimuove il record esistente
                                _context.DboMarinaresco.Remove(marinaresco);
                                _context.SaveChanges();
                            }

                            // Crea un nuovo record in DboMarinaresco copiando tutte le proprietà
                            var nuovo = new DboMarinaresco();

                            // Copia tutte le proprietà usando la riflessione
                            foreach (var prop in modelType.GetProperties())
                            {
                                var targetProp = typeof(DboMarinaresco).GetProperty(prop.Name);
                                if (targetProp != null && targetProp.CanWrite)
                                {
                                    var value = prop.GetValue(edit);
                                    targetProp.SetValue(nuovo, value);
                                }
                            }

                            _context.DboMarinaresco.Add(nuovo);

                            // Salva tutte le modifiche
                            _context.SaveChanges();
                        }
                    }
                }), DispatcherPriority.Background);
            }
        }
    }
}