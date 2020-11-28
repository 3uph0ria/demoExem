namespace Подай_на_16
{
    partial class Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.panel_header = new System.Windows.Forms.Panel();
            this.action_exit = new System.Windows.Forms.Button();
            this.header_service = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panel_service = new System.Windows.Forms.Panel();
            this.panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
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
            this.panel_header.Size = new System.Drawing.Size(800, 66);
            this.panel_header.TabIndex = 0;
            this.panel_header.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_header_Paint);
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
            this.action_exit.Click += new System.EventHandler(this.action_exit_Click);
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
            this.panel_service.TabIndex = 3;
            this.panel_service.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_service_Paint);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_service);
            this.Controls.Add(this.panel_header);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Client";
            this.Text = "Наши услуги";
            this.Load += new System.EventHandler(this.Client_Load_1);
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label header_service;
        private System.Windows.Forms.Panel panel_service;
        private System.Windows.Forms.Button action_exit;
    }
}