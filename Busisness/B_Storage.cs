using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_Storage
    {
        public List<StorageEntity> StorageList()
        {
            using (var db = new InventoryContext())
            {
                return db.Storages.ToList();
            }
        }

        public void CreateStorage(StorageEntity objStorage)
        {
            using (var db = new InventoryContext())
            {
                db.Storages.Add(objStorage);
                db.SaveChanges();
            }
        }
        public void UpdateStorage(StorageEntity objStorage)
        {
            using (var db = new InventoryContext())
            {
                db.Storages.Update(objStorage);
                db.SaveChanges();
            }
        }
    }
}
