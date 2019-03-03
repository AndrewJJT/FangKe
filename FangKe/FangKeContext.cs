namespace FangKe
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    

    public partial class FangKeContext : DbContext
    {
        public FangKeContext()
            : base("name=FangKeContext")
        {
        }

        public virtual DbSet<Property> Properties { get; set; }
        public virtual DbSet<Rent> Rents { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserSignIn>UserSignIns { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Property>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Property)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Rent>()
                .Property(e => e.Rentamount)
                .HasPrecision(10, 4);

            modelBuilder.Entity<Rent>()
                .Property(e => e.Rentdeposit)
                .HasPrecision(10, 4);

            modelBuilder.Entity<Rent>()
                .HasMany(e => e.Rooms)
                .WithRequired(e => e.Rent)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Room>()
                .HasMany(e => e.Properties)
                .WithRequired(e => e.Room)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Room>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Room)
                .WillCascadeOnDelete(false);

           
        }
    }
}
