namespace Подай_на_16
{
    partial class signin
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signin));
            this.panel_signin = new System.Windows.Forms.Panel();
            this.header_signin = new System.Windows.Forms.Label();
            this.label_signin = new System.Windows.Forms.Label();
            this.input_code = new System.Windows.Forms.TextBox();
            this.action_client_mode = new System.Windows.Forms.Button();
            this.action_admin_mode = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_signin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_signin
            // 
            this.panel_signin.BackColor = System.Drawing.Color.White;
            this.panel_signin.Controls.Add(this.pictureBox1);
            this.panel_signin.Controls.Add(this.header_signin);
            this.panel_signin.Controls.Add(this.label_signin);
            this.panel_signin.Controls.Add(this.input_code);
            this.panel_signin.Controls.Add(this.action_client_mode);
            this.panel_signin.Controls.Add(this.action_admin_mode);
            this.panel_signin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_signin.Location = new System.Drawing.Point(0, 0);
            this.panel_signin.Name = "panel_signin";
            this.panel_signin.Size = new System.Drawing.Size(530, 345);
            this.panel_signin.TabIndex = 3;
            // 
            // header_signin
            // 
            this.header_signin.AutoSize = true;
            this.header_signin.Font = new System.Drawing.Font("Roboto", 18.75F);
            this.header_signin.Location = new System.Drawing.Point(114, 12);
            this.header_signin.Name = "header_signin";
            this.header_signin.Size = new System.Drawing.Size(189, 30);
            this.header_signin.TabIndex = 11;
            this.header_signin.Text = "Выбор режима";
            // 
            // label_signin
            // 
            this.label_signin.AutoSize = true;
            this.label_signin.Font = new System.Drawing.Font("Roboto", 10.75F);
            this.label_signin.Location = new System.Drawing.Point(24, 133);
            this.label_signin.Name = "label_signin";
            this.label_signin.Size = new System.Drawing.Size(99, 18);
            this.label_signin.TabIndex = 10;
            this.label_signin.Text = "Введите код";
            // 
            // input_code
            // 
            this.input_code.Font = new System.Drawing.Font("Roboto", 15.75F);
            this.input_code.Location = new System.Drawing.Point(27, 154);
            this.input_code.Name = "input_code";
            this.input_code.Size = new System.Drawing.Size(478, 33);
            this.input_code.TabIndex = 7;
            // 
            // action_client_mode
            // 
            this.action_client_mode.BackColor = System.Drawing.Color.White;
            this.action_client_mode.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.action_client_mode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.action_client_mode.Font = new System.Drawing.Font("Roboto", 15.75F);
            this.action_client_mode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.action_client_mode.Location = new System.Drawing.Point(27, 222);
            this.action_client_mode.Name = "action_client_mode";
            this.action_client_mode.Size = new System.Drawing.Size(232, 51);
            this.action_client_mode.TabIndex = 6;
            this.action_client_mode.Text = "Клиентский";
            this.action_client_mode.UseVisualStyleBackColor = false;
            this.action_client_mode.Click += new System.EventHandler(this.action_client_mode_Click);
            // 
            // action_admin_mode
            // 
            this.action_admin_mode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.action_admin_mode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.action_admin_mode.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.action_admin_mode.ForeColor = System.Drawing.Color.White;
            this.action_admin_mode.Location = new System.Drawing.Point(265, 222);
            this.action_admin_mode.Name = "action_admin_mode";
            this.action_admin_mode.Size = new System.Drawing.Size(240, 51);
            this.action_admin_mode.TabIndex = 5;
            this.action_admin_mode.Text = "Администратор";
            this.action_admin_mode.UseVisualStyleBackColor = false;
            this.action_admin_mode.Click += new System.EventHandler(this.action_admin_mode_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Подай_на_16.Properties.Resources.service_logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 345);
            this.Controls.Add(this.panel_signin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "signin";
            this.Text = "Ввбор режима";
            this.panel_signin.ResumeLayout(false);
            this.panel_signin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_signin;
        private System.Windows.Forms.TextBox input_code;
        private System.Windows.Forms.Button action_client_mode;
        private System.Windows.Forms.Button action_admin_mode;
        private System.Windows.Forms.Label label_signin;
        private System.Windows.Forms.Label header_signin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

