namespace ReactSerene
{
    public interface IDataMigrations
    {
        bool SkippedMigrations { get; }

        void Initialize();
    }
}