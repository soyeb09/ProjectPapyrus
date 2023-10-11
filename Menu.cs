using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Threading;
using Siticone.UI.WinForms;

namespace ProjectProtectedPapyrus
{
    public partial class Menu : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // width of ellipse
           int nHeightEllipse // height of ellipse
       );

        public Menu()
        {
            InitializeComponent();
        }



        private void Menu_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            date2.Text = DateTime.Now.ToString();
            user.Text = "Welcome "+ Environment.UserName;
        }


        int mov, movX, movY;

        private void Menu_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void siticoneMaterialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            siticoneMaterialRadioButton1.Checked = false;

        }

        private void siticoneLabel1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void siticoneLabel3_Click(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {
            richTextBox2.Visible = true;
            saveButton1.Visible = true;
            saveButton1.Text = "Save";
            copyButton1.Text = "Copy";
            monthCalendar1.Visible = false;
        }

        private void saveButton1_Click(object sender, EventArgs e)
        {
            saveButton1.Text = "Saved";
            siticoneRoundedTextBox1.Visible = true;
            siticoneRoundedTextBox1.Text = "1sdahsdgasdasgdasd09";
            copyButton1.Visible = true;
            copyButton1.Text = "Copy";
        }

        private void siticoneRoundedButton2_Click(object sender, EventArgs e)
        {
            richTextBox2.Visible = false;
            siticoneRoundedTextBox1.Visible = false;
            saveButton1.Visible = false;
            copyButton1.Visible = false;
            siticoneRoundedTextBox2.Visible = true;
            checkButton1.Visible = true;
            monthCalendar1.Visible = false;
        }

        private void copyButton1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(siticoneRoundedTextBox1.Text);
            Thread.Sleep(1500);
            richTextBox2.Visible = false;
            saveButton1.Visible = false;
            siticoneRoundedTextBox1.Visible = false;
            copyButton1.Visible = false;
            siticoneRoundedTextBox2.Visible = false;
            checkButton1.Visible = false;
        }

        private void siticoneRoundedButton5_Click(object sender, EventArgs e)
        {
            if(siticoneRoundedTextBox2.Text == "1sdahsdgasdasgdasd09")
            {
                siticoneRoundedTextBox2.Visible = false;
                checkButton1.Visible = false;
                richTextBox2.Visible = true;
                saveButton1.Visible = true;
                saveButton1.Text = "Save";
                copyButton1.Text = "Copy";
                wrong1.Visible = false;
                editButton1.Visible = true;
            }
            else
            {
                wrong1.Visible = true;
            }
        }

        private void siticoneRoundedButton5_Click_1(object sender, EventArgs e)
        {
            richTextBox2.Visible = false;
            siticoneRoundedTextBox1.Visible = false;
            saveButton1.Visible = false;
            copyButton1.Visible = false;
            siticoneRoundedTextBox2.Visible = false;
            checkButton1.Visible = false;
            monthCalendar1.Visible = true;

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
           
        }

        private void siticoneRoundedButton4_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = false;
        }

        private void siticoneRoundedButton3_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = false;
        }

        private void Menu_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void Menu_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
    }
}
