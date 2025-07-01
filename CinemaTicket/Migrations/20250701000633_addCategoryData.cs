using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CinemaTicket.Migrations
{
    /// <inheritdoc />
    public partial class addCategoryData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("  INSERT INTO Categories VALUES  ('Action'),  ('Comedy'),  ('Drama'),  ('Documentary'),  ('Cartoon'),  ('Horror') ");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("TRUNCATE TABLE Categories");


        }
    }
}
