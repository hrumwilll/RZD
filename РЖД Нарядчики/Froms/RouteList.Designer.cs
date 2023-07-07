namespace РЖД_Нарядчики.Froms
{
    partial class RouteList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RouteList));
            this.dataBaseRZDDataSet = new РЖД_Нарядчики.DataBaseRZDDataSet();
            this.conductorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conductorsTableAdapter = new РЖД_Нарядчики.DataBaseRZDDataSetTableAdapters.conductorsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.comboNumber = new System.Windows.Forms.ComboBox();
            this.listTrainsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseRZDDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listTrainsTableAdapter = new РЖД_Нарядчики.DataBaseRZDDataSetTableAdapters.listTrainsTableAdapter();
            this.trainMasterTableAdapter = new РЖД_Нарядчики.DataBaseRZDDataSetTableAdapters.TrainMasterTableAdapter();
            this.conductorsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBoxTabel = new System.Windows.Forms.ComboBox();
            this.comboBoxSurname = new System.Windows.Forms.ComboBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox25 = new System.Windows.Forms.ComboBox();
            this.conductorsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.comboSurname4 = new System.Windows.Forms.ComboBox();
            this.comboBox21 = new System.Windows.Forms.ComboBox();
            this.conductorsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxSurname3 = new System.Windows.Forms.ComboBox();
            this.comboBox17 = new System.Windows.Forms.ComboBox();
            this.comboBoxSurname2 = new System.Windows.Forms.ComboBox();
            this.comboBox14 = new System.Windows.Forms.ComboBox();
            this.comboBoxSurname1 = new System.Windows.Forms.ComboBox();
            this.comboBox22 = new System.Windows.Forms.ComboBox();
            this.comboBoxTabel4 = new System.Windows.Forms.ComboBox();
            this.comboBox18 = new System.Windows.Forms.ComboBox();
            this.comboBoxTabel3 = new System.Windows.Forms.ComboBox();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.comboBoxTabel2 = new System.Windows.Forms.ComboBox();
            this.comboBox11 = new System.Windows.Forms.ComboBox();
            this.comboBoxTabel1 = new System.Windows.Forms.ComboBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseRZDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conductorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listTrainsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseRZDDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conductorsBindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conductorsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conductorsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataBaseRZDDataSet
            // 
            this.dataBaseRZDDataSet.DataSetName = "DataBaseRZDDataSet";
            this.dataBaseRZDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // conductorsBindingSource
            // 
            this.conductorsBindingSource.DataMember = "conductors";
            this.conductorsBindingSource.DataSource = this.dataBaseRZDDataSet;
            // 
            // conductorsTableAdapter
            // 
            this.conductorsTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Маршрутный лист";
            // 
            // comboNumber
            // 
            this.comboNumber.DataSource = this.listTrainsBindingSource;
            this.comboNumber.DisplayMember = "number";
            this.comboNumber.FormattingEnabled = true;
            this.comboNumber.Location = new System.Drawing.Point(6, 44);
            this.comboNumber.Name = "comboNumber";
            this.comboNumber.Size = new System.Drawing.Size(70, 33);
            this.comboNumber.TabIndex = 3;
            // 
            // listTrainsBindingSource
            // 
            this.listTrainsBindingSource.DataMember = "listTrains";
            this.listTrainsBindingSource.DataSource = this.dataBaseRZDDataSetBindingSource;
            // 
            // dataBaseRZDDataSetBindingSource
            // 
            this.dataBaseRZDDataSetBindingSource.DataSource = this.dataBaseRZDDataSet;
            this.dataBaseRZDDataSetBindingSource.Position = 0;
            // 
            // trainMasterBindingSource
            // 
            this.trainMasterBindingSource.DataMember = "TrainMaster";
            this.trainMasterBindingSource.DataSource = this.dataBaseRZDDataSetBindingSource;
            // 
            // listTrainsTableAdapter
            // 
            this.listTrainsTableAdapter.ClearBeforeFill = true;
            // 
            // trainMasterTableAdapter
            // 
            this.trainMasterTableAdapter.ClearBeforeFill = true;
            // 
            // conductorsBindingSource1
            // 
            this.conductorsBindingSource1.DataMember = "conductors";
            this.conductorsBindingSource1.DataSource = this.dataBaseRZDDataSetBindingSource;
            // 
            // comboBoxName
            // 
            this.comboBoxName.DataSource = this.listTrainsBindingSource;
            this.comboBoxName.DisplayMember = "name";
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(82, 44);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(190, 33);
            this.comboBoxName.TabIndex = 7;
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.listTrainsBindingSource;
            this.comboBox4.DisplayMember = "dataStart";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(429, 44);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(145, 33);
            this.comboBox4.TabIndex = 8;
            // 
            // comboBox5
            // 
            this.comboBox5.DataSource = this.listTrainsBindingSource;
            this.comboBox5.DisplayMember = "dataEnd";
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(278, 44);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(145, 33);
            this.comboBox5.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboNumber);
            this.groupBox1.Controls.Add(this.comboBox5);
            this.groupBox1.Controls.Add(this.comboBoxName);
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 98);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Рейс";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox9);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.comboBoxTabel);
            this.groupBox2.Controls.Add(this.comboBoxSurname);
            this.groupBox2.Controls.Add(this.comboBox8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(580, 178);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Начальник поезда";
            // 
            // comboBox9
            // 
            this.comboBox9.DataSource = this.trainMasterBindingSource;
            this.comboBox9.DisplayMember = "razrad";
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Location = new System.Drawing.Point(190, 96);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(118, 33);
            this.comboBox9.TabIndex = 10;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.trainMasterBindingSource;
            this.comboBox2.DisplayMember = "name";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(6, 44);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(178, 33);
            this.comboBox2.TabIndex = 3;
            // 
            // comboBoxTabel
            // 
            this.comboBoxTabel.DataSource = this.trainMasterBindingSource;
            this.comboBoxTabel.DisplayMember = "table_number";
            this.comboBoxTabel.FormattingEnabled = true;
            this.comboBoxTabel.Location = new System.Drawing.Point(6, 96);
            this.comboBoxTabel.Name = "comboBoxTabel";
            this.comboBoxTabel.Size = new System.Drawing.Size(178, 33);
            this.comboBoxTabel.TabIndex = 9;
            // 
            // comboBoxSurname
            // 
            this.comboBoxSurname.DataSource = this.trainMasterBindingSource;
            this.comboBoxSurname.DisplayMember = "surname";
            this.comboBoxSurname.FormattingEnabled = true;
            this.comboBoxSurname.Location = new System.Drawing.Point(190, 44);
            this.comboBoxSurname.Name = "comboBoxSurname";
            this.comboBoxSurname.Size = new System.Drawing.Size(178, 33);
            this.comboBoxSurname.TabIndex = 7;
            // 
            // comboBox8
            // 
            this.comboBox8.DataSource = this.trainMasterBindingSource;
            this.comboBox8.DisplayMember = "patronymic";
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(374, 44);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(178, 33);
            this.comboBox8.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox25);
            this.groupBox3.Controls.Add(this.comboSurname4);
            this.groupBox3.Controls.Add(this.comboBox21);
            this.groupBox3.Controls.Add(this.comboBoxSurname3);
            this.groupBox3.Controls.Add(this.comboBox17);
            this.groupBox3.Controls.Add(this.comboBoxSurname2);
            this.groupBox3.Controls.Add(this.comboBox14);
            this.groupBox3.Controls.Add(this.comboBoxSurname1);
            this.groupBox3.Controls.Add(this.comboBox22);
            this.groupBox3.Controls.Add(this.comboBoxTabel4);
            this.groupBox3.Controls.Add(this.comboBox18);
            this.groupBox3.Controls.Add(this.comboBoxTabel3);
            this.groupBox3.Controls.Add(this.comboBox10);
            this.groupBox3.Controls.Add(this.comboBoxTabel2);
            this.groupBox3.Controls.Add(this.comboBox11);
            this.groupBox3.Controls.Add(this.comboBoxTabel1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(12, 350);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(580, 388);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Проводники";
            // 
            // comboBox25
            // 
            this.comboBox25.DataSource = this.conductorsBindingSource3;
            this.comboBox25.DisplayMember = "patronymic";
            this.comboBox25.FormattingEnabled = true;
            this.comboBox25.Location = new System.Drawing.Point(374, 304);
            this.comboBox25.Name = "comboBox25";
            this.comboBox25.Size = new System.Drawing.Size(178, 33);
            this.comboBox25.TabIndex = 29;
            // 
            // conductorsBindingSource3
            // 
            this.conductorsBindingSource3.DataMember = "conductors";
            this.conductorsBindingSource3.DataSource = this.dataBaseRZDDataSetBindingSource;
            // 
            // comboSurname4
            // 
            this.comboSurname4.DataSource = this.conductorsBindingSource3;
            this.comboSurname4.DisplayMember = "surname";
            this.comboSurname4.FormattingEnabled = true;
            this.comboSurname4.Location = new System.Drawing.Point(190, 304);
            this.comboSurname4.Name = "comboSurname4";
            this.comboSurname4.Size = new System.Drawing.Size(178, 33);
            this.comboSurname4.TabIndex = 28;
            // 
            // comboBox21
            // 
            this.comboBox21.DataSource = this.conductorsBindingSource2;
            this.comboBox21.DisplayMember = "patronymic";
            this.comboBox21.FormattingEnabled = true;
            this.comboBox21.Location = new System.Drawing.Point(374, 217);
            this.comboBox21.Name = "comboBox21";
            this.comboBox21.Size = new System.Drawing.Size(178, 33);
            this.comboBox21.TabIndex = 27;
            // 
            // conductorsBindingSource2
            // 
            this.conductorsBindingSource2.DataMember = "conductors";
            this.conductorsBindingSource2.DataSource = this.dataBaseRZDDataSetBindingSource;
            // 
            // comboBoxSurname3
            // 
            this.comboBoxSurname3.DataSource = this.conductorsBindingSource2;
            this.comboBoxSurname3.DisplayMember = "surname";
            this.comboBoxSurname3.FormattingEnabled = true;
            this.comboBoxSurname3.Location = new System.Drawing.Point(190, 217);
            this.comboBoxSurname3.Name = "comboBoxSurname3";
            this.comboBoxSurname3.Size = new System.Drawing.Size(178, 33);
            this.comboBoxSurname3.TabIndex = 26;
            // 
            // comboBox17
            // 
            this.comboBox17.DataSource = this.conductorsBindingSource1;
            this.comboBox17.DisplayMember = "patronymic";
            this.comboBox17.FormattingEnabled = true;
            this.comboBox17.Location = new System.Drawing.Point(374, 130);
            this.comboBox17.Name = "comboBox17";
            this.comboBox17.Size = new System.Drawing.Size(178, 33);
            this.comboBox17.TabIndex = 25;
            // 
            // comboBoxSurname2
            // 
            this.comboBoxSurname2.DataSource = this.conductorsBindingSource1;
            this.comboBoxSurname2.DisplayMember = "surname";
            this.comboBoxSurname2.FormattingEnabled = true;
            this.comboBoxSurname2.Location = new System.Drawing.Point(190, 130);
            this.comboBoxSurname2.Name = "comboBoxSurname2";
            this.comboBoxSurname2.Size = new System.Drawing.Size(178, 33);
            this.comboBoxSurname2.TabIndex = 24;
            // 
            // comboBox14
            // 
            this.comboBox14.DataSource = this.conductorsBindingSource;
            this.comboBox14.DisplayMember = "patronymic";
            this.comboBox14.FormattingEnabled = true;
            this.comboBox14.Location = new System.Drawing.Point(374, 44);
            this.comboBox14.Name = "comboBox14";
            this.comboBox14.Size = new System.Drawing.Size(178, 33);
            this.comboBox14.TabIndex = 23;
            // 
            // comboBoxSurname1
            // 
            this.comboBoxSurname1.DataSource = this.conductorsBindingSource;
            this.comboBoxSurname1.DisplayMember = "surname";
            this.comboBoxSurname1.FormattingEnabled = true;
            this.comboBoxSurname1.Location = new System.Drawing.Point(190, 44);
            this.comboBoxSurname1.Name = "comboBoxSurname1";
            this.comboBoxSurname1.Size = new System.Drawing.Size(178, 33);
            this.comboBoxSurname1.TabIndex = 22;
            // 
            // comboBox22
            // 
            this.comboBox22.DataSource = this.conductorsBindingSource3;
            this.comboBox22.DisplayMember = "name";
            this.comboBox22.FormattingEnabled = true;
            this.comboBox22.Location = new System.Drawing.Point(6, 304);
            this.comboBox22.Name = "comboBox22";
            this.comboBox22.Size = new System.Drawing.Size(178, 33);
            this.comboBox22.TabIndex = 18;
            // 
            // comboBoxTabel4
            // 
            this.comboBoxTabel4.DataSource = this.conductorsBindingSource3;
            this.comboBoxTabel4.DisplayMember = "table_number";
            this.comboBoxTabel4.FormattingEnabled = true;
            this.comboBoxTabel4.Location = new System.Drawing.Point(6, 343);
            this.comboBoxTabel4.Name = "comboBoxTabel4";
            this.comboBoxTabel4.Size = new System.Drawing.Size(158, 33);
            this.comboBoxTabel4.TabIndex = 21;
            // 
            // comboBox18
            // 
            this.comboBox18.DataSource = this.conductorsBindingSource2;
            this.comboBox18.DisplayMember = "name";
            this.comboBox18.FormattingEnabled = true;
            this.comboBox18.Location = new System.Drawing.Point(6, 217);
            this.comboBox18.Name = "comboBox18";
            this.comboBox18.Size = new System.Drawing.Size(178, 33);
            this.comboBox18.TabIndex = 14;
            // 
            // comboBoxTabel3
            // 
            this.comboBoxTabel3.DataSource = this.conductorsBindingSource2;
            this.comboBoxTabel3.DisplayMember = "table_number";
            this.comboBoxTabel3.FormattingEnabled = true;
            this.comboBoxTabel3.Location = new System.Drawing.Point(6, 256);
            this.comboBoxTabel3.Name = "comboBoxTabel3";
            this.comboBoxTabel3.Size = new System.Drawing.Size(158, 33);
            this.comboBoxTabel3.TabIndex = 17;
            // 
            // comboBox10
            // 
            this.comboBox10.DataSource = this.conductorsBindingSource1;
            this.comboBox10.DisplayMember = "name";
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Location = new System.Drawing.Point(6, 130);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(178, 33);
            this.comboBox10.TabIndex = 10;
            // 
            // comboBoxTabel2
            // 
            this.comboBoxTabel2.DataSource = this.conductorsBindingSource1;
            this.comboBoxTabel2.DisplayMember = "table_number";
            this.comboBoxTabel2.FormattingEnabled = true;
            this.comboBoxTabel2.Location = new System.Drawing.Point(6, 169);
            this.comboBoxTabel2.Name = "comboBoxTabel2";
            this.comboBoxTabel2.Size = new System.Drawing.Size(158, 33);
            this.comboBoxTabel2.TabIndex = 13;
            // 
            // comboBox11
            // 
            this.comboBox11.DataSource = this.conductorsBindingSource;
            this.comboBox11.DisplayMember = "name";
            this.comboBox11.FormattingEnabled = true;
            this.comboBox11.Location = new System.Drawing.Point(6, 44);
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.Size = new System.Drawing.Size(178, 33);
            this.comboBox11.TabIndex = 3;
            // 
            // comboBoxTabel1
            // 
            this.comboBoxTabel1.DataSource = this.conductorsBindingSource;
            this.comboBoxTabel1.DisplayMember = "table_number";
            this.comboBoxTabel1.FormattingEnabled = true;
            this.comboBoxTabel1.Location = new System.Drawing.Point(6, 83);
            this.comboBoxTabel1.Name = "comboBoxTabel1";
            this.comboBoxTabel1.Size = new System.Drawing.Size(158, 33);
            this.comboBoxTabel1.TabIndex = 9;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Red;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(503, 750);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(89, 75);
            this.btnPrint.TabIndex = 13;
            this.btnPrint.Text = "Печать";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // RouteList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 837);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "RouteList";
            this.Text = "Маршрутный лист";
            this.Load += new System.EventHandler(this.RouteList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseRZDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conductorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listTrainsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseRZDDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conductorsBindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.conductorsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conductorsBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataBaseRZDDataSet dataBaseRZDDataSet;
        private System.Windows.Forms.BindingSource conductorsBindingSource;
        private DataBaseRZDDataSetTableAdapters.conductorsTableAdapter conductorsTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboNumber;
        private System.Windows.Forms.BindingSource dataBaseRZDDataSetBindingSource;
        private System.Windows.Forms.BindingSource listTrainsBindingSource;
        private DataBaseRZDDataSetTableAdapters.listTrainsTableAdapter listTrainsTableAdapter;
        private System.Windows.Forms.BindingSource trainMasterBindingSource;
        private DataBaseRZDDataSetTableAdapters.TrainMasterTableAdapter trainMasterTableAdapter;
        private System.Windows.Forms.BindingSource conductorsBindingSource1;
        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBoxTabel;
        private System.Windows.Forms.ComboBox comboBoxSurname;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox22;
        private System.Windows.Forms.ComboBox comboBoxTabel4;
        private System.Windows.Forms.ComboBox comboBox18;
        private System.Windows.Forms.ComboBox comboBoxTabel3;
        private System.Windows.Forms.ComboBox comboBox10;
        private System.Windows.Forms.ComboBox comboBoxTabel2;
        private System.Windows.Forms.ComboBox comboBox11;
        private System.Windows.Forms.ComboBox comboBoxTabel1;
        private System.Windows.Forms.ComboBox comboBox25;
        private System.Windows.Forms.BindingSource conductorsBindingSource3;
        private System.Windows.Forms.ComboBox comboSurname4;
        private System.Windows.Forms.ComboBox comboBox21;
        private System.Windows.Forms.BindingSource conductorsBindingSource2;
        private System.Windows.Forms.ComboBox comboBoxSurname3;
        private System.Windows.Forms.ComboBox comboBox17;
        private System.Windows.Forms.ComboBox comboBoxSurname2;
        private System.Windows.Forms.ComboBox comboBox14;
        private System.Windows.Forms.ComboBox comboBoxSurname1;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}