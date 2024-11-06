using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using ITshop.Models;


namespace ITshop.Data

{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Device> Devices { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<DeviceAssignment> DeviceAssignments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<DeviceAssignment>()
                .HasKey(pi => new { pi.DeviceId, pi.AssignmentId });

            modelBuilder.Entity<DeviceAssignment>()
                .HasOne(pi => pi.Device)
                .WithMany(p => p.DeviceAssignments)
                .HasForeignKey(pi => pi.DeviceId);

            modelBuilder.Entity<DeviceAssignment>()
                .HasOne(pi => pi.Assignment)
                .WithMany(i => i.DeviceAssignments)
                .HasForeignKey(pi => pi.AssignmentId);
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Laptop" },
                new Category { CategoryId = 2, Name = "Telefon" },
                new Category { CategoryId = 3, Name = "Komputer Stacjonarny" },
                new Category { CategoryId = 4, Name = "Drukarka" },
                new Category { CategoryId = 5, Name = "Tablet" }
                );

            modelBuilder.Entity<Assignment>().HasData(
    new Assignment { AssignmentId = 1, Name = "Dell XPS 13" },
    new Assignment { AssignmentId = 2, Name = "Iphone 14" },
    new Assignment { AssignmentId = 3, Name = "RTX 4090, i9-13900KF, 64GB RAM" },
    new Assignment { AssignmentId = 4, Name = "Drukarka Brother" },
    new Assignment { AssignmentId = 5, Name = "Apple iPad mini, Wi‐Fi, 128 GB" }
                );

            modelBuilder.Entity<Device>().HasData(

               
                new Device
                {
                    DeviceId = 1,
                    Name = "Iphone 14",
                    Description = "Mega fajny telefon",
                    Price = 250m,
                    Stock = 100,
                    CategoryId = 2
                },
                new Device
                {
                    DeviceId = 2,
                    Name = " MSI MPG Infinite X2 13FNUI-006EU",
                    Description = "pozdro",
                    Price = 399m,
                    Stock = 101,
                    CategoryId = 3
                },
                new Device
                {
                    DeviceId = 3,
                    Name = "Drukarka Canon i-SENSYS MF453DW DADF",
                    Description = "tak jak z nazwy wynika",
                    Price = 499m,
                    Stock = 90,
                    CategoryId = 4
                }
                );

            modelBuilder.Entity<DeviceAssignment>().HasData(
               new DeviceAssignment { DeviceId = 1, AssignmentId = 2 },
               new DeviceAssignment { DeviceId = 2, AssignmentId = 3 },
               new DeviceAssignment { DeviceId = 3, AssignmentId = 4 }
               );
        }
        }   
    
    }

