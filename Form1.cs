using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnCompute_Click(object sender, EventArgs e)
        {
            try
            {

                string itemName = txtItemName.Text;
                double price = Convert.ToDouble(txtPrice.Text);
                int quantity = Convert.ToInt32(txtQuantity.Text);
                double discount = Convert.ToDouble(txtDiscount.Text);
                double discountValue = discount * 0.01;
                double discountedPrice = price * (1 - discountValue);
                double totalAmount = discountedPrice * quantity;

                lblTotalAmount.Text = totalAmount.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("erorr try again: " + ex.Message);
            }
        }


        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(lblTotalAmount.Text))
                {
                    MessageBox.Show("Please compute first");
                    return;
                }


                double totalAmount = Convert.ToDouble(lblTotalAmount.Text);

                if (string.IsNullOrEmpty(txtPaymentReceived.Text))
                {
                    MessageBox.Show("Please enter the payment ");
                    return;
                }

                double paymentReceived = Convert.ToDouble(txtPaymentReceived.Text);

                if (paymentReceived < totalAmount)
                {
                    MessageBox.Show("kulang po bayad nyo ");
                }
                else
                {
                    double change = paymentReceived - totalAmount;
                    lblChange.Text = change.ToString("F2");

                    MessageBox.Show("salamat po!    " + change.ToString("F2"));
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }



        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 loginForm = new Form2();
            loginForm.Show();
            this.Hide();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form2 loginForm = new Form2();
            loginForm.Show();
        }

        private void exitApplicationToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }
    }
}
