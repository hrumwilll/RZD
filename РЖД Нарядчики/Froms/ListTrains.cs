using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace РЖД_Нарядчики.Froms
{
    public partial class ListTrains : Form
    {
        DataBase database = new DataBase();
        int selectedRow;
        public ListTrains()
        {
            InitializeComponent();
        }
        private void ClearFields()
        {
            labelIdText.Text = "";
            textBoxName.Text = "";
            textBoxNumber.Text = "";
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";
        }

        //Переименование таблиц для DataGridView
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("number", "Номер поезда");
            dataGridView1.Columns.Add("name", "Наименование(маршрут) поезда");
            dataGridView1.Columns.Add("dataStart", "Дата начала маршрута");
            dataGridView1.Columns.Add("dataEnd", "Дата конца маршрута");
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetString(2), record.GetDateTime(3), record.GetDateTime(4));
        }

        //добавляем данные из БД
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"select * from listTrains";
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
        private void ListTrains_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        //Выявления данных в форму при нажатии на строку в DataGridView
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                labelIdText.Text = row.Cells[0].Value.ToString();
                textBoxNumber.Text = row.Cells[1].Value.ToString();
                textBoxName.Text = row.Cells[2].Value.ToString();
                dateTimePicker1.Text = row.Cells[3].Value.ToString();
                dateTimePicker2.Text = row.Cells[4].Value.ToString();
            }
        }



        //кнопка сохранения и отправки данных из формы в БД
        private void btnSave_Click(object sender, EventArgs e)
        {

            int number;
            var name = textBoxName.Text;
            var dataSTart = dateTimePicker1.Value;
            var dataENd = dateTimePicker2.Value;

            if (int.TryParse(textBoxNumber.Text, out number))
            {
                var addQuery = $"insert into listTrains (number, name, dataStart, dataEnd) values ('{number}', '{name}', '{dataSTart}', '{dataENd}')";

                var command = new SqlCommand(addQuery, database.getConnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно добавлена!");
            }
            else
            {
                MessageBox.Show("Номер должен иметь числовой формат!, Ошибка!");
            }
            database.closeConnection();
        }

        private void Update()
        {
            database.openConnection();

            for (int index = 0; index > dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[5].Value;

                if (rowState == RowState.Existed)
                {
                    continue;
                }



                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from listTrains where id = {id}";

                    var command = new SqlCommand(deleteQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var number = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var name = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var datastart = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var dataend = dataGridView1.Rows[index].Cells[4].Value.ToString();

                    var changeQuery = $"update listTrains set number ='{number}', name = '{name}', dataStart = '{datastart}', dataEnd = '{dataend}' where id = '{id}'";

                    var command = new SqlCommand(changeQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }

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
                dataGridView1.Rows[index].Cells[5].Value = RowState.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells[4].Value = RowState.Deleted;

        }

        //Кнопка обновления
        private void btnReload_Click_1(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
            Update();
            ClearFields();

        }


        //кнопка удаления
        private void btnDel_Click(object sender, EventArgs e)
        {
            deleteRow();
            ClearFields();
        }

        private void buttonSave2_Click(object sender, EventArgs e)
        {
            Update();
            ClearFields();
        }
    }
}