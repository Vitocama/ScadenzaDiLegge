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
             var context = new marinarescosqliteContext();

            // 1️⃣ Recupera DataMancante
            var scade =context.DataMancante
                .FirstOrDefault(x => x.Id == 1);

            if (scade == null || string.IsNullOrEmpty(scade.DataEvento))
                return;

            // Converte la stringa "dd/MM/yyyy" in DateTime
            if (!DateTime.TryParseExact(scade.DataEvento, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dataEvento))
                return;

            DateTime oggi = DateTime.Today;

            // 2️⃣ Aggiorna solo se necessario
            if (dataEvento != oggi)
            {
                // 3️⃣ Recupera tutti i record di DboMarinaresco
                var marinarescoList = context.DboMarinaresco.ToList();

                foreach (var item in marinarescoList)
                {
                    if (!DateTime.TryParseExact(item.ProssimaScadenza, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime prossimaScadenza))
                        continue;
                    if (!DateTime.TryParseExact(item.DataEffettuazione, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dataEffettuazione))
                        continue;

                    // Calcola giorni mancanti
                    int giorni = (int)(prossimaScadenza - oggi).TotalDays;
                    item.GiorniMancantiAllaScadenza = giorni;
                }

                // 4️⃣ Salva tutti gli aggiornamenti
                 context.SaveChangesAsync();

                // 5️⃣ Aggiorna DataEvento come "gg/MM/yyyy"
                scade.DataEvento = oggi.ToString("dd/MM/yyyy");
                context.SaveChangesAsync();
            }

        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
