using System.Data;

namespace FactoryMethod
{
    // Interfaz que define los métodos comunes para todas las conexiones
    public interface IDatabaseConnection
    {
        void Connect();
        void Disconnect();
        IDbCommand CreateCommand();
    }
}
