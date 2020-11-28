using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Подай_на_16.forms;

namespace Подай_на_16
{
    public partial class signin : Form
    {
        public signin()
        {
            InitializeComponent();
        }

        private void action_client_mode_Click(object sender, EventArgs e)
        {
            Client Client = new Client();
            Client.Show();
            Hide();
        }

        private void action_admin_mode_Click(object sender, EventArgs e)
        {
            if (input_code.Text != "")
            {
                if (input_code.Text == "0000")
                {
                    Admin Admin = new Admin();
                    Admin.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Неверный код");
                }
            }
            else
            {
                MessageBox.Show("Заполните поле 'код'");
            }
        }
    }
}
