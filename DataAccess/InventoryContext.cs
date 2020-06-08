using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class InventoryContext : DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<InputOutputEntity> InOut { get; set; }
        public DbSet<StorageEntity> Storages{ get; set; }

        public DbSet<WareHouseEntity> WareHouses{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server=PC-ANDERLEY; Database=InventoryDB; User Id=sa; Password=anderley");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CategoryEntity>().HasData(
                new CategoryEntity { CategoryId = "ASH", CategoryName="Aseo Hogar" },
                new CategoryEntity { CategoryId = "ASP", CategoryName = "Aseo Personal" },
                new CategoryEntity { CategoryId = "HGR", CategoryName = "Hogar" },
                new CategoryEntity { CategoryId = "PRF", CategoryName = "Perfumería" },
                new CategoryEntity { CategoryId = "SLD", CategoryName = "Salud" },
                new CategoryEntity { CategoryId = "VDJ", CategoryName = "Video Juegos" }
           );

            modelBuilder.Entity<WareHouseEntity>().HasData(
                new WareHouseEntity { WareHouseId= Guid.NewGuid().ToString(),
                                      WareHouseName = "Bodega Central",
                                      WareHouseAdress="Calle 8 con 23"},
                new WareHouseEntity
                {
                    WareHouseId = Guid.NewGuid().ToString(),
                    WareHouseName = "Bodega Norte",
                    WareHouseAdress = "Calle 6 con 53"
                },
                new WareHouseEntity
                {
                    WareHouseId = Guid.NewGuid().ToString(),
                    WareHouseName = "Bodega Central",
                    WareHouseAdress = "Calle 2 con 24"
                }
            );
            
        }

    }
}
