using EF_Task3.Data;
using EF_Task3.Models;

namespace EF_Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext dbContext = new ApplicationDbContext();

            Product product1 = new Product() { Name="LapTop" , Price=1200.99};
            Product product2 = new Product() { Name = "SmartPhone", Price = 800.99 };
            Product product3 = new Product() { Name = "Tablet", Price = 450.750 };
            Product product4 = new Product() { Name = "SmartWatch", Price = 600.99 };

            Order order1 = new Order() { Address="Ramallah" , GreatedAt = new DateTime(2024,7,4,6,8,0) };
            Order order2 = new Order() { Address = "Nabluse", GreatedAt = new DateTime(2024,8,8,8,8,0) };
            Order order3 = new Order() { Address = "Qalqilia", GreatedAt = DateTime.Now };
            Order order4 = new Order() { Address = "Hebron", GreatedAt = DateTime.Now };
            Order order5 = new Order() { Address ="Gaza" ,  GreatedAt=new DateTime(2023, 7, 11, 9, 15, 0) };

            //dbContext.Orders.Add(order1);
            //dbContext.Orders.Add(order2);
            //dbContext.Orders.Add(order3);
            //dbContext.Orders.Add(order4);
            //dbContext.Orders.Add(order5);
            //dbContext.SaveChanges();

            //var orders = dbContext.Orders.ToList();

            //foreach (var order in orders)
            //{
            //    Console.WriteLine(order);
            //}


            //dbContext.Products.Add(product1);
            //dbContext.Products.Add(product2);
            //dbContext.Products.Add(product3);
            //dbContext.Products.Add(product4);
            //dbContext.SaveChanges();

            //var products2 = dbContext.Products.ToList();

            //foreach (var product in products2)
            //{
            //    Console.WriteLine(product);
            //}

            var product = dbContext.Products.First(pro => pro.Id == 2);
            //product.Name = "Computer";
            //dbContext.SaveChanges();

            var order = dbContext.Orders.First(order => order.Id == 3);
            //order.GreatedAt = DateTime.Now;
            //dbContext.SaveChanges();

            dbContext.Remove(product);
            dbContext.SaveChanges();

            dbContext.Remove(order);
            dbContext.SaveChanges();

        }
    }
}
