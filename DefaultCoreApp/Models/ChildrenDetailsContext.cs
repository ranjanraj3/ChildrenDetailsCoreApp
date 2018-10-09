using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DefaultCoreApp.Models
{
    public partial class ChildrenDetailsContext : DbContext
    {
        public ChildrenDetailsContext()
        {
        }

        public ChildrenDetailsContext(DbContextOptions<ChildrenDetailsContext> options)
            : base(options)
        {
        }



        public virtual DbSet<ChildrenDetails> ChildrenDetails { get; set; }
        public virtual DbSet<ChildrenFileUpload> ChildrenFileUpload { get; set; }
        public virtual DbSet<ChildrenStatus> ChildrenStatus { get; set; }
        public virtual DbSet<ChildrenType> ChildrenType { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("data source=VE180718D_NSEZ\\SQLEXPRESS2014;Database=ChildrenDetails;user id=sa;password=pass@123;");
            }

            //base.OnConfiguring(optionsBuilder);
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<ChildrenDetails>(entity =>
            //{
            //    // Set key for entity
            //    entity.HasKey(p => p.Id);
            //});

            //base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ChildrenDetails>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ChildAddress)
                    .IsRequired()
                    .HasColumnName("Child Address")
                    .HasMaxLength(100);

                entity.Property(e => e.ChildBirthDate)
                    .HasColumnName("Child Birth Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChildFirstName)
                    .IsRequired()
                    .HasColumnName("Child First Name")
                    .HasMaxLength(50);

                entity.Property(e => e.ChildGender)
                    .IsRequired()
                    .HasColumnName("Child Gender")
                    .HasMaxLength(10);

                entity.Property(e => e.ChildLastName)
                    .IsRequired()
                    .HasColumnName("Child Last Name")
                    .HasMaxLength(50);

                entity.Property(e => e.ChildStatus).HasColumnName("Child Status");

                entity.Property(e => e.ChildType).HasColumnName("Child Type");

                entity.Property(e => e.Contact1Address)
                    .IsRequired()
                    .HasColumnName("Contact1 Address")
                    .HasMaxLength(100);

                entity.Property(e => e.Contact1Email)
                    .IsRequired()
                    .HasColumnName("Contact1 Email")
                    .HasMaxLength(50);

                entity.Property(e => e.Contact1Name)
                    .IsRequired()
                    .HasColumnName("Contact1 Name")
                    .HasMaxLength(50);

                entity.Property(e => e.Contact1Phone)
                    .IsRequired()
                    .HasColumnName("Contact1 Phone")
                    .HasMaxLength(50);

                entity.Property(e => e.Contact1Relationship)
                    .IsRequired()
                    .HasColumnName("Contact1 Relationship")
                    .HasMaxLength(50);

                entity.Property(e => e.Contact2Address)
                    .IsRequired()
                    .HasColumnName("Contact2 Address")
                    .HasMaxLength(100);

                entity.Property(e => e.Contact2Email)
                    .IsRequired()
                    .HasColumnName("Contact2 Email")
                    .HasMaxLength(50);

                entity.Property(e => e.Contact2Name)
                    .IsRequired()
                    .HasColumnName("Contact2 Name")
                    .HasMaxLength(50);

                entity.Property(e => e.Contact2Phone)
                    .IsRequired()
                    .HasColumnName("Contact2 Phone")
                    .HasMaxLength(50);

                entity.Property(e => e.Contact2Relationship)
                    .IsRequired()
                    .HasColumnName("Contact2 Relationship")
                    .HasMaxLength(50);

                entity.Property(e => e.Contact3Address)
                    .IsRequired()
                    .HasColumnName("Contact3 Address")
                    .HasMaxLength(100);

                entity.Property(e => e.Contact3Email)
                    .IsRequired()
                    .HasColumnName("Contact3 Email")
                    .HasMaxLength(50);

                entity.Property(e => e.Contact3Name)
                    .IsRequired()
                    .HasColumnName("Contact3 Name")
                    .HasMaxLength(50);

                entity.Property(e => e.Contact3Phone)
                    .IsRequired()
                    .HasColumnName("Contact3 Phone")
                    .HasMaxLength(50);

                entity.Property(e => e.Contact3Relationship)
                    .IsRequired()
                    .HasColumnName("Contact3 Relationship")
                    .HasMaxLength(50);

                entity.Property(e => e.Contact4Address)
                    .IsRequired()
                    .HasColumnName("Contact4 Address")
                    .HasMaxLength(100);

                entity.Property(e => e.Contact4Email)
                    .IsRequired()
                    .HasColumnName("Contact4 Email")
                    .HasMaxLength(50);

                entity.Property(e => e.Contact4Name)
                    .IsRequired()
                    .HasColumnName("Contact4 Name")
                    .HasMaxLength(50);

                entity.Property(e => e.Contact4Phone)
                    .IsRequired()
                    .HasColumnName("Contact4 Phone")
                    .HasMaxLength(50);

                entity.Property(e => e.Contact4Relationship)
                    .IsRequired()
                    .HasColumnName("Contact4 Relationship")
                    .HasMaxLength(50);

                entity.Property(e => e.Parent1Address)
                    .IsRequired()
                    .HasColumnName("Parent1 Address")
                    .HasMaxLength(100);

                entity.Property(e => e.Parent1CellPhone)
                    .IsRequired()
                    .HasColumnName("Parent1 Cell Phone")
                    .HasMaxLength(50);

                entity.Property(e => e.Parent1ChildRelation)
                    .IsRequired()
                    .HasColumnName("Parent1 Child Relation")
                    .HasMaxLength(10);

                entity.Property(e => e.Parent1City)
                    .IsRequired()
                    .HasColumnName("Parent1 City")
                    .HasMaxLength(50);

                entity.Property(e => e.Parent1Comments)
                    .IsRequired()
                    .HasColumnName("Parent1 Comments")
                    .HasMaxLength(200);

                entity.Property(e => e.Parent1Email)
                    .IsRequired()
                    .HasColumnName("Parent1 Email")
                    .HasMaxLength(50);

                entity.Property(e => e.Parent1FirstName)
                    .IsRequired()
                    .HasColumnName("Parent1 First Name")
                    .HasMaxLength(50);

                entity.Property(e => e.Parent1Gender)
                    .IsRequired()
                    .HasColumnName("Parent1 Gender")
                    .HasMaxLength(10);

                entity.Property(e => e.Parent1HomePhone)
                    .IsRequired()
                    .HasColumnName("Parent1 Home Phone")
                    .HasMaxLength(50);

                entity.Property(e => e.Parent1LastName)
                    .IsRequired()
                    .HasColumnName("Parent1 Last Name")
                    .HasMaxLength(50);

                entity.Property(e => e.Parent1PostalCode)
                    .IsRequired()
                    .HasColumnName("Parent1 Postal Code")
                    .HasMaxLength(50);

                entity.Property(e => e.Parent1PrimaryEmail).HasColumnName("Parent1 Primary Email");

                entity.Property(e => e.Parent1Private)
                    .IsRequired()
                    .HasColumnName("Parent1 Private")
                    .HasMaxLength(10);

                entity.Property(e => e.Parent1Province)
                    .HasColumnName("Parent1 Province")
                    .HasMaxLength(50);

                entity.Property(e => e.Parent1SpecialCustody)
                    .IsRequired()
                    .HasColumnName("Parent1 Special Custody")
                    .HasMaxLength(200);

                entity.Property(e => e.Parent1Unit)
                    .IsRequired()
                    .HasColumnName("Parent1 Unit")
                    .HasMaxLength(50);

                entity.Property(e => e.Parent1WorkPhone)
                    .IsRequired()
                    .HasColumnName("Parent1 Work Phone")
                    .HasMaxLength(50);

                entity.Property(e => e.Parent2Address)
                    .IsRequired()
                    .HasColumnName("Parent2 Address")
                    .HasMaxLength(100);

                entity.Property(e => e.Parent2CellPhone)
                    .IsRequired()
                    .HasColumnName("Parent2 Cell Phone")
                    .HasMaxLength(50);

                entity.Property(e => e.Parent2ChildRelation)
                    .IsRequired()
                    .HasColumnName("Parent2 Child Relation")
                    .HasMaxLength(10);

                entity.Property(e => e.Parent2City)
                    .IsRequired()
                    .HasColumnName("Parent2 City")
                    .HasMaxLength(50);

                entity.Property(e => e.Parent2Comments)
                    .IsRequired()
                    .HasColumnName("Parent2 Comments")
                    .HasMaxLength(200);

                entity.Property(e => e.Parent2Email)
                    .IsRequired()
                    .HasColumnName("Parent2 Email")
                    .HasMaxLength(50);

                entity.Property(e => e.Parent2FirstName)
                    .IsRequired()
                    .HasColumnName("Parent2 First Name")
                    .HasMaxLength(50);

                entity.Property(e => e.Parent2Gender)
                    .IsRequired()
                    .HasColumnName("Parent2 Gender")
                    .HasMaxLength(10);

                entity.Property(e => e.Parent2HomePhone)
                    .IsRequired()
                    .HasColumnName("Parent2 Home Phone")
                    .HasMaxLength(50);

                entity.Property(e => e.Parent2LastName)
                    .IsRequired()
                    .HasColumnName("Parent2 Last Name")
                    .HasMaxLength(50);

                entity.Property(e => e.Parent2PostalCode)
                    .IsRequired()
                    .HasColumnName("Parent2 Postal Code")
                    .HasMaxLength(50);

                entity.Property(e => e.Parent2PrimaryEmail).HasColumnName("Parent2 Primary Email");

                entity.Property(e => e.Parent2Private)
                    .IsRequired()
                    .HasColumnName("Parent2 Private")
                    .HasMaxLength(10);

                entity.Property(e => e.Parent2Province)
                    .HasColumnName("Parent2 Province")
                    .HasMaxLength(50);

                entity.Property(e => e.Parent2SpecialCustody)
                    .IsRequired()
                    .HasColumnName("Parent2 Special Custody")
                    .HasMaxLength(200);

                entity.Property(e => e.Parent2Unit)
                    .IsRequired()
                    .HasColumnName("Parent2 Unit")
                    .HasMaxLength(50);

                entity.Property(e => e.Parent2WorkPhone)
                    .IsRequired()
                    .HasColumnName("Parent2 Work Phone")
                    .HasMaxLength(50);

                entity.Property(e => e.SiblingAge).HasColumnName("Sibling Age");

                entity.Property(e => e.SiblingGender)
                    .IsRequired()
                    .HasColumnName("Sibling Gender")
                    .HasMaxLength(10);

                entity.Property(e => e.SiblingName)
                    .IsRequired()
                    .HasColumnName("Sibling Name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ChildrenFileUpload>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FileContent)
                    .IsRequired()
                    .HasColumnName("File Content");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasColumnName("File Name")
                    .HasMaxLength(50);

                entity.Property(e => e.UploadDate)
                    .HasColumnName("Upload Date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<ChildrenStatus>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.StatusCode).HasColumnName("Status Code");

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasColumnName("Status Name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ChildrenType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ChildrenTypeCode).HasColumnName("ChildrenType Code");

                entity.Property(e => e.ChildrenTypeName)
                    .IsRequired()
                    .HasColumnName("ChildrenType Name")
                    .HasMaxLength(50);
            });
        }
    }
}
