using Dapper;
using Microsoft.Data.Sqlite;
using ScadenzaDiLegge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace ScadenzaDiLegge.DataBaseFrame
{
    public partial class SearchDatagridWindow : Window
    {
        string connectionString = @"Data Source=C:\NSL_CHIARA\marinarescosqlite.sqlite";

        public SearchDatagridWindow(List<string> listaProprietaMarinaresco)
        {
            InitializeComponent();
            Popolamento(listaProprietaMarinaresco);
        }

        private void Popolamento(List<string> listaProprietaMarinaresco)
        {
            var sql = new StringBuilder("SELECT * FROM Dbo_Marinaresco WHERE 1=1"); // ✅ Aggiunto WHERE 1=1
            var param = new DynamicParameters();

            if (!string.IsNullOrWhiteSpace(listaProprietaMarinaresco[0]))
            {
                sql.Append(" AND Id = @Id");
                param.Add("@Id", listaProprietaMarinaresco[0]);
            }

            if (!string.IsNullOrWhiteSpace(listaProprietaMarinaresco[1]))
            {
                sql.Append(" AND Nave LIKE @Nave");
                param.Add("@Nave", $"%{listaProprietaMarinaresco[1]}%");
            }

            if (!string.IsNullOrWhiteSpace(listaProprietaMarinaresco[2]))
            {
                sql.Append(" AND Comando LIKE @Comando");
                param.Add("@Comando", $"%{listaProprietaMarinaresco[2]}%");
            }

            if (!string.IsNullOrWhiteSpace(listaProprietaMarinaresco[3]))
            {
                sql.Append(" AND Base LIKE @Base");
                param.Add("@Base", $"%{listaProprietaMarinaresco[3]}%");
            }

            if (!string.IsNullOrWhiteSpace(listaProprietaMarinaresco[4]))
            {
                sql.Append(" AND Visto = @Visto");
                param.Add("@Visto", listaProprietaMarinaresco[4]);
            }

            if (!string.IsNullOrWhiteSpace(listaProprietaMarinaresco[5]))
            {
                sql.Append(" AND Tipologia_Apparecchiature LIKE @TipoApp");
                param.Add("@TipoApp", $"%{listaProprietaMarinaresco[5]}%");
            }

            if (!string.IsNullOrWhiteSpace(listaProprietaMarinaresco[6]))
            {
                sql.Append(" AND Apparecchiatura_Sistemazione LIKE @Sist");
                param.Add("@Sist", $"%{listaProprietaMarinaresco[6]}%");
            }

            if (!string.IsNullOrWhiteSpace(listaProprietaMarinaresco[7]))
            {
                sql.Append(" AND Posizione LIKE @Posizione");
                param.Add("@Posizione", $"%{listaProprietaMarinaresco[7]}%");
            }

            if (!string.IsNullOrWhiteSpace(listaProprietaMarinaresco[8]))
            {
                sql.Append(" AND Marca_Modello_Dimensioni LIKE @Marca");
                param.Add("@Marca", $"%{listaProprietaMarinaresco[8]}%");
            }

            if (!string.IsNullOrWhiteSpace(listaProprietaMarinaresco[9]))
            {
                sql.Append(" AND Tipo_Di_Accertamento LIKE @TipoAcc");
                param.Add("@TipoAcc", $"%{listaProprietaMarinaresco[9]}%");
            }

            if (!string.IsNullOrWhiteSpace(listaProprietaMarinaresco[10]))
            {
                sql.Append(" AND Data_Effettuazione LIKE @DataEff");
                param.Add("@DataEff", $"%{listaProprietaMarinaresco[10]}%");
            }

            if (!string.IsNullOrWhiteSpace(listaProprietaMarinaresco[11]))
            {
                sql.Append(" AND Validita_Anni = @Validita");
                param.Add("@Validita", listaProprietaMarinaresco[11]);
            }

            if (!string.IsNullOrWhiteSpace(listaProprietaMarinaresco[12]))
            {
                sql.Append(" AND Prossima_Scadenza LIKE @Scad");
                param.Add("@Scad", $"%{listaProprietaMarinaresco[12]}%");
            }

            if (!string.IsNullOrWhiteSpace(listaProprietaMarinaresco[13]))
            {
                sql.Append(" AND Giorni_Mancanti_AllaScadenza = @Giorni");
                param.Add("@Giorni", listaProprietaMarinaresco[13]);
            }

            if (!string.IsNullOrWhiteSpace(listaProprietaMarinaresco[14]))
            {
                sql.Append(" AND Note LIKE @Note");
                param.Add("@Note", $"%{listaProprietaMarinaresco[14]}%");
            }

            if (!string.IsNullOrWhiteSpace(listaProprietaMarinaresco[15]))
            {
                sql.Append(" AND Documenti_Correlati LIKE @Doc");
                param.Add("@Doc", $"%{listaProprietaMarinaresco[15]}%");
            }

            if (!string.IsNullOrWhiteSpace(listaProprietaMarinaresco[16]))
            {
                sql.Append(" AND Certificati LIKE @Cert");
                param.Add("@Cert", $"%{listaProprietaMarinaresco[16]}%");
            }

            if (!string.IsNullOrWhiteSpace(listaProprietaMarinaresco[17]))
            {
                sql.Append(" AND Column18 LIKE @C18");
                param.Add("@C18", $"%{listaProprietaMarinaresco[17]}%");
            }

            if (!string.IsNullOrWhiteSpace(listaProprietaMarinaresco[18]))
            {
                sql.Append(" AND Column19 LIKE @C19");
                param.Add("@C19", $"%{listaProprietaMarinaresco[18]}%");
            }

            string finalSql = sql.ToString();

            // ✅ ESEGUI LA QUERY E POPOLA IL DATAGRID
            try
            {
                using (var connection = new SqliteConnection(connectionString))
                {
                    var risultati = connection.Query(finalSql, param).ToList();

                    // Assumi che il tuo DataGrid si chiami "dgRisultati"
                    datagridSearch.ItemsSource = risultati;

                    MessageBox.Show($"Trovati {risultati.Count} risultati");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore: {ex.Message}");
            }
        }
        }
    }
