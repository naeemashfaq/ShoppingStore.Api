using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoppingStore.Api.Migrations
{
    public partial class entityClassesUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerPromotion_Customers_CustomersId",
                table: "CustomerPromotion");

            migrationBuilder.RenameColumn(
                name: "CustomersId",
                table: "CustomerPromotion",
                newName: "CustomerId");

            migrationBuilder.CreateTable(
                name: "ProductPromotion",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    PromotionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPromotion", x => new { x.ProductId, x.PromotionId });
                    table.ForeignKey(
                        name: "FK_ProductPromotion_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductPromotion_Promotions_PromotionId",
                        column: x => x.PromotionId,
                        principalTable: "Promotions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductPromotion_PromotionId",
                table: "ProductPromotion",
                column: "PromotionId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerPromotion_Customers_CustomerId",
                table: "CustomerPromotion",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerPromotion_Customers_CustomerId",
                table: "CustomerPromotion");

            migrationBuilder.DropTable(
                name: "ProductPromotion");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "CustomerPromotion",
                newName: "CustomersId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerPromotion_Customers_CustomersId",
                table: "CustomerPromotion",
                column: "CustomersId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
