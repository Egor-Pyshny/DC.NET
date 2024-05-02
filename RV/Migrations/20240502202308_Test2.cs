using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RV.Migrations
{
    /// <inheritdoc />
    public partial class Test2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_news_tbl_user_userId",
                table: "tbl_news");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "tbl_news",
                newName: "user_id");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_news_userId",
                table: "tbl_news",
                newName: "IX_tbl_news_user_id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_news_tbl_user_user_id",
                table: "tbl_news",
                column: "user_id",
                principalTable: "tbl_user",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_news_tbl_user_user_id",
                table: "tbl_news");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "tbl_news",
                newName: "userId");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_news_user_id",
                table: "tbl_news",
                newName: "IX_tbl_news_userId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_news_tbl_user_userId",
                table: "tbl_news",
                column: "userId",
                principalTable: "tbl_user",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
