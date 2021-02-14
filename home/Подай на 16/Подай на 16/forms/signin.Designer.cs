namespace Подай_на_16.forms
{
    partial class signin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signin));
            this.panel_signin = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_header = new System.Windows.Forms.Label();
            this.label_body = new System.Windows.Forms.Label();
            this.label_login = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.input_password = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.buttomadminMode = new System.Windows.Forms.Button();
            this.buttonClientMode = new System.Windows.Forms.Button();
            this.panel_signin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_signin
            // 
            this.panel_signin.BackColor = System.Drawing.Color.White;
            this.panel_signin.Controls.Add(this.buttomadminMode);
            this.panel_signin.Controls.Add(this.buttonClientMode);
            this.panel_signin.Controls.Add(this.input_password);
            this.panel_signin.Controls.Add(this.label_password);
            this.panel_signin.Controls.Add(this.textBox1);
            this.panel_signin.Controls.Add(this.label_login);
            this.panel_signin.Controls.Add(this.label_body);
            this.panel_signin.Controls.Add(this.label_header);
            this.panel_signin.Controls.Add(this.pictureBox1);
            this.panel_signin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_signin.Location = new System.Drawing.Point(0, 0);
            this.panel_signin.Name = "panel_signin";
            this.panel_signin.Size = new System.Drawing.Size(366, 344);
            this.panel_signin.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Подай_на_16.Properties.Resources.service_logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label_header
            // 
            this.label_header.AutoSize = true;
            this.label_header.Font = new System.Drawing.Font("Roboto Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_header.Location = new System.Drawing.Point(58, 12);
            this.label_header.Name = "label_header";
            this.label_header.Size = new System.Drawing.Size(194, 33);
            this.label_header.TabIndex = 5;
            this.label_header.Text = "Авторизация";
            // 
            // label_body
            // 
            this.label_body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_body.AutoSize = true;
            this.label_body.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_body.Location = new System.Drawing.Point(12, 69);
            this.label_body.Name = "label_body";
            this.label_body.Size = new System.Drawing.Size(335, 25);
            this.label_body.TabIndex = 6;
            this.label_body.Text = "Здравствуйте, войдите в аккаунт";
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_login.Location = new System.Drawing.Point(13, 139);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(54, 19);
            this.label_login.TabIndex = 9;
            this.label_login.Text = "Логин";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 161);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(335, 27);
            this.textBox1.TabIndex = 12;
            // 
            // input_password
            // 
            this.input_password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.input_password.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.input_password.Location = new System.Drawing.Point(12, 230);
            this.input_password.Name = "input_password";
            this.input_password.Size = new System.Drawing.Size(335, 27);
            this.input_password.TabIndex = 14;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_password.Location = new System.Drawing.Point(13, 208);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(65, 19);
            this.label_password.TabIndex = 13;
            this.label_password.Text = "Пароль";
            // 
            // buttomadminMode
            // 
            this.buttomadminMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttomadminMode.BackColor = System.Drawing.Color.White;
            this.buttomadminMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttomadminMode.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttomadminMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.buttomadminMode.Location = new System.Drawing.Point(182, 287);
            this.buttomadminMode.Name = "buttomadminMode";
            this.buttomadminMode.Size = new System.Drawing.Size(165, 40);
            this.buttomadminMode.TabIndex = 16;
            this.buttomadminMode.Text = "Администратор";
            this.buttomadminMode.UseVisualStyleBackColor = false;
            // 
            // buttonClientMode
            // 
            this.buttonClientMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonClientMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.buttonClientMode.FlatAppearance.BorderSize = 0;
            this.buttonClientMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClientMode.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClientMode.ForeColor = System.Drawing.Color.White;
            this.buttonClientMode.Location = new System.Drawing.Point(17, 287);
            this.buttonClientMode.Name = "buttonClientMode";
            this.buttonClientMode.Size = new System.Drawing.Size(159, 40);
            this.buttonClientMode.TabIndex = 15;
            this.buttonClientMode.Text = "Клиент";
            this.buttonClientMode.UseVisualStyleBackColor = false;
            // 
            // signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 344);
            this.Controls.Add(this.panel_signin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(382, 382);
            this.Name = "signin";
            this.Text = "Авторизация";
            this.panel_signin.ResumeLayout(false);
            this.panel_signin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_signin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_header;
        private System.Windows.Forms.Label label_body;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.TextBox input_password;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttomadminMode;
        private System.Windows.Forms.Button buttonClientMode;
    }
}