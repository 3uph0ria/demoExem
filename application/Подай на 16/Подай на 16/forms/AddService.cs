using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Подай_на_16.Class;

namespace Подай_на_16.forms
{
    public partial class AddService : Form
    {
        Service Service = new Service();
        public AddService()
        {
            InitializeComponent();
        }

        private void action_add_Click(object sender, EventArgs e)
        {
            if (input_title.Text != "" && input_cost.Text != "" && input_duration_seconds.Text != "" && input_main_image_path.Text != "")
            {
                string titleTmp = input_title.Text;
                double costTmp = Convert.ToDouble(input_cost.Text);
                int duration_secondsTmp = Convert.ToInt32(input_duration_seconds.Text);
                string descriptionTmp = input_description.Text;
                double discountTmp = Convert.ToDouble(input_discount.Text);
                string main_image_pathTmp = input_main_image_path.Text;
                Service.AddService(titleTmp, costTmp, duration_secondsTmp, descriptionTmp, discountTmp, main_image_pathTmp);
                MessageBox.Show("Вы добавили обновили услугу", "", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены", "", MessageBoxButtons.OK);
            }
        }

        private void action_add_serive_exit_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            Hide();
        }

        private void action_exit_add_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            Hide();
        }
    }
}
