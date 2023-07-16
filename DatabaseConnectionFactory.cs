namespace FactoryMethod
{
    // Fábrica abstracta para crear conexiones
    public abstract class DatabaseConnectionFactory
    {
        public abstract IDatabaseConnection CreateConnection();
    }
}
