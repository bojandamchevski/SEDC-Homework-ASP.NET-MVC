using Microsoft.EntityFrameworkCore;
using SEDC.PizzaApp.Domain.Enums;
using SEDC.PizzaApp.Domain.Models;

namespace SEDC.PizzaApp.DataAccess
{
    public class PizzaAppDbContext : DbContext
    {
        public PizzaAppDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Order>()
                .HasMany(x => x.PizzaOrders)
                .WithOne(x => x.Order)
                .HasForeignKey(x => x.OrderId);

            modelBuilder.Entity<Pizza>()
                .HasMany(x => x.PizzaOrders)
                .WithOne(x => x.Pizza)
                .HasForeignKey(x => x.PizzaId);

            modelBuilder.Entity<User>()
                .HasMany(x => x.Orders)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId);

            modelBuilder.Entity<Feedback>();

            modelBuilder.Entity<Pizza>()
                .HasData(new Pizza
                {
                    Id = 1,
                    Name = "Kaprichioza",
                    IsOnPromotion = true
                },
                new Pizza
                {
                    Id = 2,
                    Name = "Pepperoni",
                    IsOnPromotion = false
                },
                new Pizza
                {
                    Id = 3,
                    Name = "Margarita",
                    IsOnPromotion = false
                }
                );

            modelBuilder.Entity<User>()
                .HasData(new User
                {
                    Id = 1,
                    FirstName = "Tanja",
                    LastName = "Stojanovska",
                    Address = "Address1"

                },
                new User
                {
                    Id = 2,
                    FirstName = "Aleksandar",
                    LastName = "Manasiev",
                    Address = "Address2"
                });
            modelBuilder.Entity<Order>()
                .HasData(new Order
                {
                    Id = 1,
                    PaymentMethod = PaymentMethodEnum.Card,
                    Delivered = true,
                    Location = "Store1",
                    UserId = 1
                },
                new Order
                {
                    Id = 2,
                    PaymentMethod = PaymentMethodEnum.Cash,
                    Delivered = false,
                    Location = "Store2",
                    UserId = 2
                });

            modelBuilder.Entity<PizzaOrder>()
                .HasData(new PizzaOrder
                {
                    Id = 1,
                    OrderId = 1,
                    PizzaId = 1,
                    PizzaSize = PizzaSizeEnum.Standard
                },
                new PizzaOrder
                {
                    Id = 2,
                    OrderId = 1,
                    PizzaId = 2,
                    PizzaSize = PizzaSizeEnum.Family
                },
                 new PizzaOrder
                 {
                     Id = 3,
                     OrderId = 2,
                     PizzaId = 2,
                     PizzaSize = PizzaSizeEnum.Family
                 });
            modelBuilder.Entity<Feedback>()
                .HasData(new Feedback
                {
                    Id = 1,
                    Email = "jovana@yahoo.com",
                    Name = "Pizza review",
                    Message = "The pizza was great."
                },
                new Feedback
                {
                    Id = 2,
                    Email = "stefan@yahoo.com",
                    Name = "Pizza review",
                    Message = "The pizza was not great, not terrible."
                });
        }
    }
}
