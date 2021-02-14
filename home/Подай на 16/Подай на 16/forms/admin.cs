using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Подай_на_16.classes;
using System.Data.SqlClient;

namespace Подай_на_16.forms
{
    public partial class admin : Form
    {
        Service Service = new Service();
        TableLayoutPanel MainLP = new TableLayoutPanel();
        public admin()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {
            MainLP.Controls.Clear();

            Timer timer = new Timer();
            timer.Interval = (10 * 1000);
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();

            SqlDataReader services = Service.GetServices();
            main_panel.Controls.Add(MainLP);

            int i = 0;
            int height = 150;

            MainLP.Height = 0;
            MainLP.Width = main_panel.Width - 20;
            MainLP.RowCount = 0;
            MainLP.ColumnCount = 2;

            MainLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            MainLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));

            if (services.HasRows)
            {
                while (services.Read())
                {
                    // Получаем данные из БД
                    int id = services.GetInt32(0);
                    string title = services.GetString(1);
                    string mainImage = services.GetString(2);
                    int duration = services.GetInt32(3);
                    int cost = services.GetInt32(4);
                    double discount = Convert.ToDouble(services.GetValue(5));

                    MainLP.RowCount++;
                    MainLP.Height = height * i;
                    MainLP.RowStyles.Add(new RowStyle(SizeType.Absolute, height));

                    Panel panelImg = new Panel();
                    PictureBox mainImagePictureBox = new PictureBox();
                    panelImg.Controls.Add(mainImagePictureBox);
                    panelImg.Dock = DockStyle.Fill;
                    mainImagePictureBox.Dock = DockStyle.Fill;

                    char[] charTrim = { ' ' };
                    mainImagePictureBox.BackgroundImage = Image.FromFile(mainImage.Trim(charTrim));

                    Label labelTitle = new Label();
                    labelTitle.Text = title + "123";

                    MainLP.Controls.Add(panelImg, 0, i);
                    MainLP.Controls.Add(labelTitle, 1, i);

                    i++;
                }
                services.Close();
            }

        }

        private void timer_Tick(object sender, EventArgs e)
        {
        }


    }
}
