using FluentMigrator;

namespace MovieTutorial.Migrations.DefaultDB
{
    [Migration(20230918_143800)]
    public class DefaultDB_20230918_143800_SampleGenres : AutoReversingMigration
    {
        public override void Up()
        {
            Insert.IntoTable("Genre").InSchema("mov")
                .Row(new
                {
                    Name = "Action"
                })
                .Row(new
                {
                    Name = "Drama"
                })
                .Row(new
                {
                    Name = "Comedy"
                })
                .Row(new
                {
                    Name = "Sci-fi"
                })
                .Row(new
                {
                    Name = "Fantasy"
                })
                .Row(new
                {
                    Name = "Documentary"
                });
        }
    }
}
