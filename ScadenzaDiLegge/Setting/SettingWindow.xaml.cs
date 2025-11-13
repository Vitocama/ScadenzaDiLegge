using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using Microsoft.Win32;
using ScadenzaDiLegge.Models;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace ScadenzaDiLegge.Setting
{
    /// <summary>
    /// Logica di interazione per SettingWindow.xaml
    /// </summary>
    public partial class SettingWindow : Window
    {
        public SettingWindow()
        {
            InitializeComponent();
            List<int> days = new List<int>();

            for (int i = 1; i <= 150; i++)
            {
                days.Add(i);
            }
            var context = new marinarescosqliteContext();
            int settaggio = context.DataMancante.Select(x => x.Setdata).FirstOrDefault();

            settaggiodatatextBox.Text = "Ultimo valore salvato: " + (settaggio + 1).ToString();

            GiorniScadenzaComboBox.ItemsSource = days;
        }

   


        private void Down_MouseDown(object sender, MouseButtonEventArgs e)
        {

            try
            {
                using (var db = new marinarescosqliteContext())
                {
                    var settaggio = db.DataMancante.First(x => x.Id == 1);
                    settaggio.DataEvento = "01/01/1900";
                    settaggio.Setdata = int.Parse(GiorniScadenzaComboBox.SelectedIndex.ToString());
                    settaggiodatatextBox.Text = "Ultimo valore salvato: " + (settaggio.Setdata + 1).ToString();

                    db.SaveChanges();
                    MessageBox.Show(
    "E' stato settato il valore: "+(settaggio.Setdata+1),
    "Attenzione",
    MessageBoxButton.OK,
  MessageBoxImage.Information
);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nel salvataggio delle impostazioni: " + ex.Message, "Errore", MessageBoxButton.OK, MessageBoxImage.Error);

            }

         

            this.Close();

        }
        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Seleziona il database SQLite",
                Filter = "Database SQLite (*.sqlite;*.db;*.sqlite3)|*.sqlite;*.db;*.sqlite3|Tutti i file (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() == true)
            {
                string dbPath = openFileDialog.FileName;

                // opzionale: mostra il percorso scelto in una TextBox
                txtEditor.Text = dbPath;

                // esempio di uso pratico con EF Core:
                // puoi passare dinamicamente la connection string al tuo DbContext
                string connectionString = $"Data Source={dbPath};";

                using (var context = new MioDbContext(connectionString))
                {
                    // esempio: test rapido di connessione
                    bool canConnect = context.Database.CanConnect();
                    MessageBox.Show(canConnect
                        ? "Connessione riuscita!"
                        : "Errore nella connessione al database.");
                }
            }
        }



        public partial class MioDbContext : DbContext
        {
            private readonly string _connectionString;

            public MioDbContext(string connectionString)
            {
                _connectionString = connectionString;
            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseSqlite(_connectionString);
                }
            }
        }



    }
}
