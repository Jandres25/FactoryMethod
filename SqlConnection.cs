using System;
using System.Data;

namespace FactoryMethod
{
    // Implementación concreta de la conexión a SQL Server
    public class SqlConnection : IDatabaseConnection
    {
        private readonly string connectionString;
        private IDbConnection connection;

        public SqlConnection(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Connect()
        {
            connection = new System.Data.SqlClient.SqlConnection(connectionString);
            connection.Open();
            Console.WriteLine("Conexión a SQL Server establecida");
        }

        public void Disconnect()
        {
            if (connection != null && connection.State != ConnectionState.Closed)
            {
                connection.Close();
                Console.WriteLine("Conexión a SQL Server cerrada");
            }
        }

        public IDbCommand CreateCommand()
        {
            return connection.CreateCommand();
        }
    }
}
