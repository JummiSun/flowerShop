using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FShop;
using MySql.Data.MySqlClient;

namespace FShop
{
    public partial class ClientForm : Form
    {
        private DB db;

        public ClientForm()
        {
            InitializeComponent();
            db = new DB();
            InitializeDataGridView();
            LoadClientData();
        }
        private void InitializeDataGridView()
        {
            DataGridViewTextBoxColumn columnId = new DataGridViewTextBoxColumn();
            columnId.HeaderText = "ID";
            columnId.Name = "ClientIdColumn"; 
            dataGridView1.Columns.Add(columnId);

            DataGridViewTextBoxColumn columnFirstName = new DataGridViewTextBoxColumn();
            columnFirstName.HeaderText = "Имя";
            columnFirstName.Name = "FirstNameColumn";
            dataGridView1.Columns.Add(columnFirstName);

            DataGridViewTextBoxColumn columnLastName = new DataGridViewTextBoxColumn();
            columnLastName.HeaderText = "Фамилия";
            columnLastName.Name = "LastNameColumn";
            dataGridView1.Columns.Add(columnLastName);

            DataGridViewTextBoxColumn columnCity = new DataGridViewTextBoxColumn();
            columnCity.HeaderText = "Город";
            columnCity.Name = "CityColumn";
            dataGridView1.Columns.Add(columnCity);

            DataGridViewTextBoxColumn columnPhone = new DataGridViewTextBoxColumn();
            columnPhone.HeaderText = "Телефон";
            columnPhone.Name = "PhoneColumn";
            dataGridView1.Columns.Add(columnPhone);

            DataGridViewTextBoxColumn columnEmail = new DataGridViewTextBoxColumn();
            columnEmail.HeaderText = "Email";
            columnEmail.Name = "EmailColumn";
            dataGridView1.Columns.Add(columnEmail);
        }


        private void delete_button_clients_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int clientId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ClientIdColumn"].Value);

                db.Execute(connection =>
                {
                    using (MySqlCommand command = new MySqlCommand("DELETE FROM Clients WHERE id_client = @clientId", (MySqlConnection)connection))
                    {
                        command.Parameters.AddWithValue("@clientId", clientId);
                        command.ExecuteNonQuery();
                    }
                });
                LoadClientData();
            }
            else
            {
                MessageBox.Show("Выберите клиента для удаления.");
            }
        }


        private void LoadClientData()
        {
            dataGridView1.Rows.Clear();

            db.Execute(connection =>
            {
                using (MySqlCommand command = new MySqlCommand("SELECT * FROM Clients", connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(
                                reader["id_client"],
                                reader["first_name"],
                                reader["last_name"],
                                reader["city"],
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
