using ClothBazar.Database;
using ClothBazar.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothBazar.services
{
    public class CatogeryService
    {
        public CBContext context = new CBContext();
        public void CreateCatogery(Catogery catogery)
        {
            context.Catogeries.Add(catogery);
            context.SaveChanges();

        }
        public Catogery GetCatogery(int id)
        {
           var catogery= context.Catogeries.Find(id);
            return catogery;
        }
      public  List<Catogery> GetAll()
        {
            return context.Catogeries.ToList();

        }
       public Catogery EditCatogery(int id)
        {
           var catogery= context.Catogeries.Find(id);
            return (catogery);
        }
        public void UpdateCatogery(Catogery catogery)
        {
            context.Entry(catogery).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }
        public void DeleteCatogery(int id)
        {
          var catogery=  context.Catogeries.Find(id);
            context.Catogeries.Remove(catogery);
            context.SaveChanges();

            
        }
    }
}
