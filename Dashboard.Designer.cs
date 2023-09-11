namespace ProjectProtectedPapyrus
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.siticoneCheckBox1 = new Siticone.UI.WinForms.SiticoneCheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.siticoneButton1 = new Siticone.UI.WinForms.SiticoneButton();
            this.siticoneButton2 = new Siticone.UI.WinForms.SiticoneButton();
            this.siticoneButton3 = new Siticone.UI.WinForms.SiticoneButton();
            this.siticoneMaterialRadioButton1 = new Siticone.UI.WinForms.SiticoneMaterialRadioButton();
            this.siticoneLabel3 = new Siticone.UI.WinForms.SiticoneLabel();
            this.SuspendLayout();
            // 
            // siticoneCheckBox1
            // 
            this.siticoneCheckBox1.AutoSize = true;
            this.siticoneCheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneCheckBox1.CheckedState.BorderRadius = 2;
            this.siticoneCheckBox1.CheckedState.BorderThickness = 0;
            this.siticoneCheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneCheckBox1.ForeColor = System.Drawing.Color.White;
            this.siticoneCheckBox1.Location = new System.Drawing.Point(12, 39);
            this.siticoneCheckBox1.Name = "siticoneCheckBox1";
            this.siticoneCheckBox1.Size = new System.Drawing.Size(62, 17);
            this.siticoneCheckBox1.TabIndex = 2;
            this.siticoneCheckBox1.Text = "Encrypt";
            this.siticoneCheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneCheckBox1.UncheckedState.BorderRadius = 2;
            this.siticoneCheckBox1.UncheckedState.BorderThickness = 0;
            this.siticoneCheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneCheckBox1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Silver;
            this.listBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(80, 39);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(279, 156);
            this.listBox1.TabIndex = 11;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
            this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.HoveredState.Parent = this.siticoneButton1;
            this.siticoneButton1.Location = new System.Drawing.Point(80, 201);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
            this.siticoneButton1.Size = new System.Drawing.Size(89, 23);
            this.siticoneButton1.TabIndex = 12;
            this.siticoneButton1.Text = "Save";
            // 
            // siticoneButton2
            // 
            this.siticoneButton2.CheckedState.Parent = this.siticoneButton2;
            this.siticoneButton2.CustomImages.Parent = this.siticoneButton2;
            this.siticoneButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton2.ForeColor = System.Drawing.Color.White;
            this.siticoneButton2.HoveredState.Parent = this.siticoneButton2;
            this.siticoneButton2.Location = new System.Drawing.Point(175, 201);
            this.siticoneButton2.Name = "siticoneButton2";
            this.siticoneButton2.ShadowDecoration.Parent = this.siticoneButton2;
            this.siticoneButton2.Size = new System.Drawing.Size(89, 23);
            this.siticoneButton2.TabIndex = 13;
            this.siticoneButton2.Text = "Clear";
            // 
            // siticoneButton3
            // 
            this.siticoneButton3.CheckedState.Parent = this.siticoneButton3;
            this.siticoneButton3.CustomImages.Parent = this.siticoneButton3;
            this.siticoneButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton3.ForeColor = System.Drawing.Color.White;
            this.siticoneButton3.HoveredState.Parent = this.siticoneButton3;
            this.siticoneButton3.Location = new System.Drawing.Point(270, 201);
            this.siticoneButton3.Name = "siticoneButton3";
            this.siticoneButton3.ShadowDecoration.Parent = this.siticoneButton3;
            this.siticoneButton3.Size = new System.Drawing.Size(89, 23);
            this.siticoneButton3.TabIndex = 14;
            this.siticoneButton3.Text = "Preview";
            // 
            // siticoneMaterialRadioButton1
            // 
            this.siticoneMaterialRadioButton1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneMaterialRadioButton1.BorderColor = System.Drawing.Color.White;
            this.siticoneMaterialRadioButton1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.siticoneMaterialRadioButton1.Checked = false;
            this.siticoneMaterialRadioButton1.CheckedBorderColor = System.Drawing.Color.White;
            this.siticoneMaterialRadioButton1.CheckedFillColor = System.Drawing.Color.DodgerBlue;
            this.siticoneMaterialRadioButton1.CheckedTextColor = System.Drawing.Color.White;
            this.siticoneMaterialRadioButton1.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.siticoneMaterialRadioButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneMaterialRadioButton1.HoverBorderColor = System.Drawing.Color.White;
            this.siticoneMaterialRadioButton1.HoverFillColor = System.Drawing.Color.DodgerBlue;
            this.siticoneMaterialRadioButton1.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.siticoneMaterialRadioButton1.Location = new System.Drawing.Point(321, 4);
            this.siticoneMaterialRadioButton1.Name = "siticoneMaterialRadioButton1";
            this.siticoneMaterialRadioButton1.ReadOnly = false;
            this.siticoneMaterialRadioButton1.Size = new System.Drawing.Size(23, 20);
            this.siticoneMaterialRadioButton1.TabIndex = 16;
            this.siticoneMaterialRadioButton1.TextColor = System.Drawing.Color.White;
            this.siticoneMaterialRadioButton1.TextLeftAlign = 0;
            this.siticoneMaterialRadioButton1.CheckedChanged += new System.EventHandler(this.siticoneMaterialRadioButton1_CheckedChanged);
            // 
            // siticoneLabel3
            // 
            this.siticoneLabel3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel3.ForeColor = System.Drawing.Color.White;
            this.siticoneLabel3.IsSelectionEnabled = false;
            this.siticoneLabel3.Location = new System.Drawing.Point(347, 3);
            this.siticoneLabel3.Name = "siticoneLabel3";
            this.siticoneLabel3.Size = new System.Drawing.Size(14, 22);
            this.siticoneLabel3.TabIndex = 15;
            this.siticoneLabel3.Text = "X";
            this.siticoneLabel3.Click += new System.EventHandler(this.siticoneLabel3_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(368, 257);
            this.Controls.Add(this.siticoneMaterialRadioButton1);
            this.Controls.Add(this.siticoneLabel3);
            this.Controls.Add(this.siticoneButton3);
            this.Controls.Add(this.siticoneButton2);
            this.Controls.Add(this.siticoneButton1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.siticoneCheckBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Dashboard_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Dashboard_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Dashboard_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Siticone.UI.WinForms.SiticoneCheckBox siticoneCheckBox1;
        private System.Windows.Forms.ListBox listBox1;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton1;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton2;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton3;
        private Siticone.UI.WinForms.SiticoneMaterialRadioButton siticoneMaterialRadioButton1;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel3;
    }
}