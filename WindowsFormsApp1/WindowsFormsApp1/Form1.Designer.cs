namespace WindowsFormsApp1
{
    partial class Form1
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
            this.ChklCourses = new System.Windows.Forms.CheckedListBox();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.LblName = new System.Windows.Forms.Label();
            this.LblAge = new System.Windows.Forms.Label();
            this.LblCourses = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.TextAge = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ChklCourses
            // 
            this.ChklCourses.AccessibleName = "";
            this.ChklCourses.BackColor = System.Drawing.Color.Azure;
            this.ChklCourses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChklCourses.CheckOnClick = true;
            this.ChklCourses.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ChklCourses.FormattingEnabled = true;
            this.ChklCourses.Items.AddRange(new object[] {
            "HTML",
            "CSS",
            "Php",
            "F#",
            "C",
            "C++",
            "Java",
            "Ruby"});
            this.ChklCourses.Location = new System.Drawing.Point(340, 279);
            this.ChklCourses.Margin = new System.Windows.Forms.Padding(10);
            this.ChklCourses.Name = "ChklCourses";
            this.ChklCourses.Size = new System.Drawing.Size(117, 202);
            this.ChklCourses.TabIndex = 0;
            this.ChklCourses.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // cmbCity
            // 
            this.cmbCity.BackColor = System.Drawing.Color.Azure;
            this.cmbCity.ForeColor = System.Drawing.Color.DodgerBlue;
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Items.AddRange(new object[] {
            "UAE",
            "Egypt",
            "France",
            "Germany",
            "USA",
            "UK"});
            this.cmbCity.Location = new System.Drawing.Point(12, 448);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(217, 33);
            this.cmbCity.TabIndex = 1;
            this.cmbCity.Text = "Choose City";
            this.cmbCity.SelectedIndexChanged += new System.EventHandler(this.cmbCity_SelectedIndexChanged);
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.BackColor = System.Drawing.Color.Azure;
            this.LblName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblName.Location = new System.Drawing.Point(28, 22);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(173, 25);
            this.LblName.TabIndex = 2;
            this.LblName.Tag = "";
            this.LblName.Text = "Enter your Name";
            this.LblName.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblAge
            // 
            this.LblAge.AutoSize = true;
            this.LblAge.BackColor = System.Drawing.Color.Azure;
            this.LblAge.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblAge.Location = new System.Drawing.Point(28, 96);
            this.LblAge.Name = "LblAge";
            this.LblAge.Size = new System.Drawing.Size(156, 25);
            this.LblAge.TabIndex = 5;
            this.LblAge.Tag = "";
            this.LblAge.Text = "Enter your Age";
            this.LblAge.Click += new System.EventHandler(this.label3_Click);
            // 
            // LblCourses
            // 
            this.LblCourses.AutoSize = true;
            this.LblCourses.BackColor = System.Drawing.Color.Azure;
            this.LblCourses.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblCourses.Location = new System.Drawing.Point(28, 279);
            this.LblCourses.Name = "LblCourses";
            this.LblCourses.Size = new System.Drawing.Size(222, 25);
            this.LblCourses.TabIndex = 9;
            this.LblCourses.Tag = "";
            this.LblCourses.Text = "Choose your Courses";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(251, 19);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(263, 30);
            this.textName.TabIndex = 10;
            // 
            // TextAge
            // 
            this.TextAge.Location = new System.Drawing.Point(251, 91);
            this.TextAge.Name = "TextAge";
            this.TextAge.Size = new System.Drawing.Size(263, 30);
            this.TextAge.TabIndex = 13;
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.Azure;
            this.Submit.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Submit.Location = new System.Drawing.Point(132, 552);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(280, 76);
            this.Submit.TabIndex = 14;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbGender
            // 
            this.cmbGender.BackColor = System.Drawing.Color.Azure;
            this.cmbGender.ForeColor = System.Drawing.Color.DodgerBlue;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(28, 157);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(191, 33);
            this.cmbGender.TabIndex = 15;
            this.cmbGender.Text = "Choose Gender";
            this.cmbGender.SelectedIndexChanged += new System.EventHandler(this.cmbGender_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(555, 650);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.TextAge);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.LblCourses);
            this.Controls.Add(this.LblAge);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.ChklCourses);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ChklCourses;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblAge;
        private System.Windows.Forms.Label LblCourses;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox TextAge;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.ComboBox cmbGender;
    }
}

