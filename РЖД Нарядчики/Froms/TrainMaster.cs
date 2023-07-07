using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace РЖД_Нарядчики.Froms
{
   
    public partial class TrainMaster : Form
    {
        DataBase database = new DataBase();
        int selectedRow;
        public TrainMaster()
        {
            InitializeComponent();
        }

        private void ClearFields()
        {
            labelIDtext.Text = "";
            textName.Text = "";
            textSurname.Text = "";
            textPatronymic.Text = "";
            textNumber.Text = "";
            textRazrad.Text = "";
        }



        //Переименование таблиц для DataGridView
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("name", "Имя");
            dataGridView1.Columns.Add("surname", "Фамилия");
            dataGridView1.Columns.Add("patronymic", "Отчество");
            dataGridView1.Columns.Add("table_number", "Табельный номер");
            dataGridView1.Columns.Add("razrad", "Разряд");
        }

        //передаём параметры из БД
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetInt32(4), record.GetInt32(5));
        }
        //добавляем данные из БД
        private void RefreshDataGrid(DataGridView dgw)
        {

            dgw.Rows.Clear();
            string queryString = $"select * from TrainMaster";
            SqlCommand command = new SqlCommand(queryString, database.getConnection());
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        //Создание таблиц при загрузки child form
        private void TrainMaster_Load(object sender, EventArgs e)
        {

            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }



        //Выявления данных в форму при нажатии на строку в DataGridView
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                labelIDtext.Text = row.Cells[0].Value.ToString();
                textName.Text = row.Cells[1].Value.ToString();
                textSurname.Text = row.Cells[2].Value.ToString();
                textPatronymic.Text = row.Cells[3].Value.ToString();
                textNumber.Text = row.Cells[4].Value.ToString();
                textRazrad.Text = row.Cells[5].Value.ToString();
            }
        }




        //кнопка сохранения и отправки данных из формы в БД
        private void btnSave_Click(object sender, EventArgs e)
        {
            database.openConnection();

            var name = textName.Text;
            var surname = textSurname.Text;
            var patronymic = textPatronymic.Text;
            var razrad = textRazrad.Text;
            int tabel;

            if (int.TryParse(textNumber.Text, out tabel))
            {
                var addQuery = $"insert into TrainMaster (name, surname, patronymic, table_number, razrad) values ('{name}', '{surname}', '{patronymic}', '{tabel}', '{razrad}')";

                var command = new SqlCommand(addQuery, database.getConnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно добавлена!");
            }
            else
            {
                MessageBox.Show("Табельный номер должен иметь числовой формат!, Ошибка!");
            }

            database.closeConnection();
        }



        //удаление записи
        private void deleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[6].Value = RowState.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells[5].Value = RowState.Deleted;

        }


        private void Update()
        {
            database.openConnection();

            for (int index = 0; index > dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[6].Value;

                if (rowState == RowState.Existed)
                {
                    continue;
                }



                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from TrainMaster where id = {id}";

                    var command = new SqlCommand(deleteQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var name = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var surname = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var patronymic = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var number = dataGridView1.Rows[index].Cells[4].Value.ToString();
                    var razrad = dataGridView1.Rows[index].Cells[5].Value.ToString();

                    var changeQuery = $"update TrainMaster set name ='{name}', surname = '{surname}', patronymic = '{patronymic}', table_number = '{number}', razrad = '{razrad}' where id = '{id}'";

                    var command = new SqlCommand(changeQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }

            }
            database.closeConnection();
        }



        //Кнопка обновления
        private void btnReload_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
            Update();
            ClearFields();
        }

        //кнопка удаления
        private void btnDel_Click(object sender, EventArgs e)
        {
            deleteRow();
            Update();
            ClearFields();
        }


        //сохранение
        private void buttonSave3_Click(object sender, EventArgs e)
        {
            Update();
            ClearFields();
        }


    }
}
