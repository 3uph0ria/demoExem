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
using Подай_на_16.forms;

namespace Подай_на_16
{
    public partial class Client : Form
    {
        Service Service = new Service();
        TableLayoutPanel TableLayoutPanel = new TableLayoutPanel();
        public Client()
        {
            InitializeComponent();
        }


        private void buttonEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы дейстительно хотите редактировать услугу?", "", MessageBoxButtons.YesNo);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            SqlDataReader service = Service.SelectService(Convert.ToInt32((sender as Button).Tag));
            if (service.HasRows)
            {
                while (service.Read())
                {
                    object Title = service.GetValue(1);
                    DialogResult result = MessageBox.Show("Вы дейстительно хотите удалить услугу " + Title + "? ", "", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {

                        MessageBox.Show("услуга удалена", "", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void Client_Load_1(object sender, EventArgs e)
        {
            panel_service.Controls.Add(TableLayoutPanel);
            TableLayoutPanel.Width = panel_service.Width - 20;
            TableLayoutPanel.Height = 0;

            TableLayoutPanel.ColumnCount = 2;
            TableLayoutPanel.RowCount = 0;

            TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));

            int i = 0;
            int rowHeight = 150;
            SqlDataReader services = Service.SelectServices();
            if (services.HasRows)
            {
                while (services.Read())
                {
                    // Получаем значения из БД
                    object Id = services.GetValue(0);
                    object Title = services.GetValue(1);
                    object Cost = services.GetValue(2);
                    object DurationInSeconds = services.GetValue(3);
                    object Description = services.GetValue(4);
                    object Discount = services.GetValue(5);
                    object MainImagePath = services.GetValue(6);
                    string MainPathImg = Convert.ToString(MainImagePath);


                    // Добавляем строку и стили для нее
                    TableLayoutPanel.RowCount++;
                    TableLayoutPanel.Height = rowHeight * TableLayoutPanel.RowCount;
                    TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize, rowHeight));

                    TableLayoutPanel.RowCount++;
                    TableLayoutPanel.Height = rowHeight * TableLayoutPanel.RowCount;
                    TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize, rowHeight));

                    // Динамически добавлем панель для картинки
                    Panel panelImg = new Panel();
                    PictureBox serviceImg = new PictureBox();
                    serviceImg.BackgroundImageLayout = ImageLayout.Center;
                    panelImg.Controls.Add(serviceImg);
                    panelImg.Dock = DockStyle.Fill;
                    serviceImg.Dock = DockStyle.Fill;


                    char[] charsToTrim = { ' ' };
                    string result = MainPathImg.Trim(charsToTrim);
                    serviceImg.BackgroundImage = Image.FromFile(".\\" + result);

                    TableLayoutPanel.Controls.Add(panelImg, 0, i);

                    // Динамически добавляем вложенную таблицу
                    TableLayoutPanel brickIn = new TableLayoutPanel();
                    TableLayoutPanel.Controls.Add(brickIn, 1, i);
                    brickIn.Dock = DockStyle.Fill;
                    brickIn.ColumnCount = 2;
                    brickIn.RowCount = 3;
                    brickIn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
                    brickIn.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                    brickIn.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    brickIn.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    brickIn.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                    Label nameService = new Label();
                    nameService.Dock = DockStyle.Fill;
                    nameService.Text = Title + "";
                    nameService.Font = new Font(nameService.Font.FontFamily, 14);
                    Label costService = new Label();
                    string[] CostTmp = Convert.ToString(Cost).Split(new char[] { ',' });
                    int DurationInSecondsTmp = Convert.ToInt32(DurationInSeconds) / 60;

                    double DiscountTmp = Convert.ToDouble(Discount);

                    Label labelDiscount = new Label();
                    labelDiscount.Dock = DockStyle.Fill;
                    labelDiscount.Text = "";

                    double discont = 100 * DiscountTmp;
                    if (DiscountTmp > 0)
                    {
                        labelDiscount.Text = "*скидка " + discont + "%";
                        labelDiscount.Font = new Font(labelDiscount.Font.FontFamily, 14);

                        string g = Encoding.UTF8.GetString(new byte[] { 204, 182 });
                        double NewCost = Convert.ToInt32(CostTmp[0]) - (Convert.ToInt32(CostTmp[0]) * DiscountTmp);
                        costService.Text = string.Join(g, CostTmp[0].AsEnumerable()).Insert(0, g) + " " + NewCost + " рублей за " + DurationInSecondsTmp + " минут";
                    }
                    else
                    {
                        costService.Text = CostTmp[0] + " рублей за " + DurationInSecondsTmp + " минут";
                    }

                    costService.Dock = DockStyle.Fill;
                    costService.Font = new Font(costService.Font.FontFamily, 14);

                    brickIn.Controls.Add(nameService, 0, 0);
                    brickIn.Controls.Add(costService, 0, 1);
                    if (DiscountTmp > 0)
                    { 
                        brickIn.Controls.Add(labelDiscount, 0, 2);
                        brickIn.BackColor = Color.FromArgb(255, 255, 225);

                    }

                    i++;
                }
            }
        }

        private void action_exit_Click(object sender, EventArgs e)
        {
            signin signin = new signin();
            signin.Show();
            Hide();
        }

        private void panel_service_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_header_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
