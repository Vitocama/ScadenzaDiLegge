using ScadenzaDiLegge.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ScadenzaDiLegge.InizializzazioneMarinaresco
{
    public class DataCalcoloMarcanti
    {
        ContentControl _areaComune;

        public DataCalcoloMarcanti(ContentControl areaComune)
        {
            _areaComune = areaComune;
        }
        public void inizializzaDateScadenza()
        {
            {
                


                _areaComune.Content = new HomeUserControl();





                var context = new marinarescosqliteContext();


                // 1️⃣ Recupera DataMancante
                var scade = context.DataMancante
                    .FirstOrDefault(x => x.Id == 1);



                if (DateTime.TryParseExact(scade.DataEvento, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataEvento))
                {
                    // Parsing riuscito, dataEvento è valida
                    string dataFormattata = dataEvento.ToString("dd/MM/yyyy");
                }


                    DateTime oggi = DateTime.Today;
                

                // 2️⃣ Aggiorna solo se necessario
              
                    // 3️⃣ Recupera tutti i record di DboMarinaresco
                    var marinarescoList = context.DboMarinaresco.ToList();


                    DateTime anniValidita;


                    foreach (var item in marinarescoList)


                    {    if (item.ProssimaScadenza == null)
                            continue;

                        if (item.ProssimaScadenza.Equals("NON CONFORME"))
                            continue;
                        if (!DateTime.TryParseExact(item.ProssimaScadenza.ToString(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime prossimaScadenza))
                            continue;
                        if (!DateTime.TryParseExact(item.DataEffettuazione.ToString(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dataEffettuazione))
                            continue;

                        DateTime dateTime = DateTime.Parse(item.ProssimaScadenza.ToString());
                        DateTime dateEffettuazione = DateTime.Parse(item.DataEffettuazione.ToString());
                        if (item.ValiditaAnni == null)
                            continue;
                        else
                        {
                            int anni = item.ValiditaAnni.Value;

                            anniValidita = dateEffettuazione.AddYears(anni);
                        }

                        // Calcola giorni mancanti
                        int giorni = (int)(prossimaScadenza - oggi).TotalDays;
                        item.GiorniMancantiAllaScadenza = giorni;
                        item.ProssimaScadenza = anniValidita.ToString("dd/MM/yyyy");
                    }

                    // 4️⃣ Salva tutti gli aggiornamenti
                    context.SaveChangesAsync();

                    // 5️⃣ Aggiorna DataEvento come "gg/MM/yyyy"
                    scade.DataEvento = oggi.ToString("dd/MM/yyyy");
                    context.SaveChangesAsync();
                

            }


        }
    }
}