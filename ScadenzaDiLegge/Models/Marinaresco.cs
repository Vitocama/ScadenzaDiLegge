using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ScadenzaDiLegge.Models
{
    public partial class Marinaresco
    {
        public int Id { get; set; }
        public string UnitaNavale { get; set; }
        public string Comando { get; set; }
        public string Base { get; set; }
        public bool Fattibilita { get; set; }
        public string CategoriaNav70 { get; set; }
        public string DescrizioneSistemazione { get; set; }
        public string Posizione { get; set; }
        public string MarcaModelloMatricolaPortata { get; set; }
        public string TipoDiAccertamento { get; set; }
        public string DataVerifica { get; set; }
        public int DataVerificaAnni { get; set; }
        public DateTime ProssimaVerifica { get; set; }
        public int Scadenza { get; set; }
        public string Note { get; set; }
        public string DocumentiCorrelati { get; set; }
        public string Certificati { get; set; }
    }
}
