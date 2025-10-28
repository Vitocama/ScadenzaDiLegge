using Dapper;
using Microsoft.Data.Sqlite;
using ScadenzaDiLegge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace ScadenzaDiLegge
{
    public partial class MainWindow : Window
    {
        private readonly string _connectionString = "Data Source=C:\\NSL_CHIARA\\marinarescosqlite.sqlite";

        public MainWindow()
        {
            InitializeComponent();
            inizializzaDateScadenza();
        }

        private void inizializzaDateScadenza()
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();

                // 1️⃣ Recupera DataMancante
                var scade = connection.Query<DataMancante>(
                    "SELECT * FROM DataMancante WHERE Id = @Id",
                    new { Id = 1 }).ToList();

                string dataevento = scade.Select(x => x.DataEvento).FirstOrDefault()?.ToString();

                if (string.IsNullOrEmpty(dataevento)) return;

                DateTime dateTime = DateTime.Parse(dataevento);
                DateTime oggi = DateTime.Today;

                if (dateTime != oggi)
                {
                    // 2️⃣ Aggiorna DataEvento
                    connection.Execute(
                        "UPDATE DataMancante SET DataEvento = @DataEvento WHERE Id = @Id",
                        new { DataEvento = oggi.ToString("yyyy-MM-dd"), Id = 1 });

                    // 3️⃣ Recupera DboMarinaresco
                    var marinaresco = connection.Query<DboMarinaresco>(
                        "SELECT * FROM DboMarinaresco").ToList();

                    foreach (var item in marinaresco)
                    {
                        if (!DateTime.TryParse(item.ProssimaScadenza?.ToString(), out DateTime prossimaScadenza))
                            continue;
                        if (!DateTime.TryParse(item.DataEffettuazione?.ToString(), out DateTime dataEffettuazione))
                            continue;

                        TimeSpan diff = (prossimaScadenza - oggi);
                        int giorni = (int)diff.TotalDays;
                        item.GiorniMancantiAllaScadenza = giorni;

                        // 4️⃣ Aggiorna ogni record nel DB
                        connection.Execute(
                            "UPDATE DboMarinaresco SET GiorniMancantiAllaScadenza = @Giorni WHERE Id = @Id",
                            new { Giorni = giorni, Id = item.Id });
                    }
                }
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
