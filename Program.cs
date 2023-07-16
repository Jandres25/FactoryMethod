using System;
using System.Data;

namespace FactoryMethod
{
    public class Program
    {
        // Ejemplo de uso
        public static void Main()
        {
            // Crear la fábrica concreta para SQL Server
            DatabaseConnectionFactory factory = new SqlConnectionFactory("Data Source=(local);Initial Catalog=Dbreserva1;Integrated Security=True");

            // Utilizar la fábrica para crear una conexión
            IDatabaseConnection connection = factory.CreateConnection();

            // Conectar y realizar operaciones4
            connection.Connect();
            IDbCommand command = connection.CreateCommand();
            Console.ReadLine();
            // ... realizar operaciones con el comando ...

            // Desconectar
            connection.Disconnect();
            Console.ReadLine();
        }
    }
}
