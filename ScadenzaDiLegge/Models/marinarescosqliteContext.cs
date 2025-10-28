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
        public virtual DbSet<DboMarinaresco> DboMarinaresco { get; set; }

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
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<DboMarinaresco>(entity =>
            {
                entity.ToTable("dbo_MARINARESCO");

                entity.HasIndex(e => e.Id)
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApparecchiaturaSistemazione).HasColumnName("APPARECCHIATURA_SISTEMAZIONE");

                entity.Property(e => e.Base).HasColumnName("BASE");

                entity.Property(e => e.Certificati).HasColumnName("CERTIFICATI");

                entity.Property(e => e.Column18).HasColumnName("column18");

                entity.Property(e => e.Column19).HasColumnName("column19");

                entity.Property(e => e.Comando).HasColumnName("COMANDO");

                entity.Property(e => e.DataEffettuazione).HasColumnName("DATA_EFFETTUAZIONE");

                entity.Property(e => e.DocumentiCorrelati).HasColumnName("DOCUMENTI_CORRELATI");

                entity.Property(e => e.GiorniMancantiAllaScadenza).HasColumnName("GIORNI_MANCANTI_ALLA_SCADENZA");

                entity.Property(e => e.MarcaModelloDimensioni).HasColumnName("MARCA_MODELLO_DIMENSIONI");

                entity.Property(e => e.Note).HasColumnName("NOTE");

                entity.Property(e => e.ProssimaScadenza).HasColumnName("PROSSIMA_SCADENZA");

                entity.Property(e => e.TipoDiAccertamento).HasColumnName("TIPO_DI_ACCERTAMENTO");

                entity.Property(e => e.TipologiaApparecchiature).HasColumnName("TIPOLOGIA_APPARECCHIATURE");

                entity.Property(e => e.ValiditaAnni).HasColumnName("VALIDITA_anni");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
