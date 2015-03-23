using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Add support for EF and look for our Models
using System.Data.Entity;
using FXCodeFirstMVC.Models;

namespace FXCodeFirstMVC.DAL
{
    public class StoreInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<StoreContext>
    {
        //Here we are going to feed our database
        protected override void Seed(StoreContext context)
        {
            var products = new List<Product>()
            {
                new Product{Category="Bebidas", Name="Concordia de piña", Description="un producto de pepsi cola", CreatedDate=System.DateTime.Now, Price=1.20M},
                new Product{Category="Bebidas", Name="Concordia de fresa", Description="un producto de pepsi cola", CreatedDate=System.DateTime.Now, Price=1.20M},
                new Product{Category="Postres", Name="Torta brasilera", Description="la favorita de mi amoshiiita :3", CreatedDate=System.DateTime.Now, Price=4.00M},
                new Product{Category="Postres", Name="Torta de Chocolate", Description="uhm chocolate~", CreatedDate=System.DateTime.Now, Price=3.50M},
                new Product{Category="Helados", Name="Dolccetto", Description="a mi amoshiiita le encanta :3", CreatedDate=System.DateTime.Now, Price=3.00M},
                new Product{Category="Galletas", Name="Casino de menta", Description="buenisimas, lo maximo ya", CreatedDate=System.DateTime.Now, Price=0.50M}               

            };
            //Ahora guardamos
            products.ForEach(p => context.Products.Add(p));
            context.SaveChanges();
        }
    }
}