using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    internal class DataBase
    {



        SqlConnection connect = new SqlConnection("Data Source = VELP; Initial Catalog = SaleCar; Integrated Security = true"); // Для конекта 

        public void openConnection() // Открывает бд
        {
            if (connect.State == System.Data.ConnectionState.Closed)
            {
                connect.Open();
            }

        }
        public void closeConnection() // Отключается от БД
        {
            if (connect.State == System.Data.ConnectionState.Open)
            {
                connect.Close();
            }
        }

        public SqlConnection getConnection() // подключение к БД
        {
            return connect;
        }

    }
}
