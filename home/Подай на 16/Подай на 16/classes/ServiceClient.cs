using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Подай_на_16.classes
{
    class ServiceClient
    {
        Database Database = new Database();
        public SqlDataReader GetComingRecords()
        {
            Database.ClouseConnection();
            Database.OpenConnetion();
            string sqlLine = "SELECT Services.Name, Clients.FirstName, Clients.LastName, Clients.Patronymic, Clients.Email, Clients.Telephone, ServiceClient.DateGetService FROM ServiceClient INNER JOIN Clients ON ServiceClient.ClientId = Clients.Id INNER JOIN Services ON ServiceClient.ServiceId = Services.Id WHERE ServiceClient.DateGetService >= DATEADD(day, -1, getdate()) and ServiceClient.DateGetService <= getdate()";
            SqlCommand commend = new SqlCommand(sqlLine, Database.myCinnect);
            SqlDataReader cominrecords = commend.ExecuteReader();
            return cominrecords;
        }
    }
}
