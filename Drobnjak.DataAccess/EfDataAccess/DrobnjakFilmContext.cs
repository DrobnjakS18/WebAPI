using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Drobnjak.DataAccess.Domain
{
    public partial class DrobnjakFilmContext : DbContext
    {
        public DrobnjakFilmContext()
        {
        }

        public DrobnjakFilmContext(DbContextOptions<DrobnjakFilmContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Film> Film { get; set; }
        public virtual DbSet<FilmGlumac> FilmGlumac { get; set; }
        public virtual DbSet<FilmZanr> FilmZanr { get; set; }
        public virtual DbSet<Glumac> Glumac { get; set; }
        public virtual DbSet<Korisnik> Korisnik { get; set; }
        public virtual DbSet<Uloga> Uloga { get; set; }
        public virtual DbSet<Zanr> Zanr { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=DrobnjakFilm;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Film>(entity =>
            {
                entity.Property(e => e.FilmId)
                    .HasColumnName("FilmID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DatumPrikaza).HasColumnType("datetime");

                entity.Property(e => e.Naziv)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Opis).HasColumnType("text");

                entity.Property(e => e.Trajanje)
                    .HasColumnName("trajanje")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FilmGlumac>(entity =>
            {
                entity.Property(e => e.FilmGlumacId)
                    .HasColumnName("FilmGlumacID")
                    .ValueGeneratedNever();

                entity.Property(e => e.FilmId).HasColumnName("FilmID");

                entity.Property(e => e.GlumacId).HasColumnName("GlumacID");
            });

            modelBuilder.Entity<FilmZanr>(entity =>
            {
                entity.Property(e => e.FilmZanrId)
                    .HasColumnName("FilmZanrID")
                    .ValueGeneratedNever();

                entity.Property(e => e.FilmId).HasColumnName("FilmID");

                entity.Property(e => e.ZanrId).HasColumnName("ZanrID");
            });

            modelBuilder.Entity<Glumac>(entity =>
            {
                entity.Property(e => e.GlumacId)
                    .HasColumnName("GlumacID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ImePrezime)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Korisnik>(entity =>
            {
                entity.Property(e => e.KorisnikId)
                    .HasColumnName("KorisnikID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lozinka)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Prezime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UlogaId).HasColumnName("UlogaID");
            });

            modelBuilder.Entity<Uloga>(entity =>
            {
                entity.Property(e => e.UlogaId)
                    .HasColumnName("UlogaID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Naziv)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Zanr>(entity =>
            {
                entity.Property(e => e.ZanrId)
                    .HasColumnName("ZanrID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ZanrNaziv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
