namespace FactoryMethod
{
    // Fábrica concreta para crear conexiones a SQL Server
    public class SqlConnectionFactory : DatabaseConnectionFactory
    {
        private readonly string connectionString;

        public SqlConnectionFactory(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public override IDatabaseConnection CreateConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
