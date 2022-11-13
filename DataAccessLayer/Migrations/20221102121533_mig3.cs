using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Blogid",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_Blogid",
                table: "Comments",
                column: "Blogid");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Blogs_Blogid",
                table: "Comments",
                column: "Blogid",
                principalTable: "Blogs",
                principalColumn: "BlogId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Blogs_Blogid",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_Blogid",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "Blogid",
                table: "Comments");
        }
    }
}
