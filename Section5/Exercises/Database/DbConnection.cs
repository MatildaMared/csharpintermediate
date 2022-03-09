abstract public class DbConnection
{
    public string ConnectionString { get; set; }
    public TimeSpan Timeout { get; set; }

    public DbConnection(string connectionString)
    {
        if (string.IsNullOrWhiteSpace(connectionString))
        {
            throw new ArgumentException("Connection string cannot be null or empty");
        }
        this.ConnectionString = connectionString;
    }

    abstract public void OpenConnection();
    abstract public void CloseConnection();
}