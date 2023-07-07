namespace РЖД_Нарядчики
{
    partial class Login
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
            this.panelLogin = new System.Windows.Forms.Panel();
            this.labelWarning = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textPass = new System.Windows.Forms.TextBox();
            this.textLogin = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.labelEnter = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureLogin = new System.Windows.Forms.PictureBox();
            this.buttonCloseLogin = new System.Windows.Forms.Button();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.labelWarning);
            this.panelLogin.Controls.Add(this.buttonLogin);
            this.panelLogin.Controls.Add(this.textPass);
            this.panelLogin.Controls.Add(this.textLogin);
            this.panelLogin.Controls.Add(this.labelLogin);
            this.panelLogin.Controls.Add(this.labelPass);
            this.panelLogin.Controls.Add(this.labelEnter);
            this.panelLogin.Controls.Add(this.panel1);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogin.Location = new System.Drawing.Point(0, 299);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(735, 430);
            this.panelLogin.TabIndex = 1;
            // 
            // labelWarning
            // 
            this.labelWarning.AutoSize = true;
            this.labelWarning.Location = new System.Drawing.Point(38, 385);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(448, 13);
            this.labelWarning.TabIndex = 6;
            this.labelWarning.Text = "*Введите логин и пароль, которые получили от системного администратора кампании";
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Red;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(302, 289);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(105, 51);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Войти";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textPass
            // 
            this.textPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textPass.Location = new System.Drawing.Point(219, 238);
            this.textPass.Name = "textPass";
            this.textPass.Size = new System.Drawing.Size(280, 38);
            this.textPass.TabIndex = 4;
            this.textPass.UseSystemPasswordChar = true;
            // 
            // textLogin
            // 
            this.textLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textLogin.Location = new System.Drawing.Point(219, 132);
            this.textLogin.Multiline = true;
            this.textLogin.Name = "textLogin";
            this.textLogin.Size = new System.Drawing.Size(280, 38);
            this.textLogin.TabIndex = 3;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(195, 92);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(98, 37);
            this.labelLogin.TabIndex = 2;
            this.labelLogin.Text = "Логин";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPass.Location = new System.Drawing.Point(195, 186);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(124, 37);
            this.labelPass.TabIndex = 1;
            this.labelPass.Text = "Пароль";
            // 
            // labelEnter
            // 
            this.labelEnter.AutoSize = true;
            this.labelEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEnter.Location = new System.Drawing.Point(310, 30);
            this.labelEnter.Name = "labelEnter";
            this.labelEnter.Size = new System.Drawing.Size(88, 37);
            this.labelEnter.TabIndex = 0;
            this.labelEnter.Text = "Вход";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(186, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 340);
            this.panel1.TabIndex = 7;
            // 
            // pictureLogin
            // 
            this.pictureLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureLogin.Image = global::РЖД_Нарядчики.Properties.Resources.bootwindow;
            this.pictureLogin.Location = new System.Drawing.Point(0, 0);
            this.pictureLogin.Name = "pictureLogin";
            this.pictureLogin.Size = new System.Drawing.Size(735, 299);
            this.pictureLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLogin.TabIndex = 0;
            this.pictureLogin.TabStop = false;
            // 
            // buttonCloseLogin
            // 
            this.buttonCloseLogin.FlatAppearance.BorderSize = 0;
            this.buttonCloseLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseLogin.Image = global::РЖД_Нарядчики.Properties.Resources.exit;
            this.buttonCloseLogin.Location = new System.Drawing.Point(684, 12);
            this.buttonCloseLogin.Name = "buttonCloseLogin";
            this.buttonCloseLogin.Size = new System.Drawing.Size(39, 38);
            this.buttonCloseLogin.TabIndex = 2;
            this.buttonCloseLogin.UseVisualStyleBackColor = true;
            this.buttonCloseLogin.Click += new System.EventHandler(this.buttonCloseLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 729);
            this.Controls.Add(this.buttonCloseLogin);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.pictureLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureLogin;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label labelEnter;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.TextBox textLogin;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelWarning;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCloseLogin;
    }
}