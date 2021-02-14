using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Подай_на_16.classes
{
    class Service
    {
        Database Database = new Database();

        /// <summary>
        /// Получаем все услуги компании
        /// </summary>
        /// <returns>услуги</returns>
        public SqlDataReader GetServices()
        {
            Database.ClouseConnection();
            Database.OpenConnetion();
            string sqlLine = "SELECT * FROM Services";
            SqlCommand commend = new SqlCommand(sqlLine, Database.myCinnect);
            SqlDataReader services = commend.ExecuteReader();
            return services;
        }

    }
}
