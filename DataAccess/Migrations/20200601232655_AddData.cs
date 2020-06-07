using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WareHouses",
                keyColumn: "WareHouseId",
                keyValue: "a8501415-336a-4c4b-a4dd-130a7ac38078");

            migrationBuilder.DeleteData(
                table: "WareHouses",
                keyColumn: "WareHouseId",
                keyValue: "c1703814-352d-4df1-a804-14d551c30d18");

            migrationBuilder.DeleteData(
                table: "WareHouses",
                keyColumn: "WareHouseId",
                keyValue: "c1cb6298-26bf-45f6-b427-2a7d8bc830a1");

            migrationBuilder.InsertData(
                table: "WareHouses",
                columns: new[] { "WareHouseId", "WareHouseAdress", "WareHouseName" },
                values: new object[] { "a0e86add-df13-4d83-ae84-4b65cc73dc88", "Calle 8 con 23", "Bodega Central" });

            migrationBuilder.InsertData(
                table: "WareHouses",
                columns: new[] { "WareHouseId", "WareHouseAdress", "WareHouseName" },
                values: new object[] { "de3264cb-8e1e-4ece-8ad1-e00e0a8ae479", "Calle 6 con 53", "Bodega Norte" });

            migrationBuilder.InsertData(
                table: "WareHouses",
                columns: new[] { "WareHouseId", "WareHouseAdress", "WareHouseName" },
                values: new object[] { "cb1ea06d-930e-4235-ac8f-4dfd33db59b1", "Calle 2 con 24", "Bodega Central" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WareHouses",
                keyColumn: "WareHouseId",
                keyValue: "a0e86add-df13-4d83-ae84-4b65cc73dc88");

            migrationBuilder.DeleteData(
                table: "WareHouses",
                keyColumn: "WareHouseId",
                keyValue: "cb1ea06d-930e-4235-ac8f-4dfd33db59b1");

            migrationBuilder.DeleteData(
                table: "WareHouses",
                keyColumn: "WareHouseId",
                keyValue: "de3264cb-8e1e-4ece-8ad1-e00e0a8ae479");

            migrationBuilder.InsertData(
                table: "WareHouses",
                columns: new[] { "WareHouseId", "WareHouseAdress", "WareHouseName" },
                values: new object[] { "c1703814-352d-4df1-a804-14d551c30d18", "Calle 8 con 23", "Bodega Central" });

            migrationBuilder.InsertData(
                table: "WareHouses",
                columns: new[] { "WareHouseId", "WareHouseAdress", "WareHouseName" },
                values: new object[] { "c1cb6298-26bf-45f6-b427-2a7d8bc830a1", "Calle 6 con 53", "Bodega Norte" });

            migrationBuilder.InsertData(
                table: "WareHouses",
                columns: new[] { "WareHouseId", "WareHouseAdress", "WareHouseName" },
                values: new object[] { "a8501415-336a-4c4b-a4dd-130a7ac38078", "Calle 2 con 24", "Bodega Central" });
        }
    }
}
