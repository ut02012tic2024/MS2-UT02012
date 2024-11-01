
internal class SqliteConnection : IDisposable
{
    public SqliteConnection(string? connectionString)
    {
        ConnectionString = connectionString;
    }

    public string? ConnectionString { get; }
}