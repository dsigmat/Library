using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheckoutHistorys_LibraryAssets_LibraryAssetId",
                table: "CheckoutHistorys");

            migrationBuilder.DropForeignKey(
                name: "FK_CheckoutHistorys_LibraryCards_LibraryCardId",
                table: "CheckoutHistorys");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CheckoutHistorys",
                table: "CheckoutHistorys");

            migrationBuilder.RenameTable(
                name: "CheckoutHistorys",
                newName: "CheckoutHistories");

            migrationBuilder.RenameIndex(
                name: "IX_CheckoutHistorys_LibraryCardId",
                table: "CheckoutHistories",
                newName: "IX_CheckoutHistories_LibraryCardId");

            migrationBuilder.RenameIndex(
                name: "IX_CheckoutHistorys_LibraryAssetId",
                table: "CheckoutHistories",
                newName: "IX_CheckoutHistories_LibraryAssetId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CheckoutHistories",
                table: "CheckoutHistories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CheckoutHistories_LibraryAssets_LibraryAssetId",
                table: "CheckoutHistories",
                column: "LibraryAssetId",
                principalTable: "LibraryAssets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CheckoutHistories_LibraryCards_LibraryCardId",
                table: "CheckoutHistories",
                column: "LibraryCardId",
                principalTable: "LibraryCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheckoutHistories_LibraryAssets_LibraryAssetId",
                table: "CheckoutHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_CheckoutHistories_LibraryCards_LibraryCardId",
                table: "CheckoutHistories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CheckoutHistories",
                table: "CheckoutHistories");

            migrationBuilder.RenameTable(
                name: "CheckoutHistories",
                newName: "CheckoutHistorys");

            migrationBuilder.RenameIndex(
                name: "IX_CheckoutHistories_LibraryCardId",
                table: "CheckoutHistorys",
                newName: "IX_CheckoutHistorys_LibraryCardId");

            migrationBuilder.RenameIndex(
                name: "IX_CheckoutHistories_LibraryAssetId",
                table: "CheckoutHistorys",
                newName: "IX_CheckoutHistorys_LibraryAssetId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CheckoutHistorys",
                table: "CheckoutHistorys",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CheckoutHistorys_LibraryAssets_LibraryAssetId",
                table: "CheckoutHistorys",
                column: "LibraryAssetId",
                principalTable: "LibraryAssets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CheckoutHistorys_LibraryCards_LibraryCardId",
                table: "CheckoutHistorys",
                column: "LibraryCardId",
                principalTable: "LibraryCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
