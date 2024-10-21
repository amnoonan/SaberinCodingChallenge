using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace music_manager_starter.Data.Migrations
{
    /// <inheritdoc />
    public partial class NewSongProps : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Create new song properties

            migrationBuilder.AddColumn<double>(
                name: "AvgRating",
                table: "Songs",
                defaultValue: 0,
                nullable: false
            );
            migrationBuilder.AddColumn<DateOnly>(
                name: "ReleaseDate",
                table: "Songs",
                defaultValue: new DateOnly(1970, 1, 1),
                nullable: true
            );

            // Update the ReleaseDate values for the songs in the inital database

            migrationBuilder.Sql(@"
                UPDATE Songs
                SET ReleaseDate = '2022-06-03'
                WHERE Album = 'Twelve Carat Toothache';

                UPDATE Songs
                SET ReleaseDate = '2023-01-05'
                WHERE Album = 'Canyon';

                UPDATE Songs
                SET ReleaseDate = '2019-03-29'
                WHERE Album = 'When We All Fall Asleep, Where Do We Go?';

                UPDATE Songs
                SET ReleaseDate = '2021-05-04'
                WHERE Album = 'Spiritbox';

                UPDATE Songs
                SET ReleaseDate = '2006-10-20'
                WHERE Album = 'The Great Escape';

                UPDATE Songs
                SET ReleaseDate = '2001-09-30'
                WHERE Album = 'I Love You.';

                UPDATE Songs
                SET ReleaseDate = '1989-12-15'
                WHERE Album = 'Single';
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn("AvgRating", "Songs");
            migrationBuilder.DropColumn("ReleaseDate", "Songs");
        }
    }
}
