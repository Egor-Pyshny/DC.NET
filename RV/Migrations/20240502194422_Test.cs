using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RV.Migrations
{
    /// <inheritdoc />
    public partial class Test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NewsSticker_tbl_News_newsId",
                table: "NewsSticker");

            migrationBuilder.DropForeignKey(
                name: "FK_NewsSticker_tbl_Sticker_stickerId",
                table: "NewsSticker");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_News_tbl_User_userId",
                table: "tbl_News");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Note_tbl_News_newsId",
                table: "tbl_Note");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_User",
                table: "tbl_User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_Sticker",
                table: "tbl_Sticker");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_Note",
                table: "tbl_Note");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_News",
                table: "tbl_News");

            migrationBuilder.RenameTable(
                name: "tbl_User",
                newName: "tbl_user");

            migrationBuilder.RenameTable(
                name: "tbl_Sticker",
                newName: "tbl_sticker");

            migrationBuilder.RenameTable(
                name: "tbl_Note",
                newName: "tbl_note");

            migrationBuilder.RenameTable(
                name: "tbl_News",
                newName: "tbl_news");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_User_login",
                table: "tbl_user",
                newName: "IX_tbl_user_login");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_Sticker_name",
                table: "tbl_sticker",
                newName: "IX_tbl_sticker_name");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_Note_newsId",
                table: "tbl_note",
                newName: "IX_tbl_note_newsId");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_News_userId",
                table: "tbl_news",
                newName: "IX_tbl_news_userId");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_News_title",
                table: "tbl_news",
                newName: "IX_tbl_news_title");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_user",
                table: "tbl_user",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_sticker",
                table: "tbl_sticker",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_note",
                table: "tbl_note",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_news",
                table: "tbl_news",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_NewsSticker_tbl_news_newsId",
                table: "NewsSticker",
                column: "newsId",
                principalTable: "tbl_news",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NewsSticker_tbl_sticker_stickerId",
                table: "NewsSticker",
                column: "stickerId",
                principalTable: "tbl_sticker",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_news_tbl_user_userId",
                table: "tbl_news",
                column: "userId",
                principalTable: "tbl_user",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_note_tbl_news_newsId",
                table: "tbl_note",
                column: "newsId",
                principalTable: "tbl_news",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NewsSticker_tbl_news_newsId",
                table: "NewsSticker");

            migrationBuilder.DropForeignKey(
                name: "FK_NewsSticker_tbl_sticker_stickerId",
                table: "NewsSticker");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_news_tbl_user_userId",
                table: "tbl_news");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_note_tbl_news_newsId",
                table: "tbl_note");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_user",
                table: "tbl_user");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_sticker",
                table: "tbl_sticker");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_note",
                table: "tbl_note");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_news",
                table: "tbl_news");

            migrationBuilder.RenameTable(
                name: "tbl_user",
                newName: "tbl_User");

            migrationBuilder.RenameTable(
                name: "tbl_sticker",
                newName: "tbl_Sticker");

            migrationBuilder.RenameTable(
                name: "tbl_note",
                newName: "tbl_Note");

            migrationBuilder.RenameTable(
                name: "tbl_news",
                newName: "tbl_News");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_user_login",
                table: "tbl_User",
                newName: "IX_tbl_User_login");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_sticker_name",
                table: "tbl_Sticker",
                newName: "IX_tbl_Sticker_name");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_note_newsId",
                table: "tbl_Note",
                newName: "IX_tbl_Note_newsId");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_news_userId",
                table: "tbl_News",
                newName: "IX_tbl_News_userId");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_news_title",
                table: "tbl_News",
                newName: "IX_tbl_News_title");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_User",
                table: "tbl_User",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_Sticker",
                table: "tbl_Sticker",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_Note",
                table: "tbl_Note",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_News",
                table: "tbl_News",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_NewsSticker_tbl_News_newsId",
                table: "NewsSticker",
                column: "newsId",
                principalTable: "tbl_News",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NewsSticker_tbl_Sticker_stickerId",
                table: "NewsSticker",
                column: "stickerId",
                principalTable: "tbl_Sticker",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_News_tbl_User_userId",
                table: "tbl_News",
                column: "userId",
                principalTable: "tbl_User",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Note_tbl_News_newsId",
                table: "tbl_Note",
                column: "newsId",
                principalTable: "tbl_News",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
