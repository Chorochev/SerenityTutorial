using FluentMigrator;

namespace MovieTutorial.Migrations.DefaultDB
{
    [Migration(20230918_140500)]
    public class DefaultDB_20230918_140500_MovieKind : AutoReversingMigration
    {
        public override void Up()
        {
            Alter.Table("Movie").InSchema("mov")
                .AddColumn("Kind").AsInt32().NotNullable()
                    .WithDefaultValue(1);
        }
    }
}
