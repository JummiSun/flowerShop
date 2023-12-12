using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FShop
{
    internal class DB
    {
        MySqlConnection connection = new MySqlConnection("server=127.0.0.1; port=3307; user=root; password=; database=flower_shop");
    
        public void openConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }

        /*internal void Execute(Action<object> value)
        {
            throw new NotImplementedException();
        }
*/
        public void Execute(Action<MySqlConnection> action)
        {
            try
            {
                openConnection();
                action.Invoke(connection);
            }
            catch (Exception ex)
            {
                // Обработка исключений (например, вывод в консоль или логирование)
                Console.WriteLine(ex.Message);
            }
            finally
            {
                closeConnection();
            }
        }


    }
}