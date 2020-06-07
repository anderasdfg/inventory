using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
   public class B_InputOutput
    {
        public List<InputOutputEntity> InputOutputList()
        {
            using (var db = new InventoryContext())
            {
                return db.InOut.ToList();
            }
        }

        public void CreateInputOutput(InputOutputEntity objInputOutput)
        {
            using (var db = new InventoryContext())
            {
                db.InOut.Add(objInputOutput);
                db.SaveChanges();
            }
        }
        public void UpdateInputOutput(InputOutputEntity objInputOutput)
        {
            using (var db = new InventoryContext())
            {
                db.InOut.Update(objInputOutput);
                db.SaveChanges();
            }
        }
    }
}
