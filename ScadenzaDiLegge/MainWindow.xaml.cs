using Dapper;
using Microsoft.Data.Sqlite;
using ScadenzaDiLegge.InizializzazioneMarinaresco;
using ScadenzaDiLegge.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows;

namespace ScadenzaDiLegge
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            DataCalcoloMarcanti dataCalcoloMarcanti = new DataCalcoloMarcanti(AreaComune);
            dataCalcoloMarcanti.inizializzaDateScadenza();


        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }

    }
    }


