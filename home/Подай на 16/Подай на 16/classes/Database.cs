using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Подай_на_16.classes
{
    class Database
    {
        public SqlConnection myCinnect;
        public Database()
        {
            this.myCinnect = this.Connect();
        }

        public SqlConnection Connect()
        {
            SqlConnection myConnection = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=poday_na_16;Integrated Security=True");
            return myConnection;
        }

        public void OpenConnetion()
        {
            if(this.myCinnect.State == System.Data.ConnectionState.Closed) this.myCinnect.Open();
        }

        public void ClouseConnection()
        {
            if (this.myCinnect.State == System.Data.ConnectionState.Open) this.myCinnect.Close();
        }
    }
}
