using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Management_System
{
    public partial class Member_Registration : Form
    {
        MemRegDAO memberDAO = new MemRegDAO();
        public Member_Registration()
        {
            InitializeComponent();
            loadmember();
        }
        private void loadmember()
        {
            dataGridView1.DataSource = memberDAO.GetMember().Tables[0];

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            AdminPanel ob = new AdminPanel();
            this.Hide();
            ob.ShowDialog();
            this.Close();
        }
        /* private void LoadCustomersInfo()
         {
             MemberInfoGridView.DataSource = MemRegDAO.getCustomers().Tables[0];
         } */

        private void LoadCustomersInfo()
        {
            dataGridView1.DataSource = memberDAO.GetMember().Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int idx = dataGridView1.SelectedRows[0].Index;

                IdBox.Text = dataGridView1.Rows[idx].Cells[0].Value.ToString();
                NameBox.Text = dataGridView1.Rows[idx].Cells[2].Value.ToString();
                PassBox.Text = dataGridView1.Rows[idx].Cells[1].Value.ToString();
                PhonBox.Text = dataGridView1.Rows[idx].Cells[3].Value.ToString();
                PaymentBox.Text = dataGridView1.Rows[idx].Cells[4].Value.ToString();
                PaidBox.Text = dataGridView1.Rows[idx].Cells[6].Value.ToString();
                DueBox.Text = dataGridView1.Rows[idx].Cells[7].Value.ToString();
                PackageBox.Text = dataGridView1.Rows[idx].Cells[5].Value.ToString();
                ValidityBox.Text = dataGridView1.Rows[idx].Cells[8].Value.ToString();
/*
                string memberid = dataGridView1.SelectedRows[0].Cells[0].Value + string.Empty;
                string pass = dataGridView1.SelectedRows[0].Cells[1].Value + string.Empty;

                IdBox.Text = memberid;
                PassBox.Text = pass;
                */
            }

         /*  else if (dataGridView1.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                string memberid = dataGridView1.SelectedRows[0].Cells[0].Value + string.Empty;
                string pass = dataGridView1.SelectedRows[0].Cells[1].Value + string.Empty;

                IdBox.Text = memberid;
                PassBox.Text = pass;
            } */



        }
        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdBox.Text);
            string name = NameBox.Text;
            int Phon = Convert.ToInt32(PhonBox.Text);
            string payment = PaymentBox.Text;
            string pass = PassBox.Text;
            int paid = Convert.ToInt32(PaidBox.Text);
            string package = PackageBox.Text;
            int due = Convert.ToInt32(DueBox.Text);
            string validity = ValidityBox.Text;

            MemRegDAO b = new MemRegDAO();
            b.createMember(new MemRegDTO(id, pass,name,Phon, payment,package,paid,due,validity));
            LoadCustomersInfo();

            IdBox.Clear();
            PassBox.Clear();
            NameBox.Clear();
            PhonBox.Clear();
            PaymentBox.Clear();
            PaidBox.Clear();
            DueBox.Clear();
            ValidityBox.Clear();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Member_Registration_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Payment_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

     

        private void Updatebut_Click(object sender, EventArgs e)
        {
           // double.Parse(IdBox, CultureInfo.InvariantCulture);
            int id = Convert.ToInt32(IdBox.Text);
            string name = NameBox.Text;
            int Phon = Convert.ToInt32(PhonBox.Text);
            string payment = PaymentBox.Text;
            string pass = PassBox.Text;
            int paid = Convert.ToInt32(PaidBox.Text);
            string package = PackageBox.Text;
            int due = Convert.ToInt32(DueBox.Text);
            string validity = ValidityBox.Text;

            MemRegDAO b = new MemRegDAO();
            b.updateMember(new MemRegDTO(id, pass, name, Phon, payment, package, paid, due, validity));
            LoadCustomersInfo();
        }

        /* private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
         {

         } */
    }
}
