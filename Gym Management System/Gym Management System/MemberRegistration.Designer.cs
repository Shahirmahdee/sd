namespace Gym_Management_System
{
    partial class Member_Registration
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.PhonBox = new System.Windows.Forms.TextBox();
            this.PaymentBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.PackageBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DueBox = new System.Windows.Forms.TextBox();
            this.PaidBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ValidityBox = new System.Windows.Forms.TextBox();
            this.Updatebut = new System.Windows.Forms.Button();
            this.Delate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone Number";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Payment";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Member Id";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(98, 23);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(144, 20);
            this.NameBox.TabIndex = 6;
            this.NameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // IdBox
            // 
            this.IdBox.Location = new System.Drawing.Point(98, 61);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(144, 20);
            this.IdBox.TabIndex = 7;
         //   this.IdBox.TextChanged += new System.EventHandler(this.IdBox_TextChanged);
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(98, 96);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(144, 20);
            this.PassBox.TabIndex = 9;
            this.PassBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // PhonBox
            // 
            this.PhonBox.Location = new System.Drawing.Point(98, 125);
            this.PhonBox.Name = "PhonBox";
            this.PhonBox.Size = new System.Drawing.Size(144, 20);
            this.PhonBox.TabIndex = 10;
            this.PhonBox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // PaymentBox
            // 
            this.PaymentBox.Location = new System.Drawing.Point(98, 208);
            this.PaymentBox.Name = "PaymentBox";
            this.PaymentBox.Size = new System.Drawing.Size(144, 20);
            this.PaymentBox.TabIndex = 11;
            this.PaymentBox.TextChanged += new System.EventHandler(this.Payment_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(98, 322);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 13;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(248, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(711, 265);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Package";
            // 
            // PackageBox
            // 
            this.PackageBox.FormattingEnabled = true;
            this.PackageBox.Items.AddRange(new object[] {
            "One Month",
            "Three Months",
            "Four Months"});
            this.PackageBox.Location = new System.Drawing.Point(98, 175);
            this.PackageBox.Name = "PackageBox";
            this.PackageBox.Size = new System.Drawing.Size(144, 21);
            this.PackageBox.TabIndex = 16;
            this.PackageBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Paid";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Due";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // DueBox
            // 
            this.DueBox.Location = new System.Drawing.Point(98, 267);
            this.DueBox.Name = "DueBox";
            this.DueBox.Size = new System.Drawing.Size(144, 20);
            this.DueBox.TabIndex = 19;
            // 
            // PaidBox
            // 
            this.PaidBox.Location = new System.Drawing.Point(98, 240);
            this.PaidBox.Name = "PaidBox";
            this.PaidBox.Size = new System.Drawing.Size(144, 20);
            this.PaidBox.TabIndex = 20;
            this.PaidBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 299);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Validity Till";
            // 
            // ValidityBox
            // 
            this.ValidityBox.Location = new System.Drawing.Point(98, 293);
            this.ValidityBox.Name = "ValidityBox";
            this.ValidityBox.Size = new System.Drawing.Size(144, 20);
            this.ValidityBox.TabIndex = 22;
            // 
            // Updatebut
            // 
            this.Updatebut.Location = new System.Drawing.Point(564, 322);
            this.Updatebut.Name = "Updatebut";
            this.Updatebut.Size = new System.Drawing.Size(75, 23);
            this.Updatebut.TabIndex = 23;
            this.Updatebut.Text = "Update";
            this.Updatebut.UseVisualStyleBackColor = true;
            this.Updatebut.Click += new System.EventHandler(this.Updatebut_Click);
            // 
            // Delate
            // 
            this.Delate.Location = new System.Drawing.Point(803, 321);
            this.Delate.Name = "Delate";
            this.Delate.Size = new System.Drawing.Size(75, 23);
            this.Delate.TabIndex = 24;
            this.Delate.Text = "Delate";
            this.Delate.UseVisualStyleBackColor = true;
            // 
            // Member_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 371);
            this.Controls.Add(this.Delate);
            this.Controls.Add(this.Updatebut);
            this.Controls.Add(this.ValidityBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PaidBox);
            this.Controls.Add(this.DueBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PackageBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PaymentBox);
            this.Controls.Add(this.PhonBox);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.IdBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Member_Registration";
            this.Text = "ll";
            this.Load += new System.EventHandler(this.Member_Registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.TextBox PhonBox;
        private System.Windows.Forms.TextBox PaymentBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox PackageBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox DueBox;
        private System.Windows.Forms.TextBox PaidBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ValidityBox;
        private System.Windows.Forms.Button Updatebut;
        private System.Windows.Forms.Button Delate;
    }
}