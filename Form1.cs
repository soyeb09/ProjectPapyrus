using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectProtectedPapyrus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {
            if(siticoneRoundedTextBox1.Text == "Papyrus")
            {
                this.Hide();
                var Dashboard = new Dashboard();
                Dashboard.Show();
            }
            else
            {
                siticoneRoundedButton1.FillColor = Color.Red;
                siticoneRoundedButton1.Text = "Login Again";
            }
        }

        private void siticoneLabel1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void siticoneLabel2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
