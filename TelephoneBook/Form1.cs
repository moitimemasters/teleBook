using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelephoneBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            select_all();
        }
        public void select_all()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `contacts`" , db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        public bool is_name_in_table(String name)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `contacts` WHERE `name` = '" + name + "'", db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table.Rows.Count > 0;

        }

        public bool is_number_in_table(String number)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `contacts` WHERE `phone` = '" + number + "'", db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table.Rows.Count > 0;

        }

        public void select_by_name_and_number(String name, String number)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `contacts` WHERE (`name` LIKE '%" + name + "%') AND (`phone` LIKE '%" + number + "%')", db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        public void delete_by_name(String name)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("DELETE FROM `contacts` WHERE `name` = '" + name + "'", db.getConnection());
            adapter.DeleteCommand = command;
            command.ExecuteNonQuery();
            db.closeConnection();
        }
        public void delete_by_number(String number)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("DELETE FROM `contacts` WHERE `phone` = '" + number + "'", db.getConnection());
            adapter.DeleteCommand = command;
            command.ExecuteNonQuery();
            db.closeConnection();

        }
        public void delete_by_id(String id)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("DELETE FROM `contacts` WHERE `id` = '" + id + "'", db.getConnection());
            adapter.DeleteCommand = command;
            command.ExecuteNonQuery();
            db.closeConnection();
        }

        public void update_name_by_number(String new_name, String number)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("UPDATE `contacts` SET `name` = '" + new_name + "' WHERE `phone` = '" + number + "'", db.getConnection());
            db.closeConnection();
        }
        public void update_name_by_id(String new_name, String id)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("UPDATE  `contacts` SET `name` = '" + new_name + "' WHERE `id` = '" + id + "'", db.getConnection());
            command.ExecuteNonQuery();
            db.closeConnection();
        }
        public void update_number_by_name(String new_number, String name)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlConnection conn = db.getConnection();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("UPDATE  `contacts` SET `phone` = '" + new_number + "' WHERE `name` = '" + name + "'", conn);
            command.ExecuteNonQuery();
            db.closeConnection();
            
        }
        public void update_number_by_id(String new_number, String id)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlConnection conn = db.getConnection();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("UPDATE  `contacts` SET `phone` = '" + new_number + "' WHERE `id` = '" + id + "'", conn);
            command.ExecuteNonQuery();
            db.closeConnection();
        }
        public void insert_name_number(String name, String number)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("INSERT INTO `contacts` (`name`, `phone`) VALUES ('" + name + "', '" + number + "')", db.getConnection());
            adapter.InsertCommand = command;
            try
            {
                command.ExecuteNonQuery();
            } catch
            {
                MessageBox.Show("Номер уже записан в книге.");
            }
            db.closeConnection();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            String name = name_ae_box.Text;
            String number = number_ae_box.Text;
            insert_name_number(name, number);
            select_all();
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            String name = name_ae_box.Text;
            String number = number_ae_box.Text;
            bool is_name = is_name_in_table(name);
            bool is_number = is_number_in_table(number);
            if (is_name && is_number)
            {
                MessageBox.Show("Запись с именем " + name + " и номером " + number + " есть в книге.");
            } else if (is_name && !is_number)
            {
                update_number_by_name(number, name);
            } else if (!is_name && is_number)
            {
                update_name_by_number(name, number);
            } else
            {
                MessageBox.Show("Записи не существует.");
            }
            select_all();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String name = name_ae_box.Text;
            String number = number_ae_box.Text;
            bool is_name = is_name_in_table(name);
            bool is_number = is_number_in_table(number);
            if (name != "" && number != "") {
                if (!is_name && is_number)
                {
                    MessageBox.Show("Такого имени нет, чтобы удалить запись по номеру не вводите имя.");
                } else if (!is_number && is_name)
                {
                    MessageBox.Show("Такого номера нет, чтобы удалить записи по имени не вводите номер.");
                } else if (!is_number && !is_name)
                {
                    MessageBox.Show("Таких данных нет, введите валидные данные.");
                } else
                {
                    delete_by_number(number);
                }
            } else if (name != "" && number == "")
            {
                if (!is_name)
                {
                    MessageBox.Show("Такого имени нет.");
                } else
                {
                    delete_by_name(name);
                }
            }
            else if (number != "" && name == "")
            {
                if (!is_number)
                {
                    MessageBox.Show("Такого номера нет.");
                }
                else
                {
                    delete_by_number(number);
                }
            } else
            {
                MessageBox.Show("Введите что-нибудь!");
            }
            select_all();
        }

        private void name_s_box_TextChanged(object sender, EventArgs e)
        {
            String name = name_s_box.Text;
            String number = number_s_box.Text;
            select_by_name_and_number(name, number);
        }

        private void number_s_box_TextChanged(object sender, EventArgs e)
        {
            String name = name_s_box.Text;
            String number = number_s_box.Text;
            select_by_name_and_number(name, number);
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int row_index = e.RowIndex;
            int col_index = e.ColumnIndex;
            String id = dataGridView1.Rows[row_index].Cells[0].Value.ToString();
            String name = dataGridView1.Rows[row_index].Cells[1].Value.ToString();
            String number = dataGridView1.Rows[row_index].Cells[2].Value.ToString();
            if (col_index == 1)
            {
                update_name_by_id(name, id);
            } else if (col_index == 2)
            {
                update_number_by_id(number, id);
            }
        }
    }
}
