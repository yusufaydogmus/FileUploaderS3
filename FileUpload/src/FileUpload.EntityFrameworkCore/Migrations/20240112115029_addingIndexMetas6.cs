using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FileUpload.Migrations
{
    /// <inheritdoc />
    public partial class addingIndexMetas6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "IndexMetas",
                type: "character varying(40)",
                maxLength: 40,
                nullable: true,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "IndexMetas",
                type: "timestamp without time zone",
                nullable: true,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId",
                table: "IndexMetas",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeleterId",
                table: "IndexMetas",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "IndexMetas",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtraProperties",
                table: "IndexMetas",
                type: "text",
                nullable: true,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "IndexMetas",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "IndexMetas",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifierId",
                table: "IndexMetas",
                type: "uuid",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "IndexMetas");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "IndexMetas");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "IndexMetas");

            migrationBuilder.DropColumn(
                name: "DeleterId",
                table: "IndexMetas");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "IndexMetas");

            migrationBuilder.DropColumn(
                name: "ExtraProperties",
                table: "IndexMetas");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "IndexMetas");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "IndexMetas");

            migrationBuilder.DropColumn(
                name: "LastModifierId",
                table: "IndexMetas");
        }
    }
}
