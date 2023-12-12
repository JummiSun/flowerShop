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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Width,64);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Green;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String loginAccount = loginField.Text;
            String passAccount = passField.Text;
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `role_accounts` WHERE `login` = @aL AND `pass` = @aP", db.getConnection());
            command.Parameters.Add("@aL",MySqlDbType.VarChar).Value = loginAccount;
            command.Parameters.Add("@aP", MySqlDbType.VarChar).Value = passAccount;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                string login = table.Rows[0]["login"].ToString();
                string loginFlorist = table.Rows[0]["login"].ToString();

                if (login == "admin" && loginAccount == "admin" && passAccount == "admin1")
                {
                    AdminMainForm adminMainForm = new AdminMainForm();
                    adminMainForm.Show();
                } else if(loginFlorist == "florist" && loginAccount == "florist" && passAccount == "florist123")
                {
                    FloristMainForm floristMainForm = new FloristMainForm();
                    floristMainForm.Show();
                }
                else
                {
                    ClientMainForm clientMainForm = new ClientMainForm();
                    clientMainForm.Show();
                }

            }
            else
                MessageBox.Show("Login or passowrds is incorrect");
        }

        private void registerLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }
    }
}
