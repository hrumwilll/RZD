namespace WindowsFormsApp1
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.btnRouteList = new System.Windows.Forms.Button();
            this.btnListTrains = new System.Windows.Forms.Button();
            this.btnTrains = new System.Windows.Forms.Button();
            this.btnConductors = new System.Windows.Forms.Button();
            this.btnTrainsmaster = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnRouteList);
            this.panelMenu.Controls.Add(this.btnListTrains);
            this.panelMenu.Controls.Add(this.btnTrains);
            this.panelMenu.Controls.Add(this.btnConductors);
            this.panelMenu.Controls.Add(this.btnTrainsmaster);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 637);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.Red;
            this.panelTitleBar.Controls.Add(this.btnCloseChildForm);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(250, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1120, 80);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitle_Paint);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(506, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(130, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Главная";
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel.Location = new System.Drawing.Point(250, 80);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(1120, 557);
            this.panelDesktopPanel.TabIndex = 2;
            this.panelDesktopPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktopPanel_Paint);
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Image = global::WindowsFormsApp1.Properties.Resources.exit;
            this.btnCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(75, 80);
            this.btnCloseChildForm.TabIndex = 1;
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            // 
            // btnRouteList
            // 
            this.btnRouteList.AutoSize = true;
            this.btnRouteList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRouteList.FlatAppearance.BorderSize = 0;
            this.btnRouteList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRouteList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRouteList.ForeColor = System.Drawing.Color.White;
            this.btnRouteList.Image = global::WindowsFormsApp1.Properties.Resources.routelist;
            this.btnRouteList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRouteList.Location = new System.Drawing.Point(0, 340);
            this.btnRouteList.Name = "btnRouteList";
            this.btnRouteList.Size = new System.Drawing.Size(250, 65);
            this.btnRouteList.TabIndex = 5;
            this.btnRouteList.Text = "Маршрутный лист";
            this.btnRouteList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRouteList.UseVisualStyleBackColor = true;
            this.btnRouteList.Click += new System.EventHandler(this.btnRouteList_Click);
            // 
            // btnListTrains
            // 
            this.btnListTrains.AutoSize = true;
            this.btnListTrains.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListTrains.FlatAppearance.BorderSize = 0;
            this.btnListTrains.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListTrains.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnListTrains.ForeColor = System.Drawing.Color.White;
            this.btnListTrains.Image = global::WindowsFormsApp1.Properties.Resources.listtrains;
            this.btnListTrains.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListTrains.Location = new System.Drawing.Point(0, 270);
            this.btnListTrains.Name = "btnListTrains";
            this.btnListTrains.Size = new System.Drawing.Size(250, 70);
            this.btnListTrains.TabIndex = 4;
            this.btnListTrains.Text = "Расписание поездов";
            this.btnListTrains.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListTrains.UseVisualStyleBackColor = true;
            this.btnListTrains.Click += new System.EventHandler(this.btnListTrains_Click);
            // 
            // btnTrains
            // 
            this.btnTrains.AutoSize = true;
            this.btnTrains.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTrains.FlatAppearance.BorderSize = 0;
            this.btnTrains.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrains.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTrains.ForeColor = System.Drawing.Color.White;
            this.btnTrains.Image = global::WindowsFormsApp1.Properties.Resources.trains;
            this.btnTrains.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrains.Location = new System.Drawing.Point(0, 210);
            this.btnTrains.Name = "btnTrains";
            this.btnTrains.Size = new System.Drawing.Size(250, 60);
            this.btnTrains.TabIndex = 3;
            this.btnTrains.Text = "Поезда";
            this.btnTrains.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTrains.UseVisualStyleBackColor = true;
            this.btnTrains.Click += new System.EventHandler(this.btnTrains_Click);
            // 
            // btnConductors
            // 
            this.btnConductors.AutoSize = true;
            this.btnConductors.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConductors.FlatAppearance.BorderSize = 0;
            this.btnConductors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConductors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConductors.ForeColor = System.Drawing.Color.White;
            this.btnConductors.Image = global::WindowsFormsApp1.Properties.Resources.conductors;
            this.btnConductors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConductors.Location = new System.Drawing.Point(0, 150);
            this.btnConductors.Name = "btnConductors";
            this.btnConductors.Size = new System.Drawing.Size(250, 60);
            this.btnConductors.TabIndex = 2;
            this.btnConductors.Text = "Проводники";
            this.btnConductors.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConductors.UseVisualStyleBackColor = true;
            this.btnConductors.Click += new System.EventHandler(this.btnConductors_Click);
            // 
            // btnTrainsmaster
            // 
            this.btnTrainsmaster.AutoSize = true;
            this.btnTrainsmaster.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTrainsmaster.FlatAppearance.BorderSize = 0;
            this.btnTrainsmaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrainsmaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTrainsmaster.ForeColor = System.Drawing.Color.White;
            this.btnTrainsmaster.Image = global::WindowsFormsApp1.Properties.Resources.trainmaster1;
            this.btnTrainsmaster.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrainsmaster.Location = new System.Drawing.Point(0, 80);
            this.btnTrainsmaster.Name = "btnTrainsmaster";
            this.btnTrainsmaster.Size = new System.Drawing.Size(250, 70);
            this.btnTrainsmaster.TabIndex = 1;
            this.btnTrainsmaster.Text = "Начальники поездов";
            this.btnTrainsmaster.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTrainsmaster.UseVisualStyleBackColor = true;
            this.btnTrainsmaster.Click += new System.EventHandler(this.btnTrainsmaster_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.logo;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 637);
            this.Controls.Add(this.panelDesktopPanel);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "РЖД Нарядчики";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnTrainsmaster;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnListTrains;
        private System.Windows.Forms.Button btnTrains;
        private System.Windows.Forms.Button btnConductors;
        private System.Windows.Forms.Button btnRouteList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelDesktopPanel;
        private System.Windows.Forms.Button btnCloseChildForm;
    }
}