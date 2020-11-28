namespace Подай_на_16.forms
{
    partial class AddService
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.logo = new System.Windows.Forms.PictureBox();
            this.lable_main_image_path = new System.Windows.Forms.Label();
            this.input_main_image_path = new System.Windows.Forms.TextBox();
            this.lable_discount = new System.Windows.Forms.Label();
            this.input_discount = new System.Windows.Forms.TextBox();
            this.action_exit_add = new System.Windows.Forms.Button();
            this.action_add = new System.Windows.Forms.Button();
            this.lable_description = new System.Windows.Forms.Label();
            this.action_add_serive_exit = new System.Windows.Forms.Button();
            this.header_service = new System.Windows.Forms.Label();
            this.input_description = new System.Windows.Forms.TextBox();
            this.lable_duration_seconds = new System.Windows.Forms.Label();
            this.input_duration_seconds = new System.Windows.Forms.TextBox();
            this.lable_cost = new System.Windows.Forms.Label();
            this.input_cost = new System.Windows.Forms.TextBox();
            this.lable_title = new System.Windows.Forms.Label();
            this.input_title = new System.Windows.Forms.TextBox();
            this.panel_service = new System.Windows.Forms.Panel();
            this.panel_header = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel_service.SuspendLayout();
            this.panel_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Image = global::Подай_на_16.Properties.Resources.service_logo;
            this.logo.Location = new System.Drawing.Point(3, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(85, 36);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 5;
            this.logo.TabStop = false;
            // 
            // lable_main_image_path
            // 
            this.lable_main_image_path.AutoSize = true;
            this.lable_main_image_path.Font = new System.Drawing.Font("Roboto", 10.75F);
            this.lable_main_image_path.Location = new System.Drawing.Point(285, 165);
            this.lable_main_image_path.Name = "lable_main_image_path";
            this.lable_main_image_path.Size = new System.Drawing.Size(137, 18);
            this.lable_main_image_path.TabIndex = 25;
            this.lable_main_image_path.Text = "Путь до картинки";
            // 
            // input_main_image_path
            // 
            this.input_main_image_path.Font = new System.Drawing.Font("Roboto", 15.75F);
            this.input_main_image_path.Location = new System.Drawing.Point(288, 186);
            this.input_main_image_path.Name = "input_main_image_path";
            this.input_main_image_path.Size = new System.Drawing.Size(232, 33);
            this.input_main_image_path.TabIndex = 24;
            this.input_main_image_path.Text = " Услуги автосервиса\\Кондиционер.jpg";
            // 
            // lable_discount
            // 
            this.lable_discount.AutoSize = true;
            this.lable_discount.Font = new System.Drawing.Font("Roboto", 10.75F);
            this.lable_discount.Location = new System.Drawing.Point(19, 165);
            this.lable_discount.Name = "lable_discount";
            this.lable_discount.Size = new System.Drawing.Size(59, 18);
            this.lable_discount.TabIndex = 23;
            this.lable_discount.Text = "Скидка";
            // 
            // input_discount
            // 
            this.input_discount.Font = new System.Drawing.Font("Roboto", 15.75F);
            this.input_discount.Location = new System.Drawing.Point(22, 186);
            this.input_discount.Name = "input_discount";
            this.input_discount.Size = new System.Drawing.Size(234, 33);
            this.input_discount.TabIndex = 22;
            // 
            // action_exit_add
            // 
            this.action_exit_add.BackColor = System.Drawing.Color.White;
            this.action_exit_add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.action_exit_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.action_exit_add.Font = new System.Drawing.Font("Roboto", 15.75F);
            this.action_exit_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.action_exit_add.Location = new System.Drawing.Point(44, 255);
            this.action_exit_add.Name = "action_exit_add";
            this.action_exit_add.Size = new System.Drawing.Size(212, 51);
            this.action_exit_add.TabIndex = 21;
            this.action_exit_add.Text = "Отмена";
            this.action_exit_add.UseVisualStyleBackColor = false;
            this.action_exit_add.Click += new System.EventHandler(this.action_exit_add_Click);
            // 
            // action_add
            // 
            this.action_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.action_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.action_add.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.action_add.ForeColor = System.Drawing.Color.White;
            this.action_add.Location = new System.Drawing.Point(288, 255);
            this.action_add.Name = "action_add";
            this.action_add.Size = new System.Drawing.Size(212, 52);
            this.action_add.TabIndex = 20;
            this.action_add.Text = "Добавить";
            this.action_add.UseVisualStyleBackColor = false;
            this.action_add.Click += new System.EventHandler(this.action_add_Click);
            // 
            // lable_description
            // 
            this.lable_description.AutoSize = true;
            this.lable_description.Font = new System.Drawing.Font("Roboto", 10.75F);
            this.lable_description.Location = new System.Drawing.Point(285, 93);
            this.lable_description.Name = "lable_description";
            this.lable_description.Size = new System.Drawing.Size(78, 18);
            this.lable_description.TabIndex = 19;
            this.lable_description.Text = "Описание";
            // 
            // action_add_serive_exit
            // 
            this.action_add_serive_exit.BackColor = System.Drawing.Color.White;
            this.action_add_serive_exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.action_add_serive_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.action_add_serive_exit.Font = new System.Drawing.Font("Roboto", 15.75F);
            this.action_add_serive_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.action_add_serive_exit.Location = new System.Drawing.Point(358, 12);
            this.action_add_serive_exit.Name = "action_add_serive_exit";
            this.action_add_serive_exit.Size = new System.Drawing.Size(162, 42);
            this.action_add_serive_exit.TabIndex = 13;
            this.action_add_serive_exit.Text = "Выйти";
            this.action_add_serive_exit.UseVisualStyleBackColor = false;
            this.action_add_serive_exit.Click += new System.EventHandler(this.action_add_serive_exit_Click);
            // 
            // header_service
            // 
            this.header_service.AllowDrop = true;
            this.header_service.AutoSize = true;
            this.header_service.Font = new System.Drawing.Font("Roboto", 18.75F);
            this.header_service.Location = new System.Drawing.Point(94, 17);
            this.header_service.Name = "header_service";
            this.header_service.Size = new System.Drawing.Size(239, 30);
            this.header_service.TabIndex = 12;
            this.header_service.Text = "Добавление услуги";
            // 
            // input_description
            // 
            this.input_description.Font = new System.Drawing.Font("Roboto", 15.75F);
            this.input_description.Location = new System.Drawing.Point(288, 114);
            this.input_description.Name = "input_description";
            this.input_description.Size = new System.Drawing.Size(232, 33);
            this.input_description.TabIndex = 18;
            // 
            // lable_duration_seconds
            // 
            this.lable_duration_seconds.AutoSize = true;
            this.lable_duration_seconds.Font = new System.Drawing.Font("Roboto", 10.75F);
            this.lable_duration_seconds.Location = new System.Drawing.Point(19, 93);
            this.lable_duration_seconds.Name = "lable_duration_seconds";
            this.lable_duration_seconds.Size = new System.Drawing.Size(151, 18);
            this.lable_duration_seconds.TabIndex = 17;
            this.lable_duration_seconds.Text = "Время работы (сек)";
            // 
            // input_duration_seconds
            // 
            this.input_duration_seconds.Font = new System.Drawing.Font("Roboto", 15.75F);
            this.input_duration_seconds.Location = new System.Drawing.Point(22, 114);
            this.input_duration_seconds.Name = "input_duration_seconds";
            this.input_duration_seconds.Size = new System.Drawing.Size(234, 33);
            this.input_duration_seconds.TabIndex = 16;
            // 
            // lable_cost
            // 
            this.lable_cost.AutoSize = true;
            this.lable_cost.Font = new System.Drawing.Font("Roboto", 10.75F);
            this.lable_cost.Location = new System.Drawing.Point(285, 9);
            this.lable_cost.Name = "lable_cost";
            this.lable_cost.Size = new System.Drawing.Size(83, 18);
            this.lable_cost.TabIndex = 15;
            this.lable_cost.Text = "Цена (руб)";
            // 
            // input_cost
            // 
            this.input_cost.Font = new System.Drawing.Font("Roboto", 15.75F);
            this.input_cost.Location = new System.Drawing.Point(288, 30);
            this.input_cost.Name = "input_cost";
            this.input_cost.Size = new System.Drawing.Size(232, 33);
            this.input_cost.TabIndex = 14;
            // 
            // lable_title
            // 
            this.lable_title.AutoSize = true;
            this.lable_title.Font = new System.Drawing.Font("Roboto", 10.75F);
            this.lable_title.Location = new System.Drawing.Point(19, 9);
            this.lable_title.Name = "lable_title";
            this.lable_title.Size = new System.Drawing.Size(116, 18);
            this.lable_title.TabIndex = 13;
            this.lable_title.Text = "Наименование";
            // 
            // input_title
            // 
            this.input_title.Font = new System.Drawing.Font("Roboto", 15.75F);
            this.input_title.Location = new System.Drawing.Point(22, 30);
            this.input_title.Name = "input_title";
            this.input_title.Size = new System.Drawing.Size(234, 33);
            this.input_title.TabIndex = 12;
            // 
            // panel_service
            // 
            this.panel_service.AutoScroll = true;
            this.panel_service.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_service.BackColor = System.Drawing.Color.White;
            this.panel_service.Controls.Add(this.lable_main_image_path);
            this.panel_service.Controls.Add(this.input_main_image_path);
            this.panel_service.Controls.Add(this.lable_discount);
            this.panel_service.Controls.Add(this.input_discount);
            this.panel_service.Controls.Add(this.action_exit_add);
            this.panel_service.Controls.Add(this.action_add);
            this.panel_service.Controls.Add(this.lable_description);
            this.panel_service.Controls.Add(this.input_description);
            this.panel_service.Controls.Add(this.lable_duration_seconds);
            this.panel_service.Controls.Add(this.input_duration_seconds);
            this.panel_service.Controls.Add(this.lable_cost);
            this.panel_service.Controls.Add(this.input_cost);
            this.panel_service.Controls.Add(this.lable_title);
            this.panel_service.Controls.Add(this.input_title);
            this.panel_service.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_service.Location = new System.Drawing.Point(0, 72);
            this.panel_service.Name = "panel_service";
            this.panel_service.Size = new System.Drawing.Size(545, 378);
            this.panel_service.TabIndex = 7;
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.White;
            this.panel_header.Controls.Add(this.action_add_serive_exit);
            this.panel_header.Controls.Add(this.header_service);
            this.panel_header.Controls.Add(this.logo);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(545, 66);
            this.panel_header.TabIndex = 6;
            // 
            // AddService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 450);
            this.Controls.Add(this.panel_service);
            this.Controls.Add(this.panel_header);
            this.Name = "AddService";
            this.Text = "AddService";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel_service.ResumeLayout(false);
            this.panel_service.PerformLayout();
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label lable_main_image_path;
        private System.Windows.Forms.TextBox input_main_image_path;
        private System.Windows.Forms.Label lable_discount;
        private System.Windows.Forms.TextBox input_discount;
        private System.Windows.Forms.Button action_exit_add;
        private System.Windows.Forms.Button action_add;
        private System.Windows.Forms.Label lable_description;
        private System.Windows.Forms.Button action_add_serive_exit;
        private System.Windows.Forms.Label header_service;
        private System.Windows.Forms.TextBox input_description;
        private System.Windows.Forms.Label lable_duration_seconds;
        private System.Windows.Forms.TextBox input_duration_seconds;
        private System.Windows.Forms.Label lable_cost;
        private System.Windows.Forms.TextBox input_cost;
        private System.Windows.Forms.Label lable_title;
        private System.Windows.Forms.TextBox input_title;
        private System.Windows.Forms.Panel panel_service;
        private System.Windows.Forms.Panel panel_header;
    }
}