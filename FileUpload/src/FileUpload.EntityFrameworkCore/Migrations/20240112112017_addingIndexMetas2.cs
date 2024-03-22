using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FileUpload.Migrations
{
    /// <inheritdoc />
    public partial class addingIndexMetas2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AppIndexMeta",
                table: "AppIndexMeta");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppDocument",
                table: "AppDocument");

            migrationBuilder.RenameTable(
                name: "AppIndexMeta",
                newName: "IndexMetas");

            migrationBuilder.RenameTable(
                name: "AppDocument",
                newName: "Documents");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IndexMetas",
                table: "IndexMetas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Documents",
                table: "Documents",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_IndexMetas",
                table: "IndexMetas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Documents",
                table: "Documents");

            migrationBuilder.RenameTable(
                name: "IndexMetas",
                newName: "AppIndexMeta");

            migrationBuilder.RenameTable(
                name: "Documents",
                newName: "AppDocument");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppIndexMeta",
                table: "AppIndexMeta",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppDocument",
                table: "AppDocument",
                column: "Id");
        }
    }
}
