using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ProdajalnaArtiklov.Models;
namespace ProdajalnaArtiklov.Data
{
    public class ProdajalnaArtiklovContextInitializer:
        DropCreateDatabaseIfModelChanges<ProdajalnaArtiklovContext>
    {
        protected override void Seed(ProdajalnaArtiklovContext context)
        {
            var produkti = new List<Product>()
            { 
            new Product(){Name="Juha",Price=1.30M,ActualCost=0.99M},
            new Product(){Name="Kladivo",Price=16.99M,ActualCost=10M},
            new Product(){Name="Jo jo",Price=6.99M,ActualCost=2.05M},
            };
            foreach (var p in produkti)
                context.Products.Add(p);
            context.SaveChanges();
            var order = new Order() { Customer = "Bob" };
            var od = new List<OrderDetail>()
            { 
            new OrderDetail(){Product=produkti[0],Quantity=2,Order=order},
            new OrderDetail(){Product=produkti[1],Quantity=4,Order=order}
            };
            context.Orders.Add(order);
            foreach (var o in od)
                context.OrderDetails.Add(o);
            context.SaveChanges();
        }
    }
}