using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Подай_на_16.Class
{
    class Database
    {
        public SqlConnection myConnection;
        public Database()
        {
            this.myConnection = this.Connect();
        }
        public SqlConnection Connect()
        {
            SqlConnection myConnection = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=poday_na_16;Integrated Security=True");
            return myConnection;
        }

        public void OpenConnection()
        {
            if (this.myConnection.State == System.Data.ConnectionState.Closed) this.myConnection.Open();
        }

        public void CloseConnection()
        {
            if (this.myConnection.State == System.Data.ConnectionState.Open) this.myConnection.Close();
        }

    }
}
