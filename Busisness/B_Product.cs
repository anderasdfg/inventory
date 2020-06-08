using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_Product
    {
        public static List<ProductEntity> ProductList()
        {
            using (var db = new InventoryContext())
            {
                return db.Products.ToList();
            }
        }

        public static ProductEntity ProductById(string id)
        {
            using (var db = new InventoryContext())
            {
                return db.Products.ToList().LastOrDefault(p => p.ProductId == id);
            }
        }

        public static void CreateProduct(ProductEntity objProduct)
        {
            using (var db = new InventoryContext())
            {
                db.Products.Add(objProduct);
                db.SaveChanges();
            }
        }
        public static void UpdateProduct(ProductEntity objProduct)
        {
            using (var db = new InventoryContext())
            {
                db.Products.Update(objProduct);
                db.SaveChanges();
            }
        }
    }
}
