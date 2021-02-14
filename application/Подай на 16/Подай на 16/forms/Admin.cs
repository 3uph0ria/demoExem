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
    public partial class Admin : Form
    {
        Service Service = new Service();
        TableLayoutPanel TableLayoutPanel = new TableLayoutPanel();
        public Admin()
        {
            InitializeComponent();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы дейстительно хотите редактировать услугу?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                UpdateService updateService = new UpdateService(Convert.ToInt32((sender as Button).Tag));
                updateService.Show();
                Hide();
            }
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
                        Service.DeleteService(Convert.ToInt32((sender as Button).Tag));
                        MessageBox.Show("услуга удалена", "", MessageBoxButtons.OK);
                    }
                }
            }
        }


        private void action_exit_Click(object sender, EventArgs e)
        {
            signin signin = new signin();
            signin.Show();
            Hide();
        }

        private void Admin_Load(object sender, EventArgs e)
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
                    TableLayoutPanel buttons = new TableLayoutPanel();
                    TableLayoutPanel.Controls.Add(brickIn, 1, i);
                    brickIn.Dock = DockStyle.Fill;
                    buttons.Dock = DockStyle.Fill;
                    brickIn.ColumnCount = 2;
                    brickIn.RowCount = 4;
                    brickIn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
                    brickIn.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                    brickIn.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    brickIn.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    brickIn.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    brickIn.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
                    brickIn.Height = 200;
                    brickIn.Controls.Add(buttons, 0, 4);

                    buttons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                    buttons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                    buttons.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));

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

                    // Динамически добавлем кнопки
                    Button edit = new Button();
                    edit.Dock = DockStyle.Fill;
                    edit.Text = "Редактировать";
                    edit.Click += buttonEdit_Click;
                    edit.Tag = Id + "";
                    edit.BackColor = System.Drawing.Color.White;
                    edit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
                    edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    edit.Font = new System.Drawing.Font("Roboto", 15.75F);
                    edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));

                    Button delete = new Button();
                    delete.Dock = DockStyle.Fill;
                    delete.Text = "Удалить";
                    delete.Click += buttonDelete_Click;
                    delete.Tag = Id + "";
                    delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
                    delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    delete.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    delete.ForeColor = System.Drawing.Color.White;

                    buttons.Controls.Add(edit, 0, 0);
                    buttons.Controls.Add(delete, 1, 0);

                    i++;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel_service.Controls.Clear();
            TableLayoutPanel.Controls.Clear();
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
                    object Cost = services.GetValue(4);
                    object DurationInSeconds = services.GetValue(3);
                    object Discount = services.GetValue(5);
                    object MainImagePath = services.GetValue(2);
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
                    serviceImg.BackgroundImage = Image.FromFile("" + result);

                    TableLayoutPanel.Controls.Add(panelImg, 0, i);

                    // Динамически добавляем вложенную таблицу
                    TableLayoutPanel brickIn = new TableLayoutPanel();
                    TableLayoutPanel buttons = new TableLayoutPanel();
                    TableLayoutPanel.Controls.Add(brickIn, 1, i);
                    brickIn.Dock = DockStyle.Fill;
                    buttons.Dock = DockStyle.Fill;
                    brickIn.ColumnCount = 2;
                    brickIn.RowCount = 4;
                    brickIn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
                    brickIn.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                    brickIn.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    brickIn.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    brickIn.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    brickIn.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
                    brickIn.Height = 200;
                    brickIn.Controls.Add(buttons, 0, 4);

                    buttons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                    buttons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                    buttons.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));

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

                    // Динамически добавлем кнопки
                    Button edit = new Button();
                    edit.Dock = DockStyle.Fill;
                    edit.Text = "Редактировать";
                    edit.Click += buttonEdit_Click;
                    edit.Tag = Id + "";
                    edit.BackColor = System.Drawing.Color.White;
                    edit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
                    edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    edit.Font = new System.Drawing.Font("Roboto", 15.75F);
                    edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));

                    Button delete = new Button();
                    delete.Dock = DockStyle.Fill;
                    delete.Text = "Удалить";
                    delete.Click += buttonDelete_Click;
                    delete.Tag = Id + "";
                    delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
                    delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    delete.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    delete.ForeColor = System.Drawing.Color.White;

                    buttons.Controls.Add(edit, 0, 0);
                    buttons.Controls.Add(delete, 1, 0);

                    i++;
                }
            }
        }

        private void action_exit_Click_1(object sender, EventArgs e)
        {
            signin signin = new signin();
            signin.Show();
            Hide();
        }

        private void action_add_service_Click(object sender, EventArgs e)
        {
            AddService addService = new AddService();
            addService.Show();
            Hide();
        }
    }
}
