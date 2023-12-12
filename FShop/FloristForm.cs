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

namespace FShop
{
    public partial class FloristForm : Form
    {
        private DB db;
        public FloristForm()
        {
            InitializeComponent();
            db = new DB();
            InitializeDataGridView();
            LoadFloristData();
        }

        private void InitializeDataGridView()
        {
            DataGridViewTextBoxColumn columnId = new DataGridViewTextBoxColumn();
            columnId.HeaderText = "ID";
            columnId.Name = "FloristIdColumn"; 
            dataGridView1.Columns.Add(columnId);

            DataGridViewTextBoxColumn columnFirstName = new DataGridViewTextBoxColumn();
            columnFirstName.HeaderText = "Имя";
            columnFirstName.Name = "FirstNameColumn";
            dataGridView1.Columns.Add(columnFirstName);

            DataGridViewTextBoxColumn columnLastName = new DataGridViewTextBoxColumn();
            columnLastName.HeaderText = "Фамилия";
            columnLastName.Name = "LastNameColumn";
            dataGridView1.Columns.Add(columnLastName);

            DataGridViewTextBoxColumn columnSalary = new DataGridViewTextBoxColumn();
            columnSalary.HeaderText = "Зарплата";
            columnSalary.Name = "SalaryColumn";
            dataGridView1.Columns.Add(columnSalary);

            DataGridViewTextBoxColumn columnPhone = new DataGridViewTextBoxColumn();
            columnPhone.HeaderText = "Телефон номер";
            columnPhone.Name = "PhoneColumn";
            dataGridView1.Columns.Add(columnPhone);

            DataGridViewTextBoxColumn columnEmail = new DataGridViewTextBoxColumn();
            columnEmail.HeaderText = "Email";
            columnEmail.Name = "EmailColumn";
            dataGridView1.Columns.Add(columnEmail);
        }

        private void buttonDeleteFlorist_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int floristId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["FloristIdColumn"].Value);

                db.Execute(connection =>
                {
                    using (MySqlCommand command = new MySqlCommand("DELETE FROM Florists WHERE id_florist = @floristId", (MySqlConnection)connection))
                    {
                        command.Parameters.AddWithValue("@floristId", floristId);
                        command.ExecuteNonQuery();
                    }
                });

                LoadFloristData();
            }
            else
            {
                MessageBox.Show("Выберите флориста для удаления.");
            }
        }

        private void LoadFloristData()
        {
            dataGridView1.Rows.Clear();

            db.Execute(connection =>
            {
                using (MySqlCommand command = new MySqlCommand("SELECT * FROM Florists", connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(
                                reader["id_florist"],
                                reader["first_name"],
                                reader["last_name"],
                                reader["salary"],
                                reader["phone"],
                                reader["email"]
                            );
                        }
                    }
                }
            });
        }
    }
}
