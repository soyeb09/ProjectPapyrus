﻿using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ProjectProtectedPapyrus
{
    public partial class Dashboard : Form
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

        public Dashboard()
        {
            InitializeComponent();
        }


        int mov, movX, movY;

        private void Dashboard_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void siticoneMaterialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            siticoneMaterialRadioButton1.Checked = false;
        }

        private void siticoneLabel3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Dashboard_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void Dashboard_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }
    }
}
