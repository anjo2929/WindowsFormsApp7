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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Login_Click(object sender, EventArgs e)
        {

        }

        private void Login_Click_1(object sender, EventArgs e)
        {

            string username = Username.Text;
            string password = Password.Text;

            if (username == "skibidi" && password == "1234")
            {
                MessageBox.Show("Welcome, Boss Anjo!");
                Form1 purchaseForm = new Form1();
                purchaseForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }
        public class UserAccount
        {
            public string FullName { get; set; }
            public string UserName { get; set; }
            public string UserPassword { get; set; }

            public UserAccount(string name, string uName, string password)
            {
                FullName = name;
                UserName = uName;
                UserPassword = password;
            }

            public bool ValidateLogin(string uName, string password)
            {
                return (UserName == uName && UserPassword == password);
            }

            public string GetFullName()
            {
                return FullName;
            }
        }

        public class Cashier : UserAccount
        {
            public string Department { get; set; }

            public Cashier(string name, string department, string uName, string password)
                : base(name, uName, password)
            {
                Department = department;
            }

            public string GetDepartment()
            {
                return Department;
            }
        }

       
    }
}
