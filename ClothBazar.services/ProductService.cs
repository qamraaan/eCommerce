using ClothBazar.Database;
using ClothBazar.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothBazar.services
{
    public class ProductService
    {
       
        public CBContext context = new CBContext();
        public void CreateProduct(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();

        }
        public Product GetProduct(int id)
        {
           var product= context.Products.Find(id);
            return product;
        }
      public  List<Product> GetAll()
        {
            return context.Products.ToList();

        }
       
        public void UpdateProduct(Product product)
        {
            context.Entry(product).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }
        public void DeleteProduct(int id)
        {
          var product=  context.Products.Find(id);
            context.Products.Remove(product);
            context.SaveChanges();

            
        }
    }
}
