using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApplication
{
    public partial class Form2 : Form
    {
        private double price;
        private double discount;
        private int quantity;
        private double item;
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            double paymentReceived = Convert.ToDouble(textBoxPayment.Text);
            double change = paymentReceived - item;
            labelChng.Text = change.ToString();
        }

        private void buttonCompute_Click(object sender, EventArgs e)
        {
            price = Convert.ToDouble(textBoxPrice.Text);
            discount = Convert.ToDouble(textBoxDiscount.Text);
            quantity = Convert.ToInt32(textBoxQty.Text);

            item = (price * quantity) - ((discount / 100) * (price * quantity));
            labelAmount.Text = item.ToString();
        }

        }
    }

