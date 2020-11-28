namespace Подай_на_16.forms
{
    partial class UpdateService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateService));
            this.panel_header = new System.Windows.Forms.Panel();
            this.action_exit = new System.Windows.Forms.Button();
            this.header_service = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panel_service = new System.Windows.Forms.Panel();
            this.lable_main_image_path = new System.Windows.Forms.Label();
            this.input_main_image_path = new System.Windows.Forms.TextBox();
            this.lable_discount = new System.Windows.Forms.Label();
            this.input_discount = new System.Windows.Forms.TextBox();
            this.action_exit_update = new System.Windows.Forms.Button();
            this.action_update = new System.Windows.Forms.Button();
            this.lable_description = new System.Windows.Forms.Label();
            this.input_description = new System.Windows.Forms.TextBox();
            this.lable_duration_seconds = new System.Windows.Forms.Label();
            this.input_duration_seconds = new System.Windows.Forms.TextBox();
            this.lable_cost = new System.Windows.Forms.Label();
            this.input_cost = new System.Windows.Forms.TextBox();
            this.lable_title = new System.Windows.Forms.Label();
            this.input_title = new System.Windows.Forms.TextBox();
            this.lable_id = new System.Windows.Forms.Label();
            this.input_id = new System.Windows.Forms.TextBox();
            this.panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel_service.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.White;
            this.panel_header.Controls.Add(this.action_exit);
            this.panel_header.Controls.Add(this.header_service);
            this.panel_header.Controls.Add(this.logo);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(574, 66);
            this.panel_header.TabIndex = 2;
            // 
            // action_exit
            // 
            this.action_exit.BackColor = System.Drawing.Color.White;
            this.action_exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.action_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.action_exit.Font = new System.Drawing.Font("Roboto", 15.75F);
            this.action_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.action_exit.Location = new System.Drawing.Point(393, 12);
            this.action_exit.Name = "action_exit";
            this.action_exit.Size = new System.Drawing.Size(162, 42);
            this.action_exit.TabIndex = 13;
            this.action_exit.Text = "Выйти";
            this.action_exit.UseVisualStyleBackColor = false;
            this.action_exit.Click += new System.EventHandler(this.action_exit_Click);
            // 
            // header_service
            // 
            this.header_service.AutoSize = true;
            this.header_service.Font = new System.Drawing.Font("Roboto", 18.75F);
            this.header_service.Location = new System.Drawing.Point(94, 17);
            this.header_service.Name = "header_service";
            this.header_service.Size = new System.Drawing.Size(293, 30);
            this.header_service.TabIndex = 12;
            this.header_service.Text = "Редактирование услуги";
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
            // panel_service
            // 
            this.panel_service.AutoScroll = true;
            this.panel_service.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_service.BackColor = System.Drawing.Color.White;
            this.panel_service.Controls.Add(this.lable_main_image_path);
            this.panel_service.Controls.Add(this.input_main_image_path);
            this.panel_service.Controls.Add(this.lable_discount);
            this.panel_service.Controls.Add(this.input_discount);
            this.panel_service.Controls.Add(this.action_exit_update);
            this.panel_service.Controls.Add(this.action_update);
            this.panel_service.Controls.Add(this.lable_description);
            this.panel_service.Controls.Add(this.input_description);
            this.panel_service.Controls.Add(this.lable_duration_seconds);
            this.panel_service.Controls.Add(this.input_duration_seconds);
            this.panel_service.Controls.Add(this.lable_cost);
            this.panel_service.Controls.Add(this.input_cost);
            this.panel_service.Controls.Add(this.lable_title);
            this.panel_service.Controls.Add(this.input_title);
            this.panel_service.Controls.Add(this.lable_id);
            this.panel_service.Controls.Add(this.input_id);
            this.panel_service.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_service.Location = new System.Drawing.Point(0, 72);
            this.panel_service.Name = "panel_service";
            this.panel_service.Size = new System.Drawing.Size(574, 378);
            this.panel_service.TabIndex = 5;
            // 
            // lable_main_image_path
            // 
            this.lable_main_image_path.AutoSize = true;
            this.lable_main_image_path.Font = new System.Drawing.Font("Roboto", 10.75F);
            this.lable_main_image_path.Location = new System.Drawing.Point(304, 165);
            this.lable_main_image_path.Name = "lable_main_image_path";
            this.lable_main_image_path.Size = new System.Drawing.Size(137, 18);
            this.lable_main_image_path.TabIndex = 25;
            this.lable_main_image_path.Text = "Путь до картинки";
            // 
            // input_main_image_path
            // 
            this.input_main_image_path.Font = new System.Drawing.Font("Roboto", 15.75F);
            this.input_main_image_path.Location = new System.Drawing.Point(307, 186);
            this.input_main_image_path.Name = "input_main_image_path";
            this.input_main_image_path.Size = new System.Drawing.Size(232, 33);
            this.input_main_image_path.TabIndex = 24;
            // 
            // lable_discount
            // 
            this.lable_discount.AutoSize = true;
            this.lable_discount.Font = new System.Drawing.Font("Roboto", 10.75F);
            this.lable_discount.Location = new System.Drawing.Point(37, 165);
            this.lable_discount.Name = "lable_discount";
            this.lable_discount.Size = new System.Drawing.Size(59, 18);
            this.lable_discount.TabIndex = 23;
            this.lable_discount.Text = "Скидка";
            // 
            // input_discount
            // 
            this.input_discount.Font = new System.Drawing.Font("Roboto", 15.75F);
            this.input_discount.Location = new System.Drawing.Point(40, 186);
            this.input_discount.Name = "input_discount";
            this.input_discount.Size = new System.Drawing.Size(234, 33);
            this.input_discount.TabIndex = 22;
            // 
            // action_exit_update
            // 
            this.action_exit_update.BackColor = System.Drawing.Color.White;
            this.action_exit_update.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.action_exit_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.action_exit_update.Font = new System.Drawing.Font("Roboto", 15.75F);
            this.action_exit_update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.action_exit_update.Location = new System.Drawing.Point(62, 255);
            this.action_exit_update.Name = "action_exit_update";
            this.action_exit_update.Size = new System.Drawing.Size(212, 51);
            this.action_exit_update.TabIndex = 21;
            this.action_exit_update.Text = "Отмена";
            this.action_exit_update.UseVisualStyleBackColor = false;
            this.action_exit_update.Click += new System.EventHandler(this.action_exit_update_Click);
            // 
            // action_update
            // 
            this.action_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.action_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.action_update.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.action_update.ForeColor = System.Drawing.Color.White;
            this.action_update.Location = new System.Drawing.Point(307, 255);
            this.action_update.Name = "action_update";
            this.action_update.Size = new System.Drawing.Size(212, 52);
            this.action_update.TabIndex = 20;
            this.action_update.Text = "Сохранить";
            this.action_update.UseVisualStyleBackColor = false;
            this.action_update.Click += new System.EventHandler(this.action_update_Click);
            // 
            // lable_description
            // 
            this.lable_description.AutoSize = true;
            this.lable_description.Font = new System.Drawing.Font("Roboto", 10.75F);
            this.lable_description.Location = new System.Drawing.Point(304, 93);
            this.lable_description.Name = "lable_description";
            this.lable_description.Size = new System.Drawing.Size(78, 18);
            this.lable_description.TabIndex = 19;
            this.lable_description.Text = "Описание";
            // 
            // input_description
            // 
            this.input_description.Font = new System.Drawing.Font("Roboto", 15.75F);
            this.input_description.Location = new System.Drawing.Point(307, 114);
            this.input_description.Name = "input_description";
            this.input_description.Size = new System.Drawing.Size(232, 33);
            this.input_description.TabIndex = 18;
            // 
            // lable_duration_seconds
            // 
            this.lable_duration_seconds.AutoSize = true;
            this.lable_duration_seconds.Font = new System.Drawing.Font("Roboto", 10.75F);
            this.lable_duration_seconds.Location = new System.Drawing.Point(37, 93);
            this.lable_duration_seconds.Name = "lable_duration_seconds";
            this.lable_duration_seconds.Size = new System.Drawing.Size(151, 18);
            this.lable_duration_seconds.TabIndex = 17;
            this.lable_duration_seconds.Text = "Время работы (сек)";
            // 
            // input_duration_seconds
            // 
            this.input_duration_seconds.Font = new System.Drawing.Font("Roboto", 15.75F);
            this.input_duration_seconds.Location = new System.Drawing.Point(40, 114);
            this.input_duration_seconds.Name = "input_duration_seconds";
            this.input_duration_seconds.Size = new System.Drawing.Size(234, 33);
            this.input_duration_seconds.TabIndex = 16;
            // 
            // lable_cost
            // 
            this.lable_cost.AutoSize = true;
            this.lable_cost.Font = new System.Drawing.Font("Roboto", 10.75F);
            this.lable_cost.Location = new System.Drawing.Point(304, 9);
            this.lable_cost.Name = "lable_cost";
            this.lable_cost.Size = new System.Drawing.Size(83, 18);
            this.lable_cost.TabIndex = 15;
            this.lable_cost.Text = "Цена (руб)";
            // 
            // input_cost
            // 
            this.input_cost.Font = new System.Drawing.Font("Roboto", 15.75F);
            this.input_cost.Location = new System.Drawing.Point(307, 30);
            this.input_cost.Name = "input_cost";
            this.input_cost.Size = new System.Drawing.Size(232, 33);
            this.input_cost.TabIndex = 14;
            // 
            // lable_title
            // 
            this.lable_title.AutoSize = true;
            this.lable_title.Font = new System.Drawing.Font("Roboto", 10.75F);
            this.lable_title.Location = new System.Drawing.Point(37, 9);
            this.lable_title.Name = "lable_title";
            this.lable_title.Size = new System.Drawing.Size(116, 18);
            this.lable_title.TabIndex = 13;
            this.lable_title.Text = "Наименование";
            // 
            // input_title
            // 
            this.input_title.Font = new System.Drawing.Font("Roboto", 15.75F);
            this.input_title.Location = new System.Drawing.Point(40, 30);
            this.input_title.Name = "input_title";
            this.input_title.Size = new System.Drawing.Size(234, 33);
            this.input_title.TabIndex = 12;
            // 
            // lable_id
            // 
            this.lable_id.AutoSize = true;
            this.lable_id.Font = new System.Drawing.Font("Roboto", 10.75F);
            this.lable_id.Location = new System.Drawing.Point(9, 312);
            this.lable_id.Name = "lable_id";
            this.lable_id.Size = new System.Drawing.Size(21, 18);
            this.lable_id.TabIndex = 11;
            this.lable_id.Text = "id";
            this.lable_id.Visible = false;
            // 
            // input_id
            // 
            this.input_id.Font = new System.Drawing.Font("Roboto", 15.75F);
            this.input_id.Location = new System.Drawing.Point(30, 333);
            this.input_id.Name = "input_id";
            this.input_id.Size = new System.Drawing.Size(100, 33);
            this.input_id.TabIndex = 10;
            this.input_id.Visible = false;
            // 
            // UpdateService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 450);
            this.Controls.Add(this.panel_service);
            this.Controls.Add(this.panel_header);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateService";
            this.Text = "Рндактирование услуги";
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel_service.ResumeLayout(false);
            this.panel_service.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Button action_exit;
        private System.Windows.Forms.Label header_service;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel panel_service;
        private System.Windows.Forms.Label lable_description;
        private System.Windows.Forms.TextBox input_description;
        private System.Windows.Forms.Label lable_duration_seconds;
        private System.Windows.Forms.TextBox input_duration_seconds;
        private System.Windows.Forms.Label lable_cost;
        private System.Windows.Forms.TextBox input_cost;
        private System.Windows.Forms.Label lable_title;
        private System.Windows.Forms.TextBox input_title;
        private System.Windows.Forms.Label lable_id;
        private System.Windows.Forms.TextBox input_id;
        private System.Windows.Forms.Button action_update;
        private System.Windows.Forms.Button action_exit_update;
        private System.Windows.Forms.Label lable_main_image_path;
        private System.Windows.Forms.TextBox input_main_image_path;
        private System.Windows.Forms.Label lable_discount;
        private System.Windows.Forms.TextBox input_discount;
    }
}