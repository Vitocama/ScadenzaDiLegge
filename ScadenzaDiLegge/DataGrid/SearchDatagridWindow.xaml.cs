using Dapper;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using ScadenzaDiLegge.Delegate;
using ScadenzaDiLegge.DeleteAggiungiRinomina;
using ScadenzaDiLegge.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace ScadenzaDiLegge.DataBaseFrame
{
    public partial class SearchDatagridWindow : Window
    {

        public SearchDatagridWindow(List<string> listaProprietaMarinaresco)
        {
            InitializeComponent();


            datagrid.RowEditEnding += Edit_Datagrid.RonRowEditEnding;

          //  datagrid.LoadingRow += Datagrid_LoadingRow;


            string _id = listaProprietaMarinaresco[0];
            string _nave = listaProprietaMarinaresco[1];
            string _comando = listaProprietaMarinaresco[2];
            string _base = listaProprietaMarinaresco[3];
            string _Fattibilita = listaProprietaMarinaresco[4];
            string _tipologia = listaProprietaMarinaresco[5];
            string _appSistema = listaProprietaMarinaresco[6];
            string _posizione = listaProprietaMarinaresco[7];
            string _marcaModelli = listaProprietaMarinaresco[8];
            string _colaccertamento = listaProprietaMarinaresco[9];
            string _dataEff = listaProprietaMarinaresco[10];
            string _validita = listaProprietaMarinaresco[11];
            string _scadenza = listaProprietaMarinaresco[12];
            string _giorniMancanti = listaProprietaMarinaresco[13];
            string _colnote = listaProprietaMarinaresco[14];
            string _coldocumenti = listaProprietaMarinaresco[15];
            string _certificati = listaProprietaMarinaresco[16];





            // Carico lista dal DB
            var context = new marinarescosqliteContext();
            var lista = context.DboMarinaresco.ToList();

            // Creo query filtrabile
            var query = lista.AsQueryable();

            // ✅ FILTRO ID
            if (!string.IsNullOrEmpty(_id) && int.TryParse(_id, out int idValue))
            {
                query = query.Where(p => p.Id == idValue);
            }

            // ✅ FILTRO NAVE
            if (!string.IsNullOrEmpty(_nave))
            {
                query = query.Where(p => EF.Functions.Like(p.Nave, $"%{_nave}%"));
            }

            // ✅ FILTRO COMANDO
            if (!string.IsNullOrEmpty(_comando))
            {
                query = query.Where(p => EF.Functions.Like(p.Comando, $"%{_comando}%"));
            }

            // ✅ FILTRO BASE
            if (!string.IsNullOrEmpty(_base))
            {
                query = query.Where(p => EF.Functions.Like(p.Base, $"%{_base}%"));
            }

            // ✅ FILTRO Fattibilita
            if (!string.IsNullOrEmpty(_Fattibilita) && int.TryParse(_id, out  idValue))
            {
                query = query.Where(p => p.Fattibilita== idValue);
            }

            // ✅ FILTRO TIPOLOGIA
            if (!string.IsNullOrEmpty(_tipologia))
            {
                query = query.Where(p => EF.Functions.Like(p.TipologiaApparecchiature, $"%{_tipologia}%"));
            }

            // ✅ FILTRO APP SISTEMA
            if (!string.IsNullOrEmpty(_appSistema))
            {
                query = query.Where(p => EF.Functions.Like(p.ApparecchiaturaSistemazione, $"%{_appSistema}%"));
            }

            // ✅ FILTRO POSIZIONE
            if (!string.IsNullOrEmpty(_posizione))
            {
                query = query.Where(p => EF.Functions.Like(p.Posizione, $"%{_posizione}%"));
            }

            // ✅ FILTRO MARCA MODELLI
            if (!string.IsNullOrEmpty(_marcaModelli))
            {
                query = query.Where(p => EF.Functions.Like(p.MarcaModelloDimensioni, $"%{_marcaModelli}%"));
            }

            // ✅ FILTRO ACCERTAMENTO
            if (!string.IsNullOrEmpty(_colaccertamento))
            {
                query = query.Where(p => EF.Functions.Like(p.TipoDiAccertamento, $"%{_colaccertamento}%"));
            }

            // ✅ FILTRO DATA EFF
            if (!string.IsNullOrEmpty(_dataEff))
            {
                query = query.Where(p => EF.Functions.Like(p.DataEffettuazione, $"%{_dataEff}%"));
            }

            // ✅ FILTRO VALIDITA
            if (!string.IsNullOrEmpty(_id) && int.TryParse(_id, out  idValue))
            {
                query = query.Where(p => p.ValiditaAnni==idValue);
            }

            // ✅ FILTRO SCADENZA
            if (!string.IsNullOrEmpty(_scadenza))
            {
                query = query.Where(p => EF.Functions.Like(p.ProssimaScadenza, $"%{_scadenza}%"));
            }

            // ✅ FILTRO GIORNI MANCANTI
            if (!string.IsNullOrEmpty(_giorniMancanti) && int.TryParse(_id, out idValue))
            {
                query = query.Where(p => p.GiorniMancantiAllaScadenza==idValue);
            }

            // ✅ FILTRO NOTE
            if (!string.IsNullOrEmpty(_colnote))
            {
                query = query.Where(p => EF.Functions.Like(p.Note, $"%{_colnote}%"));
            }

            // ✅ FILTRO DOCUMENTI
            if (!string.IsNullOrEmpty(_coldocumenti))
            {
                query = query.Where(p => EF.Functions.Like(p.DocumentiCorrelati, $"%{_coldocumenti}%"));
            }

            // ✅ FILTRO CERTIFICATI
            if (!string.IsNullOrEmpty(_certificati))
            {
                query = query.Where(p => EF.Functions.Like(p.Certificati, $"%{_certificati}%"));
            }


            // ✅ RISULTATO FINALE
            var listaSearch = query.ToList();
            datagrid.ItemsSource = listaSearch;


        }
        
    }
}

