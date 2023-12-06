using System;
using System.Windows.Forms;

namespace CashierApplication
{
    public partial class _userLogin : Form
    {
        public _userLogin()
        {
            InitializeComponent();
        }

        private void Button_login_Click(object sender, EventArgs e)
        {
            String Username = TextBox_username.Text;
            String Password = TextBox_password.Text;
            if (Username == "johnbernard@yahoo.com" && Password == "12345")
            {
                this.Hide();
                FrmPruchaseDiscountedItem hash = new FrmPruchaseDiscountedItem();
                hash.ShowDialog();

                this.Close();


            }
            else
            {
                MessageBox.Show("Your username and password are incorrect. Please try again.");
                TextBox_username.Text = "";
                TextBox_password.Text = "";

                TextBox_username.Focus();
            }
        }

        private void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {
            TextBox_password.UseSystemPasswordChar = true;

        }
    }
}

