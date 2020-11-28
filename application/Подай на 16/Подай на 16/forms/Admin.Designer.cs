namespace Подай_на_16.forms
{
    partial class Admin
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
            this.panel_header = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.action_exit = new System.Windows.Forms.Button();
            this.header_service = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panel_service = new System.Windows.Forms.Panel();
            this.action_add_service = new System.Windows.Forms.Button();
            this.panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.White;
            this.panel_header.Controls.Add(this.action_add_service);
            this.panel_header.Controls.Add(this.button1);
            this.panel_header.Controls.Add(this.action_exit);
            this.panel_header.Controls.Add(this.header_service);
            this.panel_header.Controls.Add(this.logo);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(800, 66);
            this.panel_header.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(457, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 42);
            this.button1.TabIndex = 14;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // action_exit
            // 
            this.action_exit.BackColor = System.Drawing.Color.White;
            this.action_exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.action_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.action_exit.Font = new System.Drawing.Font("Roboto", 15.75F);
            this.action_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.action_exit.Location = new System.Drawing.Point(626, 12);
            this.action_exit.Name = "action_exit";
            this.action_exit.Size = new System.Drawing.Size(162, 42);
            this.action_exit.TabIndex = 13;
            this.action_exit.Text = "Выйти";
            this.action_exit.UseVisualStyleBackColor = false;
            this.action_exit.Click += new System.EventHandler(this.action_exit_Click_1);
            // 
            // header_service
            // 
            this.header_service.AutoSize = true;
            this.header_service.Font = new System.Drawing.Font("Roboto", 18.75F);
            this.header_service.Location = new System.Drawing.Point(94, 17);
            this.header_service.Name = "header_service";
            this.header_service.Size = new System.Drawing.Size(162, 30);
            this.header_service.TabIndex = 12;
            this.header_service.Text = "Наши услуги";
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
            this.panel_service.BackColor = System.Drawing.Color.White;
            this.panel_service.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_service.Location = new System.Drawing.Point(0, 72);
            this.panel_service.Name = "panel_service";
            this.panel_service.Size = new System.Drawing.Size(800, 378);
            this.panel_service.TabIndex = 4;
            // 
            // action_add_service
            // 
            this.action_add_service.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.action_add_service.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.action_add_service.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.action_add_service.ForeColor = System.Drawing.Color.White;
            this.action_add_service.Location = new System.Drawing.Point(288, 12);
            this.action_add_service.Name = "action_add_service";
            this.action_add_service.Size = new System.Drawing.Size(163, 42);
            this.action_add_service.TabIndex = 15;
            this.action_add_service.Text = "Добавить";
            this.action_add_service.UseVisualStyleBackColor = false;
            this.action_add_service.Click += new System.EventHandler(this.action_add_service_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_service);
            this.Controls.Add(this.panel_header);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Button action_exit;
        private System.Windows.Forms.Label header_service;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel panel_service;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button action_add_service;
    }
}