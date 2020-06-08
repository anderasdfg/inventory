using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_Category
    {
        public static List<CategoryEntity> CategoryList()
        {
            using (var db = new InventoryContext())
            {
                return db.Categories.ToList();
            }
        }
        public static CategoryEntity CategoryById(string id)
        {
            using (var db = new InventoryContext())
            {
                return db.Categories.ToList().LastOrDefault(c => c.CategoryId == id);
            }
        }

        public static void CreateCategory(CategoryEntity objCategory)
        {
            using (var db = new InventoryContext())
            {
                db.Categories.Add(objCategory);
                db.SaveChanges();
            }
        }
        public static void UpdateCategory(CategoryEntity objCategory)
        {
            using (var db = new InventoryContext())
            {
                db.Categories.Update(objCategory);
                db.SaveChanges();
            }
        }
    }
}
