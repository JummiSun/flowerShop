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
    public partial class FlowerForm : Form
    {
        private DB db;
        public FlowerForm()
        {
            InitializeComponent();
            db = new DB();
            InitializeDataGridView();
            LoadFlowerData();
        }
        private void InitializeDataGridView()
        {
            DataGridViewTextBoxColumn columnId = new DataGridViewTextBoxColumn();
            columnId.HeaderText = "ID";
            columnId.Name = "FlowerIdColumn"; 
            dataGridView1.Columns.Add(columnId);

            DataGridViewTextBoxColumn columnFirstName = new DataGridViewTextBoxColumn();
            columnFirstName.HeaderText = "Название цветов";
            columnFirstName.Name = "FlowerTitleColumn";
            dataGridView1.Columns.Add(columnFirstName);

            DataGridViewTextBoxColumn columnLastName = new DataGridViewTextBoxColumn();
            columnLastName.HeaderText = "Штук цветов";
            columnLastName.Name = "FlowerStuntColumn";
            dataGridView1.Columns.Add(columnLastName);

            DataGridViewTextBoxColumn columnCity = new DataGridViewTextBoxColumn();
            columnCity.HeaderText = "Цена за штуку цветов";
            columnCity.Name = "FlowerPriceColumn";
            dataGridView1.Columns.Add(columnCity);

            DataGridViewTextBoxColumn columnPhone = new DataGridViewTextBoxColumn();
            columnPhone.HeaderText = "Цвет цветов";
            columnPhone.Name = "FlowerColourColumn";
            dataGridView1.Columns.Add(columnPhone);

            DataGridViewTextBoxColumn columnEmail = new DataGridViewTextBoxColumn();
            columnEmail.HeaderText = "Повод с цветами";
            columnEmail.Name = "FlowerOccasionColumn";
            dataGridView1.Columns.Add(columnEmail);
        }

        private void buttonDeleteFlower_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int flowerId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["FlowerIdColumn"].Value);
                db.Execute(connection =>
                {
                    using (MySqlCommand command = new MySqlCommand("DELETE FROM Flowers WHERE id_flower = @flowerId", (MySqlConnection)connection))
                    {
                        command.Parameters.AddWithValue("@flowerId", flowerId);
                        command.ExecuteNonQuery();
                    }
                });
                LoadFlowerData();
            }
            else
            {
                MessageBox.Show("Выберите цветка для удаления.");
            }
        }

        private void LoadFlowerData()
        {
            dataGridView1.Rows.Clear();

            db.Execute(connection =>
            {
                using (MySqlCommand command = new MySqlCommand("SELECT * FROM Flowers", connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(
                                reader["id_flower"],
                                reader["title"],
                                reader["stunt"],
                                reader["price"],
                                reader["colour"],
                                reader["occasion"]
                            );
                        }
                    }
                }
            });
        }

        private void buttonAddFlower_Click(object sender, EventArgs e)
        {
            using (AddFlowerForm addFlowerForm = new AddFlowerForm())
            {
                DialogResult result = addFlowerForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    LoadFlowerData();
                }
            }
        }

    }
}
