using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeeMangement.Data.Migrations
{
    public partial class Create_Entities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FoodCategory",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodCategory", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TableFood",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableFood", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserID = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    DisplayName = table.Column<string>(nullable: true),
                    PassWord = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Food",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    image = table.Column<string>(nullable: true),
                    price = table.Column<string>(nullable: true),
                    idCategory = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Food", x => x.id);
                    table.ForeignKey(
                        name: "FK_Food_FoodCategory_idCategory",
                        column: x => x.idCategory,
                        principalTable: "FoodCategory",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bill",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    DateCheckIn = table.Column<DateTime>(nullable: false),
                    DateCheckOut = table.Column<DateTime>(nullable: false),
                    status = table.Column<int>(nullable: false),
                    discount = table.Column<int>(nullable: false),
                    totalPrice = table.Column<double>(nullable: false),
                    idTable = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bill", x => x.id);
                    table.ForeignKey(
                        name: "FK_Bill_TableFood_idTable",
                        column: x => x.idTable,
                        principalTable: "TableFood",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BillInfo",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    count = table.Column<int>(nullable: false),
                    idBill = table.Column<Guid>(nullable: false),
                    idFood = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillInfo", x => x.id);
                    table.ForeignKey(
                        name: "FK_BillInfo_Bill_idBill",
                        column: x => x.idBill,
                        principalTable: "Bill",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BillInfo_Food_idFood",
                        column: x => x.idFood,
                        principalTable: "Food",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bill_idTable",
                table: "Bill",
                column: "idTable");

            migrationBuilder.CreateIndex(
                name: "IX_BillInfo_idBill",
                table: "BillInfo",
                column: "idBill");

            migrationBuilder.CreateIndex(
                name: "IX_BillInfo_idFood",
                table: "BillInfo",
                column: "idFood");

            migrationBuilder.CreateIndex(
                name: "IX_Food_idCategory",
                table: "Food",
                column: "idCategory");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BillInfo");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Bill");

            migrationBuilder.DropTable(
                name: "Food");

            migrationBuilder.DropTable(
                name: "TableFood");

            migrationBuilder.DropTable(
                name: "FoodCategory");
        }
    }
}
