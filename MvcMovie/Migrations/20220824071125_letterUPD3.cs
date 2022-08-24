using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcMovie.Migrations
{
    public partial class letterUPD3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
            name: "Titile",
            table: "Movie",
            newName: "Title",
            schema: "dbo");

            migrationBuilder.RenameColumn(
            name: "ReleasedDate",
            table: "Movie",
            newName: "ReleaseDate",
            schema: "dbo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           migrationBuilder.RenameColumn(
           name: "Title",
           table: "Movie",
           newName: "Titile",
           schema: "dbo");

            migrationBuilder.RenameColumn(
            name: "ReleaseDate",
            table: "Movie",
            newName: "ReleasedDate",
            schema: "dbo");
        }
    }
}
