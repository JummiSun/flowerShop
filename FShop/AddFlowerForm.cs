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
    public partial class AddFlowerForm : Form
    {
        private DB db;
        public AddFlowerForm()
        {
            InitializeComponent();
            db = new DB();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        { 
            string title = titleTextBox.Text;
            int stunt = (int)stuntNumericUpDown.Value;

            
            decimal price = 0;
            if (decimal.TryParse(textBoxPrice.Text, out price))
            {
                string color = colorComboBox.SelectedItem?.ToString();
                string occasion = occasionComboBox.SelectedItem?.ToString();

                db.Execute(connection =>
                {
                    using (MySqlCommand command = new MySqlCommand("INSERT INTO Flowers (title, stunt, price, colour, occasion) VALUES (@title, @stunt, @price, @color, @occasion)", (MySqlConnection)connection))
                    {
                        command.Parameters.AddWithValue("@title", title);
                        command.Parameters.AddWithValue("@stunt", stunt);
                        command.Parameters.AddWithValue("@price", price);
                        command.Parameters.AddWithValue("@color", color);
                        command.Parameters.AddWithValue("@occasion", occasion);

                        command.ExecuteNonQuery();
                    }
                });

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректное значение для цены.");
            }
        }
    }
}
