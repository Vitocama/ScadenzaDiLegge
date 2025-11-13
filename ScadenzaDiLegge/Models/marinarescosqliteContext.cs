using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ScadenzaDiLegge.Models
{
    public partial class marinarescosqliteContext : DbContext
    {
        public marinarescosqliteContext()
        {
        }

        public marinarescosqliteContext(DbContextOptions<marinarescosqliteContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DataMancante> DataMancante { get; set; }
        public virtual DbSet<Marinaresco> Marinaresco { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlite("Data Source=C:\\NSL_CHIARA\\marinarescosqlite.sqlite");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DataMancante>(entity =>
            {
                entity.HasIndex(e => e.Setdata)
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Setdata)
                    .IsRequired()
                    .HasColumnName("setdata")
                    .HasColumnType("NUMERIC")
                    .HasDefaultValueSql("40");
            });

            modelBuilder.Entity<Marinaresco>(entity =>
            {
                entity.ToTable("MARINARESCO");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Base).HasColumnName("BASE");

                entity.Property(e => e.CategoriaNav70).HasColumnName("CATEGORIA_NAV_70");

                entity.Property(e => e.Certificati).HasColumnName("CERTIFICATI");

                entity.Property(e => e.Comando).HasColumnName("COMANDO");

                entity.Property(e => e.DataVerifica).HasColumnName("DATA_VERIFICA");

                entity.Property(e => e.DataVerificaAnni).HasColumnName("DATA_VERIFICA_ANNI");

                entity.Property(e => e.DescrizioneSistemazione).HasColumnName("DESCRIZIONE_SISTEMAZIONE");

                entity.Property(e => e.DocumentiCorrelati).HasColumnName("DOCUMENTI_CORRELATI");

                entity.Property(e => e.Fattibilita).HasColumnName("FATTIBILITA");

                entity.Property(e => e.MarcaModelloMatricolaPortata).HasColumnName("MARCA_MODELLO_MATRICOLA_PORTATA");

                entity.Property(e => e.Note).HasColumnName("NOTE");

                entity.Property(e => e.Posizione).HasColumnName("POSIZIONE");

                entity.Property(e => e.ProssimaVerifica).HasColumnName("PROSSIMA_VERIFICA");

                entity.Property(e => e.Scadenza).HasColumnName("SCADENZA");

                entity.Property(e => e.TipoDiAccertamento).HasColumnName("TIPO_DI_ACCERTAMENTO");

                entity.Property(e => e.UnitaNavale).HasColumnName("UNITA_NAVALE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
