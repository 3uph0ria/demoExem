using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Подай_на_16.Class
{
    class Service
    {
        Database Database = new Database();
        public SqlDataReader SelectServices()
        {
            Database.CloseConnection();
            Database.OpenConnection();
            string sqlLine = @"SELECT * FROM Services";
            SqlCommand commend = new SqlCommand(sqlLine, Database.myConnection);
            SqlDataReader service = commend.ExecuteReader();
            return service;
        }



        public SqlDataReader SelectService(int id)
        {
            Database.CloseConnection();
            Database.OpenConnection();
            string sqlLine = "SELECT * FROM Service WHERE Id = " + id;
            SqlCommand commend = new SqlCommand(sqlLine, Database.myConnection);
            SqlDataReader service = commend.ExecuteReader();
            return service;
        }

        public void DeleteService(int id)
        {
            Database.CloseConnection();
            Database.OpenConnection();
            string sqlLine = @"DELETE FROM Service WHERE ID = " + id;
            SqlCommand commend = new SqlCommand(sqlLine, Database.myConnection);
            SqlDataReader service = commend.ExecuteReader();
        }

        public void UpdateService(int id, string Title, double Cost, int DurationInSeconds, string Description, double Discount, string MainImagePath)
        {
            Database.CloseConnection();
            Database.OpenConnection();
            string sqlLine = @"UPDATE Service SET Title = @Title, Cost = @Cost, DurationInSeconds = @DurationInSeconds,
                Description = @Description, Discount = @Discount, MainImagePath = @MainImagePath WHERE ID = @id";

            SqlCommand commend = new SqlCommand(sqlLine, Database.myConnection);
             
            SqlParameter idParam = new SqlParameter("@id", id);
            commend.Parameters.Add(idParam);
            SqlParameter TitleParam = new SqlParameter("@Title", Title);
            commend.Parameters.Add(TitleParam);
            SqlParameter CostParam = new SqlParameter("@Cost", Cost);
            commend.Parameters.Add(CostParam);
            SqlParameter DurationInSecondsParam = new SqlParameter("@DurationInSeconds", DurationInSeconds);
            commend.Parameters.Add(DurationInSecondsParam);
            SqlParameter DescriptionParam = new SqlParameter("@Description", Description);
            commend.Parameters.Add(DescriptionParam);
            SqlParameter DiscountParam = new SqlParameter("@Discount", Discount);
            commend.Parameters.Add(DiscountParam);
            SqlParameter MainImagePathParam = new SqlParameter("@MainImagePath", MainImagePath);
            commend.Parameters.Add(MainImagePathParam);


            SqlDataReader service = commend.ExecuteReader();
        }

        public void AddService(string Title, double Cost, int DurationInSeconds, string Description, double Discount, string MainImagePath)
        {
            Database.CloseConnection();
            Database.OpenConnection();
            string sqlLine = @"INSERT INTO Service  (Title, Cost, DurationInSeconds, Description, Discount, MainImagePath) VALUES(@Title, @Cost, @DurationInSeconds,
                @Description, @Discount, @MainImagePath)";

            SqlCommand commend = new SqlCommand(sqlLine, Database.myConnection);

            SqlParameter TitleParam = new SqlParameter("@Title", Title);
            commend.Parameters.Add(TitleParam);
            SqlParameter CostParam = new SqlParameter("@Cost", Cost);
            commend.Parameters.Add(CostParam);
            SqlParameter DurationInSecondsParam = new SqlParameter("@DurationInSeconds", DurationInSeconds);
            commend.Parameters.Add(DurationInSecondsParam);
            SqlParameter DescriptionParam = new SqlParameter("@Description", Description);
            commend.Parameters.Add(DescriptionParam);
            SqlParameter DiscountParam = new SqlParameter("@Discount", Discount);
            commend.Parameters.Add(DiscountParam);
            SqlParameter MainImagePathParam = new SqlParameter("@MainImagePath", MainImagePath);
            commend.Parameters.Add(MainImagePathParam);

            SqlDataReader service = commend.ExecuteReader();
        }

    }
}
