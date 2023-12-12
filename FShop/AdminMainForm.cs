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
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonFlorist_Click(object sender, EventArgs e)
        {
            FloristForm floristForm = new FloristForm();
            floristForm.Show();
        }
        private void buttonClient_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm();
            clientForm.Show();
        }
        private void buttonFlower_Click(object sender, EventArgs e)
        {
            FlowerForm flowerForm = new FlowerForm();
            flowerForm.Show();
        }

    }
}
