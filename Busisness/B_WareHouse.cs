using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_WareHouse
    {
        public List<WareHouseEntity> WareHouseList()
        {
            using (var db = new InventoryContext())
            {
                return db.WareHouses.ToList();
            }
        }

        public void CreateWareHouse(WareHouseEntity objWareHouse)
        {
            using (var db = new InventoryContext())
            {
                db.WareHouses.Add(objWareHouse);
                db.SaveChanges();
            }
        }
        public void UpdateWareHouse(WareHouseEntity objWareHouse)
        {
            using (var db = new InventoryContext())
            {
                db.WareHouses.Update(objWareHouse);
                db.SaveChanges();
            }
        }
    }
}
