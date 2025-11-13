using ScadenzaDiLegge.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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




                    DateTime oggi = DateTime.Today;
                TimeSpan giorni;
                try
                {

                    var marinarescoList = context.Marinaresco.ToList();


                    DateTime anniValidita; 


                    foreach (var item in marinarescoList) 
                    {

                                     if(item.DataVerifica==null)
                            {
                                    item.ProssimaVerifica = new DateTime(1900, 1, 1);
                                item.Scadenza = 0;
                                item.DataVerificaAnni = 0;
                                item.DataVerifica = "01/01/1900";
                                continue;
                            }

                        if (
                            item.DataVerificaAnni == 0 )
                        {
                                item.ProssimaVerifica = new DateTime(1900, 1, 1);
                            item.Scadenza = 0;
                            continue;
                       
                        }


                        DateTime verifica=DateTime.Parse(item.DataVerifica);


                            item.ProssimaVerifica = verifica.AddMonths(item.DataVerificaAnni);



                        giorni = (item.ProssimaVerifica - oggi);

                        item.Scadenza = (int)giorni.TotalDays;
                           
                    
                    }

                    // 4️⃣ Salva tutti gli aggiornamenti
                    context.SaveChangesAsync();

                   
                    context.SaveChangesAsync();
                 }
                catch (Exception ex) {
                MessageBox.Show(ex.Message);
                }

            }


        }
    }
}