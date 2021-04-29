using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace PizzaBox.Storing.Entities
{
    public partial class HeroesAppSeanContext : DbContext
    {
        public HeroesAppSeanContext()
        {
        }

        public HeroesAppSeanContext(DbContextOptions<HeroesAppSeanContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Crust> Crusts { get; set; }
        public virtual DbSet<Cust> Custs { get; set; }
        public virtual DbSet<CustOrder> CustOrders { get; set; }
        public virtual DbSet<Pizza> Pizzas { get; set; }
        public virtual DbSet<PizzaOrder> PizzaOrders { get; set; }
        public virtual DbSet<Size> Sizes { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<Topping> Toppings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=tcp:heroesapp-sean.database.windows.net,1433;Initial Catalog=HeroesApp-Sean;User ID=Dev;Password=Password123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Crust>(entity =>
            {
                entity.ToTable("Crust");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("smallmoney");
            });

            modelBuilder.Entity<Cust>(entity =>
            {
                entity.ToTable("Cust");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustOrder>(entity =>
            {
                entity.ToTable("CustOrder");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.PurchaseDate).HasColumnType("datetime");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustOrders)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CustOrder__Custo__0B91BA14");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.CustOrders)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CustOrder__Store__0C85DE4D");
            });

            modelBuilder.Entity<Pizza>(entity =>
            {
                entity.ToTable("Pizza");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("smallmoney");
            });

            modelBuilder.Entity<PizzaOrder>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Pizza_Order");

                entity.Property(e => e.CrustId).HasColumnName("CrustID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.PizzaId).HasColumnName("PizzaID");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.Quantity).HasDefaultValueSql("((1))");

                entity.Property(e => e.SizeId).HasColumnName("SizeID");

                entity.Property(e => e.ToppingId1).HasColumnName("ToppingID1");

                entity.Property(e => e.ToppingId2).HasColumnName("ToppingID2");

                entity.Property(e => e.ToppingId3).HasColumnName("ToppingID3");

                entity.Property(e => e.ToppingId4).HasColumnName("ToppingID4");

                entity.Property(e => e.ToppingId5).HasColumnName("ToppingID5");

                entity.HasOne(d => d.Crust)
                    .WithMany()
                    .HasForeignKey(d => d.CrustId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Pizza_Ord__Crust__114A936A");

                entity.HasOne(d => d.Order)
                    .WithMany()
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Pizza_Ord__Order__0E6E26BF");

                entity.HasOne(d => d.Pizza)
                    .WithMany()
                    .HasForeignKey(d => d.PizzaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Pizza_Ord__Pizza__0F624AF8");

                entity.HasOne(d => d.Size)
                    .WithMany()
                    .HasForeignKey(d => d.SizeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Pizza_Ord__SizeI__10566F31");

                entity.HasOne(d => d.ToppingId1Navigation)
                    .WithMany()
                    .HasForeignKey(d => d.ToppingId1)
                    .HasConstraintName("FK__Pizza_Ord__Toppi__123EB7A3");

                entity.HasOne(d => d.ToppingId2Navigation)
                    .WithMany()
                    .HasForeignKey(d => d.ToppingId2)
                    .HasConstraintName("FK__Pizza_Ord__Toppi__1332DBDC");

                entity.HasOne(d => d.ToppingId3Navigation)
                    .WithMany()
                    .HasForeignKey(d => d.ToppingId3)
                    .HasConstraintName("FK__Pizza_Ord__Toppi__14270015");

                entity.HasOne(d => d.ToppingId4Navigation)
                    .WithMany()
                    .HasForeignKey(d => d.ToppingId4)
                    .HasConstraintName("FK__Pizza_Ord__Toppi__151B244E");

                entity.HasOne(d => d.ToppingId5Navigation)
                    .WithMany()
                    .HasForeignKey(d => d.ToppingId5)
                    .HasConstraintName("FK__Pizza_Ord__Toppi__160F4887");
            });

            modelBuilder.Entity<Size>(entity =>
            {
                entity.ToTable("Size");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("smallmoney");
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.ToTable("Store");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Topping>(entity =>
            {
                entity.ToTable("Topping");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("smallmoney");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
