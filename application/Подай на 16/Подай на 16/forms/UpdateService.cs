using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Подай_на_16.Class;

namespace Подай_на_16.forms
{
    public partial class UpdateService : Form
    {
        Service Service = new Service();
        public UpdateService(int id)
        {
            InitializeComponent();
            Update(id);
        }

        private void action_exit_update_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
        }

        private void action_update_Click(object sender, EventArgs e)
        {
            if(input_title.Text != "" && input_cost.Text != "" && input_duration_seconds.Text != "" && input_main_image_path.Text != "")
            {
                int idTmp = Convert.ToInt32(input_id.Text);
                string titleTmp = input_title.Text;
                double costTmp = Convert.ToDouble(input_cost.Text);
                int duration_secondsTmp = Convert.ToInt32(input_duration_seconds.Text);
                string descriptionTmp = input_description.Text;
                double discountTmp = Convert.ToDouble(input_discount.Text);
                string main_image_pathTmp = input_main_image_path.Text;
                Service.UpdateService(idTmp, titleTmp, costTmp, duration_secondsTmp, descriptionTmp, discountTmp, main_image_pathTmp);
                MessageBox.Show("Вы успешно обновили услугу", "", MessageBoxButtons.OK);
                Update(Convert.ToInt32(input_id.Text));
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены", "", MessageBoxButtons.OK);
            }
        }
        public void Update(int id)
        {
            SqlDataReader service = Service.SelectService(id);
            if (service.HasRows)
            {
                while (service.Read())
                {

                    // Получаем значения из БД
                    object Id = service.GetValue(0);
                    object Title = service.GetValue(1);
                    object Cost = service.GetValue(2);
                    object DurationInSeconds = service.GetValue(3);
                    object Description = service.GetValue(4);
                    object Discount = service.GetValue(5);
                    object MainImagePath = service.GetValue(6);
                    string MainPathImg = Convert.ToString(MainImagePath);

                    // Заполнение полей
                    input_id.Text = id + "";
                    input_title.Text = Title + "";
                    input_cost.Text = Cost + "";
                    input_duration_seconds.Text = DurationInSeconds + "";
                    input_description.Text = Description + "";
                    input_discount.Text = Discount + "";
                    input_main_image_path.Text = MainPathImg + "";
                }
            }
        }

        private void action_exit_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            Hide();
        }
    }
}
