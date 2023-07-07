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

namespace РЖД_Нарядчики.Froms
{
    public partial class RouteList : Form
    {
        public RouteList()
        {
            InitializeComponent();
        }

        private void RouteList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBaseRZDDataSet.TrainMaster". При необходимости она может быть перемещена или удалена.
            this.trainMasterTableAdapter.Fill(this.dataBaseRZDDataSet.TrainMaster);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBaseRZDDataSet.listTrains". При необходимости она может быть перемещена или удалена.
            this.listTrainsTableAdapter.Fill(this.dataBaseRZDDataSet.listTrains);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBaseRZDDataSet.conductors". При необходимости она может быть перемещена или удалена.
            this.conductorsTableAdapter.Fill(this.dataBaseRZDDataSet.conductors);

        }

        Bitmap bmp;

        private void btnPrint_Click(object sender, EventArgs e)
        {

            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
