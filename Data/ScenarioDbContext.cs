using System;
using cpsAngular.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace cpsAngular.Data
{
    public partial class ScenarioDbContext : DbContext
    {
        public ScenarioDbContext()
        {
        }

        public ScenarioDbContext(DbContextOptions<ScenarioDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Confidence> Confidence { get; set; }
        public virtual DbSet<Cps> Cps { get; set; }
        public virtual DbSet<FinalValues> FinalValues { get; set; }
        public virtual DbSet<Footers> Footers { get; set; }
        public virtual DbSet<FormFields> FormFields { get; set; }
        public virtual DbSet<Interpret> Interpret { get; set; }
        public virtual DbSet<Snippet> Snippet { get; set; }

//         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//         {
//             if (!optionsBuilder.IsConfigured)
//             {
// #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                 optionsBuilder.UseSqlServer("Server=tcp:a5ff.database.windows.net,1433;Initial Catalog=scenario-tutorial;Persist Security Info=False;User ID=v-mewren;Password=f08Gr8b@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
//             }
//         }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<Confidence>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Po12).HasColumnName("PO12");

                entity.Property(e => e.ProductDescription).HasMaxLength(200);

                entity.Property(e => e.ProductFamily).HasMaxLength(150);

                entity.Property(e => e.ProductFamilySubType).HasMaxLength(150);

                entity.Property(e => e.Section).HasMaxLength(150);

                entity.Property(e => e.UnitOfMeasure).HasMaxLength(150);

                entity.Property(e => e.UsageCountry).HasMaxLength(150);

                entity.Property(e => e.UsageIndicator).HasMaxLength(150);

                entity.Property(e => e.UsageStartDate).HasColumnType("date");
            });

            modelBuilder.Entity<Cps>(entity =>
            {
                entity.ToTable("CPS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Po12).HasColumnName("PO12");

                entity.Property(e => e.ProductDescription).HasMaxLength(200);

                entity.Property(e => e.ProductFamily).HasMaxLength(150);

                entity.Property(e => e.ProductFamilySubType).HasMaxLength(150);

                entity.Property(e => e.Section).HasMaxLength(150);

                entity.Property(e => e.UnitOfMeasure).HasMaxLength(150);

                entity.Property(e => e.UsageCountry).HasMaxLength(150);

                entity.Property(e => e.UsageIndicator).HasMaxLength(150);

                entity.Property(e => e.UsageStartDate).HasColumnType("date");
            });

            modelBuilder.Entity<FinalValues>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DiscountOverrideReason).HasMaxLength(200);

                entity.Property(e => e.ExtendedAmountOverrideReason).HasMaxLength(200);

                entity.Property(e => e.LicenseQuantityOverrideReason).HasMaxLength(200);

                entity.Property(e => e.ListPriceOverrideReason).HasMaxLength(200);

                entity.Property(e => e.NetUnitPriceOverrideReason).HasMaxLength(200);

                entity.Property(e => e.PartNumberOverrideReason).HasMaxLength(200);

                entity.Property(e => e.Po12).HasColumnName("PO12");

                entity.Property(e => e.Po12overrideReason)
                    .HasColumnName("PO12OverrideReason")
                    .HasMaxLength(200);

                entity.Property(e => e.ProductDescription).HasMaxLength(200);

                entity.Property(e => e.ProductDescriptionOverrideReason).HasMaxLength(200);

                entity.Property(e => e.ProductFamily).HasMaxLength(150);

                entity.Property(e => e.ProductFamilyOverrideReason).HasMaxLength(200);

                entity.Property(e => e.ProductFamilySubType).HasMaxLength(150);

                entity.Property(e => e.ProductFamilySubTypeOverrideReason).HasMaxLength(200);

                entity.Property(e => e.Section).HasMaxLength(150);

                entity.Property(e => e.SectionOverrideReason).HasMaxLength(200);

                entity.Property(e => e.UnitOfMeasure).HasMaxLength(150);

                entity.Property(e => e.UnitOfMeasureOverrideReason).HasMaxLength(200);

                entity.Property(e => e.UnitQuantityOverrideReason).HasMaxLength(200);

                entity.Property(e => e.UsageCountry).HasMaxLength(150);

                entity.Property(e => e.UsageCountryOverrideReason).HasMaxLength(200);

                entity.Property(e => e.UsageIndicator).HasMaxLength(150);

                entity.Property(e => e.UsageIndicatorOverrideReason).HasMaxLength(200);

                entity.Property(e => e.UsageStartDate).HasColumnType("date");

                entity.Property(e => e.UsageStartDateOverrideReason).HasMaxLength(200);
            });

            modelBuilder.Entity<Footers>(entity =>
            {
                entity.HasKey(e => e.FooterId)
                    .HasName("PK__Footers__038A536BA2CF57D0");

                entity.Property(e => e.FooterId)
                    .HasColumnName("Footer_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Footer)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.SnippetId).HasColumnName("snippet_ID");

                entity.HasOne(d => d.Snippet)
                    .WithMany(p => p.Footers)
                    .HasForeignKey(d => d.SnippetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Footers__snippet__4BAC3F29");
            });

            modelBuilder.Entity<FormFields>(entity =>
            {
                entity.HasKey(e => e.FieldId)
                    .HasName("PK__FormFiel__C8B6FF2781BB2E43");

                entity.Property(e => e.FieldId)
                    .HasColumnName("FieldID")
                    .ValueGeneratedNever();

                entity.Property(e => e.FieldName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.SnippetId).HasColumnName("snippet_ID");

                entity.HasOne(d => d.Snippet)
                    .WithMany(p => p.FormFields)
                    .HasForeignKey(d => d.SnippetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FormField__snipp__4E88ABD4");
            });

            modelBuilder.Entity<Interpret>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Po12).HasColumnName("PO12");

                entity.Property(e => e.ProductDescription).HasMaxLength(200);

                entity.Property(e => e.ProductFamily).HasMaxLength(150);

                entity.Property(e => e.ProductFamilySubType).HasMaxLength(150);

                entity.Property(e => e.Section).HasMaxLength(150);

                entity.Property(e => e.UnitOfMeasure).HasMaxLength(150);

                entity.Property(e => e.UsageCountry).HasMaxLength(150);

                entity.Property(e => e.UsageIndicator).HasMaxLength(150);

                entity.Property(e => e.UsageStartDate).HasColumnType("date");
            });

            modelBuilder.Entity<Snippet>(entity =>
            {
                entity.ToTable("snippet");

                entity.Property(e => e.SnippetId)
                    .HasColumnName("snippet_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Snippet1)
                    .IsRequired()
                    .HasColumnName("snippet")
                    .HasMaxLength(100);
            });
        }
    }
}
