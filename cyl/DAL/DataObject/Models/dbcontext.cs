using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DAL.DataObject.Models
{
    public partial class dbcontext : DbContext
    {
        public dbcontext()
        {
        }

        public dbcontext(DbContextOptions<dbcontext> options)
            : base(options)
        {
        }

        public virtual DbSet<Client> Clients { get; set; } = null!;
        public virtual DbSet<Therapist> Therapists { get; set; } = null!;
        public virtual DbSet<Turn> Turns { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\WIN10\Desktop\final project in c\3\cyl\DAL\Clinic.mdf;Integrated Security=True;Connect Timeout=30");


            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .HasColumnName("name")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TherapistId).HasColumnName("TherapistID");

                entity.HasOne(d => d.Therapist)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.TherapistId)
                    .HasConstraintName("FK_Clients_ToTable");
            });

            modelBuilder.Entity<Therapist>(entity =>
            {
                entity.ToTable("Therapist");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .HasColumnName("name")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<Turn>(entity =>
            {
                entity.HasKey(e => e.Hour)
                    .HasName("PK__turns__7F30AF4FD7E56EBE");

                entity.ToTable("turns");

                entity.Property(e => e.Hour)
                    .ValueGeneratedNever()
                    .HasColumnName("hour");

                entity.Property(e => e.TherapistId)
                    .HasMaxLength(10)
                    .HasColumnName("TherapistID")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
