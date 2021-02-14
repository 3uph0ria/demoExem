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
using Подай_на_16.classes;

namespace Подай_на_16.forms
{
    public partial class test : Form
    {
        Service service = new Service();
        public test()
        {
            InitializeComponent();
            SqlDataReader servisec = service.GetServices();
            if(servisec.HasRows)
            {
                while(servisec.Read())
                {
                    comboBox1.Items.Add(servisec.GetString(1));
                }
                servisec.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = comboBox1.Text;
        }
    }
}
