using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace CashierApplication
{
    public partial class FrmPruchaseDiscountedItem : Form
    {
        private double price;
        private double discount;
        private int quantity;
        private double item;

        public FrmPruchaseDiscountedItem()
        {
            InitializeComponent();
        }
        double Total;
        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                double paymentReceived = Convert.ToDouble(TextBoxPayment.Text);
                double change = paymentReceived - Total;
                TextLabelChange.Text = change.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please input an item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ButtonCompute_Click(object sender, EventArgs e)
        {
            try
            {
                price = Convert.ToDouble(TextBoxPrice.Text);
                discount = Convert.ToDouble(TextBoxDiscount.Text);
                quantity = Convert.ToInt32(TextBoxQty.Text);

                item = (price * quantity) - ((discount * 0.01) * (price * quantity));
                TextLabelAmount.Text = item.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please input an item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ButtonAddItem_Click_1(object sender, EventArgs e)
        {
            String n = TextBoxItem.Text;
            if (!string.IsNullOrEmpty(n))
            {

                Items_files.Rows.Add(TextBoxItem.Text, TextBoxQty.Text, TextBoxPrice.Text, TextBoxDiscount.Text, TextLabelAmount.Text);
                Items_files.AllowUserToAddRows = false;
                Clear();

            }
            else
            {
                MessageBox.Show("Please input item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Clear()
        {
            TextBoxItem.Text = " ";
            TextBoxQty.Text = " ";
            TextBoxPrice.Text = " ";
            TextBoxDiscount.Text = " ";
            TextLabelAmount.Text = " ";
            TextBoxPayment.Text = " ";
            TextLabelChange.Text = " ";
        }
        private void ButtonTotal_Click(object sender, EventArgs e)
        {
            String n = TextBoxItem.Text;
            if (!string.IsNullOrEmpty(n))
            {
                for (int i = 0; i < Items_files.Rows.Count; i++)
                {
                    Total += double.Parse(Items_files.Rows[i].Cells[4].Value.ToString());
                }
                Items_files.Rows.Add(null, null, null, "Total", Total);

            }
            else
            {
                MessageBox.Show("Please input an item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            _userLogin Login = new _userLogin();
            Login.ShowDialog();
        }
        private void ExitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}