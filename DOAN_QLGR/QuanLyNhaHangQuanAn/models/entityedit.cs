namespace QuanLyNhaHangQuanAn.models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class entityedit : DbContext
    {
        public entityedit()
            : base("name=entityedit")
        {
        }

        public virtual DbSet<ACCOUNT> ACCOUNTs { get; set; }
        public virtual DbSet<ACCOUNTTYPE> ACCOUNTTYPEs { get; set; }
        public virtual DbSet<BILL> BILLs { get; set; }
        public virtual DbSet<BILLINFO> BILLINFOes { get; set; }
        public virtual DbSet<FOOD> FOODS { get; set; }
        public virtual DbSet<FOODSTYPE> FOODSTYPEs { get; set; }
        public virtual DbSet<INCOME> INCOMEs { get; set; }
        public virtual DbSet<OTABLE> OTABLEs { get; set; }
        public virtual DbSet<RESOURCE> RESOURCES { get; set; }
        public virtual DbSet<RESOURCESTYPE> RESOURCESTYPEs { get; set; }
        public virtual DbSet<SUPLIER> SUPLIERS { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ACCOUNT>()
                .Property(e => e.USERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<ACCOUNT>()
                .Property(e => e.UPASSWORD)
                .IsUnicode(false);

            modelBuilder.Entity<ACCOUNTTYPE>()
                .HasMany(e => e.ACCOUNTs)
                .WithRequired(e => e.ACCOUNTTYPE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BILL>()
                .HasMany(e => e.BILLINFOes)
                .WithRequired(e => e.BILL)
                .HasForeignKey(e => e.IDBILL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FOOD>()
                .Property(e => e.FOODSPRICE)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FOOD>()
                .HasMany(e => e.BILLINFOes)
                .WithRequired(e => e.FOOD)
                .HasForeignKey(e => e.IDFOODS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FOODSTYPE>()
                .HasMany(e => e.FOODS)
                .WithRequired(e => e.FOODSTYPE)
                .HasForeignKey(e => e.IDTYPE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OTABLE>()
                .Property(e => e.TABLENUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<OTABLE>()
                .HasMany(e => e.BILLs)
                .WithRequired(e => e.OTABLE)
                .HasForeignKey(e => e.IDTABLE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RESOURCESTYPE>()
                .Property(e => e.SUPLIERSID)
                .IsUnicode(false);

            modelBuilder.Entity<RESOURCESTYPE>()
                .HasMany(e => e.RESOURCES)
                .WithRequired(e => e.RESOURCESTYPE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SUPLIER>()
                .Property(e => e.SUPLIERSID)
                .IsUnicode(false);

            modelBuilder.Entity<SUPLIER>()
                .Property(e => e.PHONENUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<SUPLIER>()
                .HasMany(e => e.RESOURCESTYPEs)
                .WithRequired(e => e.SUPLIER)
                .WillCascadeOnDelete(false);
        }
    }
}
