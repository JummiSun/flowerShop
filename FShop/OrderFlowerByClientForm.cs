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
    public partial class OrderFlowerByClientForm : Form
    {

        public OrderFlowerByClientForm()
        {
            InitializeComponent();
            titleFlowerComboBox.Items.Add("Розы");
            titleFlowerComboBox.Items.Add("Пионы");
            titleFlowerComboBox.Items.Add("Тюльпаны");
            titleFlowerComboBox.Items.Add("Пионовидные розы");

            colourFlowercomboBox.Items.Add("красный");
            colourFlowercomboBox.Items.Add("красно-розовый");
            colourFlowercomboBox.Items.Add("розовый");
            colourFlowercomboBox.Items.Add("белый");

            ocassionFlowercomboBox.Items.Add("День рождения");
            ocassionFlowercomboBox.Items.Add("Свадьба");
            ocassionFlowercomboBox.Items.Add("Юбилей");
            ocassionFlowercomboBox.Items.Add("День Святого Валентина");
        }

        private void orderFlowerButton_Click(object sender, EventArgs e)
        {
            string selectedTitle = titleFlowerComboBox.SelectedItem?.ToString();
            string selectedColor = colourFlowercomboBox.SelectedItem?.ToString();
            string selectedOccasion = ocassionFlowercomboBox.SelectedItem?.ToString();
            int selectedStunt = (int)stuntNumericUpDown.Value;

            if (selectedTitle == null || selectedColor == null || selectedOccasion == null)
            {
                MessageBox.Show("Пожалуйста, выберите все параметры для заказа.");
                return;
            }
            decimal pricePerStunt = GetPriceFromDatabase(selectedTitle);
            decimal totalPrice = selectedStunt * pricePerStunt;
            MessageBox.Show($"Общая стоимость заказа: {totalPrice:C}");
        }

        private decimal GetPriceFromDatabase(string flowerTitle)
        {
            decimal price = 0;

            using (MySqlConnection connection = new MySqlConnection("server=127.0.0.1; port=3307; user=root; password=; database=flower_shop"))
            {
                connection.Open();

                string query = "SELECT price FROM Flowers WHERE title = @title";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@title", flowerTitle);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            price = reader.GetDecimal("price");
                        }
                    }
                }
            }

            return price;
        }

       

    }
}
