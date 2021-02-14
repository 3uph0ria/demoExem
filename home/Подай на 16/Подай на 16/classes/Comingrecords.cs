using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Подай_на_16.classes
{
    public partial class Comingrecords : Form
    {
        ServiceClient serviceClient = new ServiceClient();
        public Comingrecords()
        {
            InitializeComponent();
        }

        private void Comingrecords_Load(object sender, EventArgs e)
        {
            DataGridView ComingRecords = new DataGridView();
            main_panel.Controls.Add(ComingRecords);
            ComingRecords.Dock = DockStyle.Fill;

            SqlDataReader comingRecords = serviceClient.GetComingRecords();
            if(comingRecords.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Услуга");
                dt.Columns.Add("Имя");
                dt.Columns.Add("Фамилия");
                dt.Columns.Add("Отчество");
                dt.Columns.Add("Email");
                dt.Columns.Add("Телефон");
                dt.Columns.Add("Дата оказания услуги");

                while (comingRecords.Read())
                {
                    DataRow dr = dt.NewRow();
                    dr["Услуга"] = comingRecords.GetString(0);
                    dr["Имя"] = comingRecords.GetString(1);
                    dr["Фамилия"] = comingRecords.GetString(2);
                    dr["Отчество"] = comingRecords.GetString(3);
                    dr["Email"] = comingRecords.GetString(4);
                    dr["Телефон"] = comingRecords.GetString(5);
                    dr["Дата оказания услуги"] = comingRecords.GetValue(6);
                    dt.Rows.Add(dr);
                    ComingRecords.DataSource = dt;
                }
                comingRecords.Close();
            }
            else
            {
                label1.Text = "Нету строк";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridView ComingRecords = new DataGridView();
            main_panel.Controls.Add(ComingRecords);
            ComingRecords.Dock = DockStyle.Fill;

            SqlDataReader comingRecords = serviceClient.GetComingRecords();
            if (comingRecords.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Услуга");
                dt.Columns.Add("Имя");
                dt.Columns.Add("Фамилия");
                dt.Columns.Add("Отчество");
                dt.Columns.Add("Email");
                dt.Columns.Add("Телефон");
                dt.Columns.Add("Дата оказания услуги");

                while (comingRecords.Read())
                {
                    DataRow dr = dt.NewRow();
                    dr["Услуга"] = comingRecords.GetString(0);
                    dr["Имя"] = comingRecords.GetString(1);
                    dr["Фамилия"] = comingRecords.GetString(2);
                    dr["Отчество"] = comingRecords.GetString(3);
                    dr["Email"] = comingRecords.GetString(4);
                    dr["Телефон"] = comingRecords.GetString(5);
                    dr["Дата оказания услуги"] = comingRecords.GetValue(6);
                    dt.Rows.Add(dr);
                    ComingRecords.DataSource = dt;
                }
                comingRecords.Close();
            }
        }
    }
}
