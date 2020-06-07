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

        public void CreateCategory(CategoryEntity objCategory)
        {
            using (var db = new InventoryContext())
            {
                db.Categories.Add(objCategory);
                db.SaveChanges();
            }
        }
        public void UpdateCategory(CategoryEntity objCategory)
        {
            using (var db = new InventoryContext())
            {
                db.Categories.Update(objCategory);
                db.SaveChanges();
            }
        }
    }
}
