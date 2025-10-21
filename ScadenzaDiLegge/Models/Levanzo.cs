using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ScadenzaDiLegge.Models
{
    public partial class Levanzo
    {
        public long Id { get; set; }
        public string Nave { get; set; }
        public string Comando { get; set; }
        public string Base { get; set; }
        public long? Visto { get; set; }
        public string TipologiaApparecchiature { get; set; }
        public string ApparecchiaturaSistemazione { get; set; }
        public string Posizione { get; set; }
        public string MarcaModelloDimensioni { get; set; }
        public string TipoDiAccertamento { get; set; }
        public string DataEffettuazione { get; set; }
        public long? ValiditaAnni { get; set; }
        public string ProssimaScadenza { get; set; }
        public long? GiorniMancantiAllaScadenza { get; set; }
        public string Note { get; set; }
        public string DocumentiCorrelati { get; set; }
        public string Certificati { get; set; }
        public string Column18 { get; set; }
        public string Column19 { get; set; }
    }
}
