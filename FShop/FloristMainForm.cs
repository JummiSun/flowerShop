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
    public partial class FloristMainForm : Form
    {
        public FloristMainForm()
        {
            InitializeComponent();
            
        }

        private void buttonFlower_Click(object sender, EventArgs e)
        {
            FlowerForm flowerForm = new FlowerForm();
            flowerForm.Show();
        }
    }
}
