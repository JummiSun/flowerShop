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
    public partial class ClientMainForm : Form
    {
        public ClientMainForm()
        {
            InitializeComponent();
        }

        private void buttonOrderForClients_Click(object sender, EventArgs e)
        {
            OrderFlowerByClientForm orderFlowerByClientForm = new OrderFlowerByClientForm();
            orderFlowerByClientForm.Show();
        }

     
    }
}
