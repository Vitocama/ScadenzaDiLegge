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

        public virtual DbSet<Bettica> Bettica { get; set; }
        public virtual DbSet<Borsini> Borsini { get; set; }
        public virtual DbSet<Cassiopea> Cassiopea { get; set; }
        public virtual DbSet<Cigali> Cigali { get; set; }
        public virtual DbSet<DboMarinaresco> DboMarinaresco { get; set; }
        public virtual DbSet<Favignana> Favignana { get; set; }
        public virtual DbSet<Foscari> Foscari { get; set; }
        public virtual DbSet<Gasa1013> Gasa1013 { get; set; }
        public virtual DbSet<Gasa1014> Gasa1014 { get; set; }
        public virtual DbSet<Gasa1023> Gasa1023 { get; set; }
        public virtual DbSet<Gd139> Gd139 { get; set; }
        public virtual DbSet<Gems16> Gems16 { get; set; }
        public virtual DbSet<Gg1012> Gg1012 { get; set; }
        public virtual DbSet<Ggs1018> Ggs1018 { get; set; }
        public virtual DbSet<Gkm28> Gkm28 { get; set; }
        public virtual DbSet<Go53> Go53 { get; set; }
        public virtual DbSet<Grg563> Grg563 { get; set; }
        public virtual DbSet<Grg564> Grg564 { get; set; }
        public virtual DbSet<Jdg10> Jdg10 { get; set; }
        public virtual DbSet<Levanzo> Levanzo { get; set; }
        public virtual DbSet<Libra> Libra { get; set; }
        public virtual DbSet<Linosa> Linosa { get; set; }
        public virtual DbSet<Lipari> Lipari { get; set; }
        public virtual DbSet<Orione> Orione { get; set; }
        public virtual DbSet<Panarea> Panarea { get; set; }
        public virtual DbSet<Polifemo> Polifemo { get; set; }
        public virtual DbSet<Portoconte> Portoconte { get; set; }
        public virtual DbSet<Portovenere> Portovenere { get; set; }
        public virtual DbSet<Rp102> Rp102 { get; set; }
        public virtual DbSet<Rp112> Rp112 { get; set; }
        public virtual DbSet<Rp123> Rp123 { get; set; }
        public virtual DbSet<Rp125> Rp125 { get; set; }
        public virtual DbSet<Rp126> Rp126 { get; set; }
        public virtual DbSet<Rp130> Rp130 { get; set; }
        public virtual DbSet<Rp131> Rp131 { get; set; }
        public virtual DbSet<Salina> Salina { get; set; }
        public virtual DbSet<Scire> Scire { get; set; }
        public virtual DbSet<Sirio> Sirio { get; set; }
        public virtual DbSet<Spica> Spica { get; set; }
        public virtual DbSet<Ticino> Ticino { get; set; }
        public virtual DbSet<Tirso> Tirso { get; set; }
        public virtual DbSet<Vega> Vega { get; set; }

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
            modelBuilder.Entity<Bettica>(entity =>
            {
                entity.ToTable("BETTICA");

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

                entity.Property(e => e.GiorniMancantiAllaScadenza)
                    .HasColumnName("GIORNI_MANCANTI_ALLA_SCADENZA")
                    .HasColumnType("INT");

                entity.Property(e => e.MarcaModelloDimensioni).HasColumnName("MARCA_MODELLO_DIMENSIONI");

                entity.Property(e => e.Note).HasColumnName("NOTE");

                entity.Property(e => e.ProssimaScadenza).HasColumnName("PROSSIMA_SCADENZA");

                entity.Property(e => e.TipoDiAccertamento).HasColumnName("TIPO_DI_ACCERTAMENTO");

                entity.Property(e => e.TipologiaApparecchiature).HasColumnName("TIPOLOGIA_APPARECCHIATURE");

                entity.Property(e => e.ValiditaAnni)
                    .HasColumnName("VALIDITA_anni")
                    .HasColumnType("INT");

                entity.Property(e => e.Visto).HasColumnType("INT");
            });

            modelBuilder.Entity<Borsini>(entity =>
            {
                entity.ToTable("BORSINI");

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

                entity.Property(e => e.GiorniMancantiAllaScadenza)
                    .HasColumnName("GIORNI_MANCANTI_ALLA_SCADENZA")
                    .HasColumnType("INT");

                entity.Property(e => e.MarcaModelloDimensioni).HasColumnName("MARCA_MODELLO_DIMENSIONI");

                entity.Property(e => e.Note).HasColumnName("NOTE");

                entity.Property(e => e.ProssimaScadenza).HasColumnName("PROSSIMA_SCADENZA");

                entity.Property(e => e.TipoDiAccertamento).HasColumnName("TIPO_DI_ACCERTAMENTO");

                entity.Property(e => e.TipologiaApparecchiature).HasColumnName("TIPOLOGIA_APPARECCHIATURE");

                entity.Property(e => e.ValiditaAnni)
                    .HasColumnName("VALIDITA_anni")
                    .HasColumnType("INT");

                entity.Property(e => e.Visto).HasColumnType("INT");
            });

            modelBuilder.Entity<Cassiopea>(entity =>
            {
                entity.ToTable("CASSIOPEA");

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

                entity.Property(e => e.GiorniMancantiAllaScadenza)
                    .HasColumnName("GIORNI_MANCANTI_ALLA_SCADENZA")
                    .HasColumnType("INT");

                entity.Property(e => e.MarcaModelloDimensioni).HasColumnName("MARCA_MODELLO_DIMENSIONI");

                entity.Property(e => e.Note).HasColumnName("NOTE");

                entity.Property(e => e.ProssimaScadenza).HasColumnName("PROSSIMA_SCADENZA");

                entity.Property(e => e.TipoDiAccertamento).HasColumnName("TIPO_DI_ACCERTAMENTO");

                entity.Property(e => e.TipologiaApparecchiature).HasColumnName("TIPOLOGIA_APPARECCHIATURE");

                entity.Property(e => e.ValiditaAnni)
                    .HasColumnName("VALIDITA_anni")
                    .HasColumnType("INT");

                entity.Property(e => e.Visto).HasColumnType("INT");
            });

            modelBuilder.Entity<Cigali>(entity =>
            {
                entity.ToTable("cigali");

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

                entity.Property(e => e.GiorniMancantiAllaScadenza)
                    .HasColumnName("GIORNI_MANCANTI_ALLA_SCADENZA")
                    .HasColumnType("INT");

                entity.Property(e => e.MarcaModelloDimensioni).HasColumnName("MARCA_MODELLO_DIMENSIONI");

                entity.Property(e => e.Note).HasColumnName("NOTE");

                entity.Property(e => e.ProssimaScadenza).HasColumnName("PROSSIMA_SCADENZA");

                entity.Property(e => e.TipoDiAccertamento).HasColumnName("TIPO_DI_ACCERTAMENTO");

                entity.Property(e => e.TipologiaApparecchiature).HasColumnName("TIPOLOGIA_APPARECCHIATURE");

                entity.Property(e => e.ValiditaAnni)
                    .HasColumnName("VALIDITA_anni")
                    .HasColumnType("INT");

                entity.Property(e => e.Visto).HasColumnType("INT");
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

            modelBuilder.Entity<Favignana>(entity =>
            {
                entity.ToTable("FAVIGNANA");

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

                entity.Property(e => e.GiorniMancantiAllaScadenza)
                    .HasColumnName("GIORNI_MANCANTI_ALLA_SCADENZA")
                    .HasColumnType("INT");

                entity.Property(e => e.MarcaModelloDimensioni).HasColumnName("MARCA_MODELLO_DIMENSIONI");

                entity.Property(e => e.Note).HasColumnName("NOTE");

                entity.Property(e => e.ProssimaScadenza).HasColumnName("PROSSIMA_SCADENZA");

                entity.Property(e => e.TipoDiAccertamento).HasColumnName("TIPO_DI_ACCERTAMENTO");

                entity.Property(e => e.TipologiaApparecchiature).HasColumnName("TIPOLOGIA_APPARECCHIATURE");

                entity.Property(e => e.ValiditaAnni)
                    .HasColumnName("VALIDITA_anni")
                    .HasColumnType("INT");

                entity.Property(e => e.Visto).HasColumnType("INT");
            });

            modelBuilder.Entity<Foscari>(entity =>
            {
                entity.ToTable("FOSCARI");

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

                entity.Property(e => e.GiorniMancantiAllaScadenza)
                    .HasColumnName("GIORNI_MANCANTI_ALLA_SCADENZA")
                    .HasColumnType("INT");

                entity.Property(e => e.MarcaModelloDimensioni).HasColumnName("MARCA_MODELLO_DIMENSIONI");

                entity.Property(e => e.Note).HasColumnName("NOTE");

                entity.Property(e => e.ProssimaScadenza).HasColumnName("PROSSIMA_SCADENZA");

                entity.Property(e => e.TipoDiAccertamento).HasColumnName("TIPO_DI_ACCERTAMENTO");

                entity.Property(e => e.TipologiaApparecchiature).HasColumnName("TIPOLOGIA_APPARECCHIATURE");

                entity.Property(e => e.ValiditaAnni)
                    .HasColumnName("VALIDITA_anni")
                    .HasColumnType("INT");

                entity.Property(e => e.Visto).HasColumnType("INT");
            });

            modelBuilder.Entity<Gasa1013>(entity =>
            {
                entity.ToTable("GASA1013");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApparecchiaturaSistemazione).HasColumnName("APPARECCHIATURA_SISTEMAZIONE");

                entity.Property(e => e.Base).HasColumnName("BASE");

                entity.Property(e => e.Certificati).HasColumnName("CERTIFICATI");

                entity.Property(e => e.Column18).HasColumnName("column18");

                entity.Property(e => e.Column19).HasColumnName("column19");

                entity.Property(e => e.Comando).HasColumnName("COMANDO");

                entity.Property(e => e.DataEffettuazione).HasColumnName("DATA_EFFETTUAZIONE");

                entity.Property(e => e.DocumentiCorrelati).HasColumnName("DOCUMENTI_CORRELATI");

                entity.Property(e => e.GiorniMancantiAllaScadenza)
                    .HasColumnName("GIORNI_MANCANTI_ALLA_SCADENZA")
                    .HasColumnType("INT");

                entity.Property(e => e.MarcaModelloDimensioni).HasColumnName("MARCA_MODELLO_DIMENSIONI");

                entity.Property(e => e.Note).HasColumnName("NOTE");

                entity.Property(e => e.ProssimaScadenza).HasColumnName("PROSSIMA_SCADENZA");

                entity.Property(e => e.TipoDiAccertamento).HasColumnName("TIPO_DI_ACCERTAMENTO");

                entity.Property(e => e.TipologiaApparecchiature).HasColumnName("TIPOLOGIA_APPARECCHIATURE");

                entity.Property(e => e.ValiditaAnni)
                    .HasColumnName("VALIDITA_anni")
                    .HasColumnType("INT");

                entity.Property(e => e.Visto).HasColumnType("INT");
            });

            modelBuilder.Entity<Gasa1014>(entity =>
            {
                entity.ToTable("GASA1014");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApparecchiaturaSistemazione).HasColumnName("APPARECCHIATURA_SISTEMAZIONE");

                entity.Property(e => e.Base).HasColumnName("BASE");

                entity.Property(e => e.Certificati).HasColumnName("CERTIFICATI");

                entity.Property(e => e.Column18).HasColumnName("column18");

                entity.Property(e => e.Column19).HasColumnName("column19");

                entity.Property(e => e.Comando).HasColumnName("COMANDO");

                entity.Property(e => e.DataEffettuazione).HasColumnName("DATA_EFFETTUAZIONE");

                entity.Property(e => e.DocumentiCorrelati).HasColumnName("DOCUMENTI_CORRELATI");

                entity.Property(e => e.GiorniMancantiAllaScadenza)
                    .HasColumnName("GIORNI_MANCANTI_ALLA_SCADENZA")
                    .HasColumnType("INT");

                entity.Property(e => e.MarcaModelloDimensioni).HasColumnName("MARCA_MODELLO_DIMENSIONI");

                entity.Property(e => e.Note).HasColumnName("NOTE");

                entity.Property(e => e.ProssimaScadenza).HasColumnName("PROSSIMA_SCADENZA");

                entity.Property(e => e.TipoDiAccertamento).HasColumnName("TIPO_DI_ACCERTAMENTO");

                entity.Property(e => e.TipologiaApparecchiature).HasColumnName("TIPOLOGIA_APPARECCHIATURE");

                entity.Property(e => e.ValiditaAnni)
                    .HasColumnName("VALIDITA_anni")
                    .HasColumnType("INT");

                entity.Property(e => e.Visto).HasColumnType("INT");
            });

            modelBuilder.Entity<Gasa1023>(entity =>
            {
                entity.ToTable("GASA1023");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApparecchiaturaSistemazione).HasColumnName("APPARECCHIATURA_SISTEMAZIONE");

                entity.Property(e => e.Base).HasColumnName("BASE");

                entity.Property(e => e.Certificati).HasColumnName("CERTIFICATI");

                entity.Property(e => e.Column18).HasColumnName("column18");

                entity.Property(e => e.Column19).HasColumnName("column19");

                entity.Property(e => e.Comando).HasColumnName("COMANDO");

                entity.Property(e => e.DataEffettuazione).HasColumnName("DATA_EFFETTUAZIONE");

                entity.Property(e => e.DocumentiCorrelati).HasColumnName("DOCUMENTI_CORRELATI");

                entity.Property(e => e.GiorniMancantiAllaScadenza)
                    .HasColumnName("GIORNI_MANCANTI_ALLA_SCADENZA")
                    .HasColumnType("INT");

                entity.Property(e => e.MarcaModelloDimensioni).HasColumnName("MARCA_MODELLO_DIMENSIONI");

                entity.Property(e => e.Note).HasColumnName("NOTE");

                entity.Property(e => e.ProssimaScadenza).HasColumnName("PROSSIMA_SCADENZA");

                entity.Property(e => e.TipoDiAccertamento).HasColumnName("TIPO_DI_ACCERTAMENTO");

                entity.Property(e => e.TipologiaApparecchiature).HasColumnName("TIPOLOGIA_APPARECCHIATURE");

                entity.Property(e => e.ValiditaAnni)
                    .HasColumnName("VALIDITA_anni")
                    .HasColumnType("INT");

                entity.Property(e => e.Visto).HasColumnType("INT");
            });

            modelBuilder.Entity<Gd139>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApparecchiaturaSistemazione).HasColumnName("APPARECCHIATURA_SISTEMAZIONE");

                entity.Property(e => e.Base).HasColumnName("BASE");

                entity.Property(e => e.Certificati).HasColumnName("CERTIFICATI");

                entity.Property(e => e.Column18).HasColumnName("column18");

                entity.Property(e => e.Column19).HasColumnName("column19");

                entity.Property(e => e.Comando).HasColumnName("COMANDO");

                entity.Property(e => e.DataEffettuazione).HasColumnName("DATA_EFFETTUAZIONE");

                entity.Property(e => e.DocumentiCorrelati).HasColumnName("DOCUMENTI_CORRELATI");

                entity.Property(e => e.GiorniMancantiAllaScadenza)
                    .HasColumnName("GIORNI_MANCANTI_ALLA_SCADENZA")
                    .HasColumnType("INT");

                entity.Property(e => e.MarcaModelloDimensioni).HasColumnName("MARCA_MODELLO_DIMENSIONI");

                entity.Property(e => e.Note).HasColumnName("NOTE");

                entity.Property(e => e.ProssimaScadenza).HasColumnName("PROSSIMA_SCADENZA");

                entity.Property(e => e.TipoDiAccertamento).HasColumnName("TIPO_DI_ACCERTAMENTO");

                entity.Property(e => e.TipologiaApparecchiature).HasColumnName("TIPOLOGIA_APPARECCHIATURE");

                entity.Property(e => e.ValiditaAnni)
                    .HasColumnName("VALIDITA_anni")
                    .HasColumnType("INT");

                entity.Property(e => e.Visto).HasColumnType("INT");
            });

            modelBuilder.Entity<Gems16>(entity =>
            {
                entity.ToTable("gems16");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApparecchiaturaSistemazione).HasColumnName("APPARECCHIATURA_SISTEMAZIONE");

                entity.Property(e => e.Base).HasColumnName("BASE");

                entity.Property(e => e.Certificati).HasColumnName("CERTIFICATI");

                entity.Property(e => e.Column18).HasColumnName("column18");

                entity.Property(e => e.Column19).HasColumnName("column19");

                entity.Property(e => e.Comando).HasColumnName("COMANDO");

                entity.Property(e => e.DataEffettuazione).HasColumnName("DATA_EFFETTUAZIONE");

                entity.Property(e => e.DocumentiCorrelati).HasColumnName("DOCUMENTI_CORRELATI");

                entity.Property(e => e.GiorniMancantiAllaScadenza)
                    .HasColumnName("GIORNI_MANCANTI_ALLA_SCADENZA")
                    .HasColumnType("INT");

                entity.Property(e => e.MarcaModelloDimensioni).HasColumnName("MARCA_MODELLO_DIMENSIONI");

                entity.Property(e => e.Note).HasColumnName("NOTE");

                entity.Property(e => e.ProssimaScadenza).HasColumnName("PROSSIMA_SCADENZA");

                entity.Property(e => e.TipoDiAccertamento).HasColumnName("TIPO_DI_ACCERTAMENTO");

                entity.Property(e => e.TipologiaApparecchiature).HasColumnName("TIPOLOGIA_APPARECCHIATURE");

                entity.Property(e => e.ValiditaAnni)
                    .HasColumnName("VALIDITA_anni")
                    .HasColumnType("INT");

                entity.Property(e => e.Visto).HasColumnType("INT");
            });

            modelBuilder.Entity<Gg1012>(entity =>
            {
                entity.ToTable("gg1012");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApparecchiaturaSistemazione).HasColumnName("APPARECCHIATURA_SISTEMAZIONE");

                entity.Property(e => e.Base).HasColumnName("BASE");

                entity.Property(e => e.Certificati).HasColumnName("CERTIFICATI");

                entity.Property(e => e.Column18).HasColumnName("column18");

                entity.Property(e => e.Column19).HasColumnName("column19");

                entity.Property(e => e.Comando).HasColumnName("COMANDO");

                entity.Property(e => e.DataEffettuazione).HasColumnName("DATA_EFFETTUAZIONE");

                entity.Property(e => e.DocumentiCorrelati).HasColumnName("DOCUMENTI_CORRELATI");

                entity.Property(e => e.GiorniMancantiAllaScadenza)
                    .HasColumnName("GIORNI_MANCANTI_ALLA_SCADENZA")
                    .HasColumnType("INT");

                entity.Property(e => e.MarcaModelloDimensioni).HasColumnName("MARCA_MODELLO_DIMENSIONI");

                entity.Property(e => e.Note).HasColumnName("NOTE");

                entity.Property(e => e.ProssimaScadenza).HasColumnName("PROSSIMA_SCADENZA");

                entity.Property(e => e.TipoDiAccertamento).HasColumnName("TIPO_DI_ACCERTAMENTO");

                entity.Property(e => e.TipologiaApparecchiature).HasColumnName("TIPOLOGIA_APPARECCHIATURE");

                entity.Property(e => e.ValiditaAnni)
                    .HasColumnName("VALIDITA_anni")
                    .HasColumnType("INT");

                entity.Property(e => e.Visto).HasColumnType("INT");
            });

            modelBuilder.Entity<Ggs1018>(entity =>
            {
                entity.ToTable("ggs1018");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApparecchiaturaSistemazione).HasColumnName("APPARECCHIATURA_SISTEMAZIONE");

                entity.Property(e => e.Base).HasColumnName("BASE");

                entity.Property(e => e.Certificati).HasColumnName("CERTIFICATI");

                entity.Property(e => e.Column18).HasColumnName("column18");

                entity.Property(e => e.Column19).HasColumnName("column19");

                entity.Property(e => e.Comando).HasColumnName("COMANDO");

                entity.Property(e => e.DataEffettuazione).HasColumnName("DATA_EFFETTUAZIONE");

                entity.Property(e => e.DocumentiCorrelati).HasColumnName("DOCUMENTI_CORRELATI");

                entity.Property(e => e.GiorniMancantiAllaScadenza)
                    .HasColumnName("GIORNI_MANCANTI_ALLA_SCADENZA")
                    .HasColumnType("INT");

                entity.Property(e => e.MarcaModelloDimensioni).HasColumnName("MARCA_MODELLO_DIMENSIONI");

                entity.Property(e => e.Note).HasColumnName("NOTE");

                entity.Property(e => e.ProssimaScadenza).HasColumnName("PROSSIMA_SCADENZA");

                entity.Property(e => e.TipoDiAccertamento).HasColumnName("TIPO_DI_ACCERTAMENTO");

                entity.Property(e => e.TipologiaApparecchiature).HasColumnName("TIPOLOGIA_APPARECCHIATURE");

                entity.Property(e => e.ValiditaAnni)
                    .HasColumnName("VALIDITA_anni")
                    .HasColumnType("INT");

                entity.Property(e => e.Visto).HasColumnType("INT");
            });

            modelBuilder.Entity<Gkm28>(entity =>
            {
                entity.ToTable("gkm28");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApparecchiaturaSistemazione).HasColumnName("APPARECCHIATURA_SISTEMAZIONE");

                entity.Property(e => e.Base).HasColumnName("BASE");

                entity.Property(e => e.Certificati).HasColumnName("CERTIFICATI");

                entity.Property(e => e.Column18).HasColumnName("column18");

                entity.Property(e => e.Column19).HasColumnName("column19");

                entity.Property(e => e.Comando).HasColumnName("COMANDO");

                entity.Property(e => e.DataEffettuazione).HasColumnName("DATA_EFFETTUAZIONE");

                entity.Property(e => e.DocumentiCorrelati).HasColumnName("DOCUMENTI_CORRELATI");

                entity.Property(e => e.GiorniMancantiAllaScadenza)
                    .HasColumnName("GIORNI_MANCANTI_ALLA_SCADENZA")
                    .HasColumnType("INT");

                entity.Property(e => e.MarcaModelloDimensioni).HasColumnName("MARCA_MODELLO_DIMENSIONI");

                entity.Property(e => e.Note).HasColumnName("NOTE");

                entity.Property(e => e.ProssimaScadenza).HasColumnName("PROSSIMA_SCADENZA");

                entity.Property(e => e.TipoDiAccertamento).HasColumnName("TIPO_DI_ACCERTAMENTO");

                entity.Property(e => e.TipologiaApparecchiature).HasColumnName("TIPOLOGIA_APPARECCHIATURE");

                entity.Property(e => e.ValiditaAnni)
                    .HasColumnName("VALIDITA_anni")
                    .HasColumnType("INT");

                entity.Property(e => e.Visto).HasColumnType("INT");
            });

            modelBuilder.Entity<Go53>(entity =>
            {
                entity.ToTable("go53");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApparecchiaturaSistemazione).HasColumnName("APPARECCHIATURA_SISTEMAZIONE");

                entity.Property(e => e.Base).HasColumnName("BASE");

                entity.Property(e => e.Certificati).HasColumnName("CERTIFICATI");

                entity.Property(e => e.Column18).HasColumnName("column18");

                entity.Property(e => e.Column19).HasColumnName("column19");

                entity.Property(e => e.Comando).HasColumnName("COMANDO");

                entity.Property(e => e.DataEffettuazione).HasColumnName("DATA_EFFETTUAZIONE");

                entity.Property(e => e.DocumentiCorrelati).HasColumnName("DOCUMENTI_CORRELATI");

                entity.Property(e => e.GiorniMancantiAllaScadenza)
                    .HasColumnName("GIORNI_MANCANTI_ALLA_SCADENZA")
                    .HasColumnType("INT");

                entity.Property(e => e.MarcaModelloDimensioni).HasColumnName("MARCA_MODELLO_DIMENSIONI");

                entity.Property(e => e.Note).HasColumnName("NOTE");

                entity.Property(e => e.ProssimaScadenza).HasColumnName("PROSSIMA_SCADENZA");

                entity.Property(e => e.TipoDiAccertamento).HasColumnName("TIPO_DI_ACCERTAMENTO");

                entity.Property(e => e.TipologiaApparecchiature).HasColumnName("TIPOLOGIA_APPARECCHIATURE");

                entity.Property(e => e.ValiditaAnni)
                    .HasColumnName("VALIDITA_anni")
                    .HasColumnType("INT");

                entity.Property(e => e.Visto).HasColumnType("INT");
            });

            modelBuilder.Entity<Grg563>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("grg563");

                entity.Property(e => e.ApparecchiaturaSistemazione).HasColumnName("APPARECCHIATURA_SISTEMAZIONE");

                entity.Property(e => e.Base).HasColumnName("BASE");

                entity.Property(e => e.Certificati).HasColumnName("CERTIFICATI");

                entity.Property(e => e.Column18).HasColumnName("column18");

                entity.Property(e => e.Column19).HasColumnName("column19");

                entity.Property(e => e.Comando).HasColumnName("COMANDO");

                entity.Property(e => e.DataEffettuazione).HasColumnName("DATA_EFFETTUAZIONE");

                entity.Property(e => e.DocumentiCorrelati).HasColumnName("DOCUMENTI_CORRELATI");

                entity.Property(e => e.GiorniMancantiAllaScadenza)
                    .HasColumnName("GIORNI_MANCANTI_ALLA_SCADENZA")
                    .HasColumnType("INT");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("INT");

                entity.Property(e => e.MarcaModelloDimensioni).HasColumnName("MARCA_MODELLO_DIMENSIONI");

                entity.Property(e => e.Note).HasColumnName("NOTE");

                entity.Property(e => e.ProssimaScadenza).HasColumnName("PROSSIMA_SCADENZA");

                entity.Property(e => e.TipoDiAccertamento).HasColumnName("TIPO_DI_ACCERTAMENTO");

                entity.Property(e => e.TipologiaApparecchiature).HasColumnName("TIPOLOGIA_APPARECCHIATURE");

                entity.Property(e => e.ValiditaAnni)
                    .HasColumnName("VALIDITA_anni")
                    .HasColumnType("INT");

                entity.Property(e => e.Visto).HasColumnType("INT");
            });

            modelBuilder.Entity<Grg564>(entity =>
            {
                entity.ToTable("grg564");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApparecchiaturaSistemazione).HasColumnName("APPARECCHIATURA_SISTEMAZIONE");

                entity.Property(e => e.Base).HasColumnName("BASE");

                entity.Property(e => e.Certificati).HasColumnName("CERTIFICATI");

                entity.Property(e => e.Column18).HasColumnName("column18");

                entity.Property(e => e.Column19).HasColumnName("column19");

                entity.Property(e => e.Comando).HasColumnName("COMANDO");

                entity.Property(e => e.DataEffettuazione).HasColumnName("DATA_EFFETTUAZIONE");

                entity.Property(e => e.DocumentiCorrelati).HasColumnName("DOCUMENTI_CORRELATI");

                entity.Property(e => e.GiorniMancantiAllaScadenza)
                    .HasColumnName("GIORNI_MANCANTI_ALLA_SCADENZA")
                    .HasColumnType("INT");

                entity.Property(e => e.MarcaModelloDimensioni).HasColumnName("MARCA_MODELLO_DIMENSIONI");

                entity.Property(e => e.Note).HasColumnName("NOTE");

                entity.Property(e => e.ProssimaScadenza).HasColumnName("PROSSIMA_SCADENZA");

                entity.Property(e => e.TipoDiAccertamento).HasColumnName("TIPO_DI_ACCERTAMENTO");

                entity.Property(e => e.TipologiaApparecchiature).HasColumnName("TIPOLOGIA_APPARECCHIATURE");

                entity.Property(e => e.ValiditaAnni)
                    .HasColumnName("VALIDITA_anni")
                    .HasColumnType("INT");

                entity.Property(e => e.Visto).HasColumnType("INT");
            });

            modelBuilder.Entity<Jdg10>(entity =>
            {
                entity.ToTable("jdg10");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApparecchiaturaSistemazione).HasColumnName("APPARECCHIATURA_SISTEMAZIONE");

                entity.Property(e => e.Base).HasColumnName("BASE");

                entity.Property(e => e.Certificati).HasColumnName("CERTIFICATI");

                entity.Property(e => e.Column18).HasColumnName("column18");

                entity.Property(e => e.Column19).HasColumnName("column19");

                entity.Property(e => e.Comando).HasColumnName("COMANDO");

                entity.Property(e => e.DataEffettuazione).HasColumnName("DATA_EFFETTUAZIONE");

                entity.Property(e => e.DocumentiCorrelati).HasColumnName("DOCUMENTI_CORRELATI");

                entity.Property(e => e.GiorniMancantiAllaScadenza)
                    .HasColumnName("GIORNI_MANCANTI_ALLA_SCADENZA")
                    .HasColumnType("INT");

                entity.Property(e => e.MarcaModelloDimensioni).HasColumnName("MARCA_MODELLO_DIMENSIONI");

                entity.Property(e => e.Note).HasColumnName("NOTE");

                entity.Property(e => e.ProssimaScadenza).HasColumnName("PROSSIMA_SCADENZA");

                entity.Property(e => e.TipoDiAccertamento).HasColumnName("TIPO_DI_ACCERTAMENTO");

                entity.Property(e => e.TipologiaApparecchiature).HasColumnName("TIPOLOGIA_APPARECCHIATURE");

                entity.Property(e => e.ValiditaAnni)
                    .HasColumnName("VALIDITA_anni")
                    .HasColumnType("INT");

                entity.Property(e => e.Visto).HasColumnType("INT");
            });

            modelBuilder.Entity<Levanzo>(entity =>
            {
                entity.ToTable("LEVANZO");

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

                entity.Property(e => e.GiorniMancantiAllaScadenza)
                    .HasColumnName("GIORNI_MANCANTI_ALLA_SCADENZA")
                    .HasColumnType("INT");

                entity.Property(e => e.MarcaModelloDimensioni).HasColumnName("MARCA_MODELLO_DIMENSIONI");

                entity.Property(e => e.Note).HasColumnName("NOTE");

                entity.Property(e => e.ProssimaScadenza).HasColumnName("PROSSIMA_SCADENZA");

                entity.Property(e => e.TipoDiAccertamento).HasColumnName("TIPO_DI_ACCERTAMENTO");

                entity.Property(e => e.TipologiaApparecchiature).HasColumnName("TIPOLOGIA_APPARECCHIATURE");

                entity.Property(e => e.ValiditaAnni)
                    .HasColumnName("VALIDITA_anni")
                    .HasColumnType("INT");

                entity.Property(e => e.Visto).HasColumnType("INT");
            });

            modelBuilder.Entity<Libra>(entity =>
            {
                entity.ToTable("LIBRA");

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

                entity.Property(e => e.GiorniMancantiAllaScadenza)
                    .HasColumnName("GIORNI_MANCANTI_ALLA_SCADENZA")
                    .HasColumnType("INT");

                entity.Property(e => e.MarcaModelloDimensioni).HasColumnName("MARCA_MODELLO_DIMENSIONI");

                entity.Property(e => e.Note).HasColumnName("NOTE");

                entity.Property(e => e.ProssimaScadenza).HasColumnName("PROSSIMA_SCADENZA");

                entity.Property(e => e.TipoDiAccertamento).HasColumnName("TIPO_DI_ACCERTAMENTO");

                entity.Property(e => e.TipologiaApparecchiature).HasColumnName("TIPOLOGIA_APPARECCHIATURE");

                entity.Property(e => e.ValiditaAnni)
                    .HasColumnName("VALIDITA_anni")
                    .HasColumnType("INT");

                entity.Property(e => e.Visto).HasColumnType("INT");
            });

            modelBuilder.Entity<Linosa>(entity =>
            {
                entity.ToTable("LINOSA");

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

                entity.Property(e => e.GiorniMancantiAllaScadenza)
                    .HasColumnName("GIORNI_MANCANTI_ALLA_SCADENZA")
                    .HasColumnType("INT");

                entity.Property(e => e.MarcaModelloDimensioni).HasColumnName("MARCA_MODELLO_DIMENSIONI");

                entity.Property(e => e.Note).HasColumnName("NOTE");

                entity.Property(e => e.ProssimaScadenza).HasColumnName("PROSSIMA_SCADENZA");

                entity.Property(e => e.TipoDiAccertamento).HasColumnName("TIPO_DI_ACCERTAMENTO");

                entity.Property(e => e.TipologiaApparecchiature).HasColumnName("TIPOLOGIA_APPARECCHIATURE");

                entity.Property(e => e.ValiditaAnni)
                    .HasColumnName("VALIDITA_anni")
                    .HasColumnType("INT");

                entity.Property(e => e.Visto).HasColumnType("INT");
            });

            modelBuilder.Entity<Lipari>(entity =>
            {
                entity.ToTable("LIPARI");

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

                entity.Property(e => e.GiorniMancantiAllaScadenza)
                    .HasColumnName("GIORNI_MANCANTI_ALLA_SCADENZA")
                    .HasColumnType("INT");

                entity.Property(e => e.MarcaModelloDimensioni).HasColumnName("MARCA_MODELLO_DIMENSIONI");

                entity.Property(e => e.Note).HasColumnName("NOTE");

                entity.Property(e => e.ProssimaScadenza).HasColumnName("PROSSIMA_SCADENZA");

                entity.Property(e => e.TipoDiAccertamento).HasColumnName("TIPO_DI_ACCERTAMENTO");

                entity.Property(e => e.TipologiaApparecchiature).HasColumnName("TIPOLOGIA_APPARECCHIATURE");

                entity.Property(e => e.ValiditaAnni)
                    .HasColumnName("VALIDITA_anni")
                    .HasColumnType("INT");

                entity.Property(e => e.Visto).HasColumnType("INT");
            });

            modelBuilder.Entity<Orione>(entity =>
            {
                entity.ToTable("ORIONE");

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

                entity.Property(e => e.GiorniMancantiAllaScadenza)
                    .HasColumnName("GIORNI_MANCANTI_ALLA_SCADENZA")
                    .HasColumnType("INT");

                entity.Property(e => e.MarcaModelloDimensioni).HasColumnName("MARCA_MODELLO_DIMENSIONI");

                entity.Property(e => e.Note).HasColumnName("NOTE");

                entity.Property(e => e.ProssimaScadenza).HasColumnName("PROSSIMA_SCADENZA");

                entity.Property(e => e.TipoDiAccertamento).HasColumnName("TIPO_DI_ACCERTAMENTO");

                entity.Property(e => e.TipologiaApparecchiature).HasColumnName("TIPOLOGIA_APPARECCHIATURE");

                entity.Property(e => e.ValiditaAnni)
                    .HasColumnName("VALIDITA_anni")
                    .HasColumnType("INT");

                entity.Property(e => e.Visto).HasColumnType("INT");
            });

            modelBuilder.Entity<Panarea>(entity =>
            {
                entity.ToTable("PANAREA");

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

                entity.Property(e => e.GiorniMancantiAllaScadenza)
                    .HasColumnName("GIORNI_MANCANTI_ALLA_SCADENZA")
                    .HasColumnType("INT");

                entity.Property(e => e.MarcaModelloDimensioni).HasColumnName("MARCA_MODELLO_DIMENSIONI");

                entity.Property(e => e.Note).HasColumnName("NOTE");

                entity.Property(e => e.ProssimaScadenza).HasColumnName("PROSSIMA_SCADENZA");

                entity.Property(e => e.TipoDiAccertamento).HasColumnName("TIPO_DI_ACCERTAMENTO");

                entity.Property(e => e.TipologiaApparecchiature).HasColumnName("TIPOLOGIA_APPARECCHIATURE");

                entity.Property(e => e.ValiditaAnni)
                    .HasColumnName("VALIDITA_anni")
                    .HasColumnType("INT");

                entity.Property(e => e.Visto).HasColumnType("INT");
            });

            modelBuilder.Entity<Polifemo>(entity =>
            {
                entity.ToTable("POLIFEMO");

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

                entity.Property(e => e.GiorniMancantiAllaScadenza)
                    .HasColumnName("GIORNI_MANCANTI_ALLA_SCADENZA")
                    .HasColumnType("INT");

                entity.Property(e => e.MarcaModelloDimensioni).HasColumnName("MARCA_MODELLO_DIMENSIONI");

                entity.Property(e => e.Note).HasColumnName("NOTE");

                entity.Property(e => e.ProssimaScadenza).HasColumnName("PROSSIMA_SCADENZA");

                entity.Property(e => e.TipoDiAccertamento).HasColumnName("TIPO_DI_ACCERTAMENTO");

                entity.Property(e => e.TipologiaApparecchiature).HasColumnName("TIPOLOGIA_APPARECCHIATURE");

                entity.Property(e => e.ValiditaAnni)
                    .HasColumnName("VALIDITA_anni")
                    .HasColumnType("INT");

                entity.Property(e => e.Visto).HasColumnType("INT");
            });

            modelBuilder.Entity<Portoconte>(entity =>
            {
                entity.ToTable("PORTOCONTE");

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

                entity.Property(e => e.GiorniMancantiAllaScadenza)
                    .HasColumnName("GIORNI_MANCANTI_ALLA_SCADENZA")
                    .HasColumnType("INT");

                entity.Property(e => e.MarcaModelloDimensioni).HasColumnName("MARCA_MODELLO_DIMENSIONI");

                entity.Property(e => e.Note).HasColumnName("NOTE");

                entity.Property(e => e.ProssimaScadenza).HasColumnName("PROSSIMA_SCADENZA");

                entity.Property(e => e.TipoDiAccertamento).HasColumnName("TIPO_DI_ACCERTAMENTO");

                entity.Property(e => e.TipologiaApparecchiature).HasColumnName("TIPOLOGIA_APPARECCHIATURE");

                entity.Property(e => e.ValiditaAnni)
                    .HasColumnName("VALIDITA_anni")
                    .HasColumnType("INT");

                entity.Property(e => e.Visto).HasColumnType("INT");
            });

            modelBuilder.Entity<Portovenere>(entity =>
            {
                entity.ToTable("PORTOVENERE");

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

                entity.Property(e => e.GiorniMancantiAllaScadenza)
                    .HasColumnName("GIORNI_MANCANTI_ALLA_SCADENZA")
                    .HasColumnType("INT");

                entity.Property(e => e.MarcaModelloDimensioni).HasColumnName("MARCA_MODELLO_DIMENSIONI");

                entity.Property(e => e.Note).HasColumnName("NOTE");

                entity.Property(e => e.ProssimaScadenza).HasColumnName("PROSSIMA_SCADENZA");

                entity.Property(e => e.TipoDiAccertamento).HasColumnName("TIPO_DI_ACCERTAMENTO");

                entity.Property(e => e.TipologiaApparecchiature).HasColumnName("TIPOLOGIA_APPARECCHIATURE");

                entity.Property(e => e.ValiditaAnni)
                    .HasColumnName("VALIDITA_anni")
                    .HasColumnType("INT");

                entity.Property(e => e.Visto).HasColumnType("INT");
            });

            modelBuilder.Entity<Rp102>(entity =>
            {
                entity.ToTable("RP102");

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

                entity.Property(e => e.GiorniMancantiAllaScadenza)
                    .HasColumnName("GIORNI_MANCANTI_ALLA_SCADENZA")
                    .HasColumnType("INT");

                entity.Property(e => e.MarcaModelloDimensioni).HasColumnName("MARCA_MODELLO_DIMENSIONI");

                entity.Property(e => e.Note).HasColumnName("NOTE");

                entity.Property(e => e.ProssimaScadenza).HasColumnName("PROSSIMA_SCADENZA");

                entity.Property(e => e.TipoDiAccertamento).HasColumnName("TIPO_DI_ACCERTAMENTO");

                entity.Property(e => e.TipologiaApparecchiature).HasColumnName("TIPOLOGIA_APPARECCHIATURE");

                entity.Property(e => e.ValiditaAnni)
                    .HasColumnName("VALIDITA_anni")
                    .HasColumnType("INT");

                entity.Property(e => e.Visto).HasColumnType("INT");
            });

            modelBuilder.Entity<Rp112>(entity =>
            {
                entity.ToTable("RP112");

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

                entity.Property(e => e.GiorniMancantiAllaScadenza)
                    .HasColumnName("GIORNI_MANCANTI_ALLA_SCADENZA")
                    .HasColumnType("INT");

                entity.Property(e => e.MarcaModelloDimensioni).HasColumnName("MARCA_MODELLO_DIMENSIONI");

                entity.Property(e => e.Note).HasColumnName("NOTE");

                entity.Property(e => e.ProssimaScadenza).HasColumnName("PROSSIMA_SCADENZA");

                entity.Property(e => e.TipoDiAccertamento).HasColumnName("TIPO_DI_ACCERTAMENTO");

                entity.Property(e => e.TipologiaApparecchiature).HasColumnName("TIPOLOGIA_APPARECCHIATURE");

                entity.Property(e => e.ValiditaAnni)
                    .HasColumnName("VALIDITA_anni")
                    .HasColumnType("INT");

                entity.Property(e => e.Visto).HasColumnType("INT");
            });

            modelBuilder.Entity<Rp123>(entity =>
            {
                entity.ToTable("RP123");

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

                entity.Property(e => e.GiorniMancantiAllaScadenza)
                    .HasColumnName("GIORNI_MANCANTI_ALLA_SCADENZA")
                    .HasColumnType("INT");

                entity.Property(e => e.MarcaModelloDimensioni).HasColumnName("MARCA_MODELLO_DIMENSIONI");

                entity.Property(e => e.Note).HasColumnName("NOTE");

                entity.Property(e => e.ProssimaScadenza).HasColumnName("PROSSIMA_SCADENZA");

                entity.Property(e => e.TipoDiAccertamento).HasColumnName("TIPO_DI_ACCERTAMENTO");

                entity.Property(e => e.TipologiaApparecchiature).HasColumnName("TIPOLOGIA_APPARECCHIATURE");

                entity.Property(e => e.ValiditaAnni)
                    .HasColumnName("VALIDITA_anni")
                    .HasColumnType("INT");

                entity.Property(e => e.Visto).HasColumnType("INT");
            });

            modelBuilder.Entity<Rp125>(entity =>
            {
                entity.ToTable("RP125");

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

                entity.Property(e => e.GiorniMancantiAllaScadenza)
                    .HasColumnName("GIORNI_MANCANTI_ALLA_SCADENZA")
                    .HasColumnType("INT");

                entity.Property(e => e.MarcaModelloDimensioni).HasColumnName("MARCA_MODELLO_DIMENSIONI");

                entity.Property(e => e.Note).HasColumnName("NOTE");

                entity.Property(e => e.ProssimaScadenza).HasColumnName("PROSSIMA_SCADENZA");

                entity.Property(e => e.TipoDiAccertamento).HasColumnName("TIPO_DI_ACCERTAMENTO");

                entity.Property(e => e.TipologiaApparecchiature).HasColumnName("TIPOLOGIA_APPARECCHIATURE");

                entity.Property(e => e.ValiditaAnni)
                    .HasColumnName("VALIDITA_anni")
                    .HasColumnType("INT");

                entity.Property(e => e.Visto).HasColumnType("INT");
            });

            modelBuilder.Entity<Rp126>(entity =>
            {
                entity.ToTable("RP126");

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

                entity.Property(e => e.GiorniMancantiAllaScadenza)
                    .HasColumnName("GIORNI_MANCANTI_ALLA_SCADENZA")
                    .HasColumnType("INT");

                entity.Property(e => e.MarcaModelloDimensioni).HasColumnName("MARCA_MODELLO_DIMENSIONI");

                entity.Property(e => e.Note).HasColumnName("NOTE");

                entity.Property(e => e.ProssimaScadenza).HasColumnName("PROSSIMA_SCADENZA");

                entity.Property(e => e.TipoDiAccertamento).HasColumnName("TIPO_DI_ACCERTAMENTO");

                entity.Property(e => e.TipologiaApparecchiature).HasColumnName("TIPOLOGIA_APPARECCHIATURE");

                entity.Property(e => e.ValiditaAnni)
                    .HasColumnName("VALIDITA_anni")
                    .HasColumnType("INT");

                entity.Property(e => e.Visto).HasColumnType("INT");
            });

            modelBuilder.Entity<Rp130>(entity =>
            {
                entity.ToTable("RP130");

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

                entity.Property(e => e.GiorniMancantiAllaScadenza)
                    .HasColumnName("GIORNI_MANCANTI_ALLA_SCADENZA")
                    .HasColumnType("INT");

                entity.Property(e => e.MarcaModelloDimensioni).HasColumnName("MARCA_MODELLO_DIMENSIONI");

                entity.Property(e => e.Note).HasColumnName("NOTE");

                entity.Property(e => e.ProssimaScadenza).HasColumnName("PROSSIMA_SCADENZA");

                entity.Property(e => e.TipoDiAccertamento).HasColumnName("TIPO_DI_ACCERTAMENTO");

                entity.Property(e => e.TipologiaApparecchiature).HasColumnName("TIPOLOGIA_APPARECCHIATURE");

                entity.Property(e => e.ValiditaAnni)
                    .HasColumnName("VALIDITA_anni")
                    .HasColumnType("INT");

                entity.Property(e => e.Visto).HasColumnType("INT");
            });

            modelBuilder.Entity<Rp131>(entity =>
            {
                entity.ToTable("RP131");

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

                entity.Property(e => e.GiorniMancantiAllaScadenza)
                    .HasColumnName("GIORNI_MANCANTI_ALLA_SCADENZA")
                    .HasColumnType("INT");

                entity.Property(e => e.MarcaModelloDimensioni).HasColumnName("MARCA_MODELLO_DIMENSIONI");

                entity.Property(e => e.Note).HasColumnName("NOTE");

                entity.Property(e => e.ProssimaScadenza).HasColumnName("PROSSIMA_SCADENZA");

                entity.Property(e => e.TipoDiAccertamento).HasColumnName("TIPO_DI_ACCERTAMENTO");

                entity.Property(e => e.TipologiaApparecchiature).HasColumnName("TIPOLOGIA_APPARECCHIATURE");

                entity.Property(e => e.ValiditaAnni)
                    .HasColumnName("VALIDITA_anni")
                    .HasColumnType("INT");

                entity.Property(e => e.Visto).HasColumnType("INT");
            });

            modelBuilder.Entity<Salina>(entity =>
            {
                entity.ToTable("SALINA");

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

                entity.Property(e => e.GiorniMancantiAllaScadenza)
                    .HasColumnName("GIORNI_MANCANTI_ALLA_SCADENZA")
                    .HasColumnType("INT");

                entity.Property(e => e.MarcaModelloDimensioni).HasColumnName("MARCA_MODELLO_DIMENSIONI");

                entity.Property(e => e.Note).HasColumnName("NOTE");

                entity.Property(e => e.ProssimaScadenza).HasColumnName("PROSSIMA_SCADENZA");

                entity.Property(e => e.TipoDiAccertamento).HasColumnName("TIPO_DI_ACCERTAMENTO");

                entity.Property(e => e.TipologiaApparecchiature).HasColumnName("TIPOLOGIA_APPARECCHIATURE");

                entity.Property(e => e.ValiditaAnni)
                    .HasColumnName("VALIDITA_anni")
                    .HasColumnType("INT");

                entity.Property(e => e.Visto).HasColumnType("INT");
            });

            modelBuilder.Entity<Scire>(entity =>
            {
                entity.ToTable("SCIRE");

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

                entity.Property(e => e.GiorniMancantiAllaScadenza)
                    .HasColumnName("GIORNI_MANCANTI_ALLA_SCADENZA")
                    .HasColumnType("INT");

                entity.Property(e => e.MarcaModelloDimensioni).HasColumnName("MARCA_MODELLO_DIMENSIONI");

                entity.Property(e => e.Note).HasColumnName("NOTE");

                entity.Property(e => e.ProssimaScadenza).HasColumnName("PROSSIMA_SCADENZA");

                entity.Property(e => e.TipoDiAccertamento).HasColumnName("TIPO_DI_ACCERTAMENTO");

                entity.Property(e => e.TipologiaApparecchiature).HasColumnName("TIPOLOGIA_APPARECCHIATURE");

                entity.Property(e => e.ValiditaAnni)
                    .HasColumnName("VALIDITA_anni")
                    .HasColumnType("INT");

                entity.Property(e => e.Visto).HasColumnType("INT");
            });

            modelBuilder.Entity<Sirio>(entity =>
            {
                entity.ToTable("SIRIO");

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

                entity.Property(e => e.GiorniMancantiAllaScadenza)
                    .HasColumnName("GIORNI_MANCANTI_ALLA_SCADENZA")
                    .HasColumnType("INT");

                entity.Property(e => e.MarcaModelloDimensioni).HasColumnName("MARCA_MODELLO_DIMENSIONI");

                entity.Property(e => e.Note).HasColumnName("NOTE");

                entity.Property(e => e.ProssimaScadenza).HasColumnName("PROSSIMA_SCADENZA");

                entity.Property(e => e.TipoDiAccertamento).HasColumnName("TIPO_DI_ACCERTAMENTO");

                entity.Property(e => e.TipologiaApparecchiature).HasColumnName("TIPOLOGIA_APPARECCHIATURE");

                entity.Property(e => e.ValiditaAnni)
                    .HasColumnName("VALIDITA_anni")
                    .HasColumnType("INT");

                entity.Property(e => e.Visto).HasColumnType("INT");
            });

            modelBuilder.Entity<Spica>(entity =>
            {
                entity.ToTable("SPICA");

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

                entity.Property(e => e.GiorniMancantiAllaScadenza)
                    .HasColumnName("GIORNI_MANCANTI_ALLA_SCADENZA")
                    .HasColumnType("INT");

                entity.Property(e => e.MarcaModelloDimensioni).HasColumnName("MARCA_MODELLO_DIMENSIONI");

                entity.Property(e => e.Note).HasColumnName("NOTE");

                entity.Property(e => e.ProssimaScadenza).HasColumnName("PROSSIMA_SCADENZA");

                entity.Property(e => e.TipoDiAccertamento).HasColumnName("TIPO_DI_ACCERTAMENTO");

                entity.Property(e => e.TipologiaApparecchiature).HasColumnName("TIPOLOGIA_APPARECCHIATURE");

                entity.Property(e => e.ValiditaAnni)
                    .HasColumnName("VALIDITA_anni")
                    .HasColumnType("INT");

                entity.Property(e => e.Visto).HasColumnType("INT");
            });

            modelBuilder.Entity<Ticino>(entity =>
            {
                entity.ToTable("TICINO");

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

                entity.Property(e => e.GiorniMancantiAllaScadenza)
                    .HasColumnName("GIORNI_MANCANTI_ALLA_SCADENZA")
                    .HasColumnType("INT");

                entity.Property(e => e.MarcaModelloDimensioni).HasColumnName("MARCA_MODELLO_DIMENSIONI");

                entity.Property(e => e.Note).HasColumnName("NOTE");

                entity.Property(e => e.ProssimaScadenza).HasColumnName("PROSSIMA_SCADENZA");

                entity.Property(e => e.TipoDiAccertamento).HasColumnName("TIPO_DI_ACCERTAMENTO");

                entity.Property(e => e.TipologiaApparecchiature).HasColumnName("TIPOLOGIA_APPARECCHIATURE");

                entity.Property(e => e.ValiditaAnni)
                    .HasColumnName("VALIDITA_anni")
                    .HasColumnType("INT");

                entity.Property(e => e.Visto).HasColumnType("INT");
            });

            modelBuilder.Entity<Tirso>(entity =>
            {
                entity.ToTable("TIRSO");

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

                entity.Property(e => e.GiorniMancantiAllaScadenza)
                    .HasColumnName("GIORNI_MANCANTI_ALLA_SCADENZA")
                    .HasColumnType("INT");

                entity.Property(e => e.MarcaModelloDimensioni).HasColumnName("MARCA_MODELLO_DIMENSIONI");

                entity.Property(e => e.Note).HasColumnName("NOTE");

                entity.Property(e => e.ProssimaScadenza).HasColumnName("PROSSIMA_SCADENZA");

                entity.Property(e => e.TipoDiAccertamento).HasColumnName("TIPO_DI_ACCERTAMENTO");

                entity.Property(e => e.TipologiaApparecchiature).HasColumnName("TIPOLOGIA_APPARECCHIATURE");

                entity.Property(e => e.ValiditaAnni)
                    .HasColumnName("VALIDITA_anni")
                    .HasColumnType("INT");

                entity.Property(e => e.Visto).HasColumnType("INT");
            });

            modelBuilder.Entity<Vega>(entity =>
            {
                entity.ToTable("VEGA");

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

                entity.Property(e => e.GiorniMancantiAllaScadenza)
                    .HasColumnName("GIORNI_MANCANTI_ALLA_SCADENZA")
                    .HasColumnType("INT");

                entity.Property(e => e.MarcaModelloDimensioni).HasColumnName("MARCA_MODELLO_DIMENSIONI");

                entity.Property(e => e.Note).HasColumnName("NOTE");

                entity.Property(e => e.ProssimaScadenza).HasColumnName("PROSSIMA_SCADENZA");

                entity.Property(e => e.TipoDiAccertamento).HasColumnName("TIPO_DI_ACCERTAMENTO");

                entity.Property(e => e.TipologiaApparecchiature).HasColumnName("TIPOLOGIA_APPARECCHIATURE");

                entity.Property(e => e.ValiditaAnni)
                    .HasColumnName("VALIDITA_anni")
                    .HasColumnType("INT");

                entity.Property(e => e.Visto).HasColumnType("INT");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
