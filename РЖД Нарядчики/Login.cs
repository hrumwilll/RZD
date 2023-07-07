using System;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace РЖД_Нарядчики
{
    public partial class Login : Form
    {
        DataBase dataBase = new DataBase();
        public Login()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]


        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void buttonCloseLogin_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти из программы?", "Выход", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }




        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var loginUser = textLogin.Text;
            var passUser = textPass.Text;
           SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select id, login, pass from [User] where login ='{loginUser}' and pass = '{passUser}' ";
            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Добро пожаловать в систему!");
                MainWindow form = new MainWindow();
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Неправильный логин или пароль! Обратитесь к системному администратору для восстановления доступа!");
        }

        
    }
}
