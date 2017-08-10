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
    public partial class Payment : Form
    {
        private int id = 0;
        DataSet dataSet = new DataSet();
        MemberDAO memberDAO = new MemberDAO();
        PaymentDAO paymentDAO = new PaymentDAO();
        MemRegDAO memregDAO = new MemRegDAO();
        Member_Registration a = new Member_Registration();


        public Payment()
        {
            InitializeComponent();
            loadmember();
        }
        private void loadmember()
        {
            dataGridView1.DataSource = paymentDAO.GetMember().Tables[0];

        }


        public Payment(int id)
        {
            InitializeComponent();
            this.id = id;
           // LoadProfile(id);
           // dataGridView1_CellContentClick();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Payment_Load(object sender, EventArgs e)
        {

        }

         

         private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
         {
             if (dataGridView1.SelectedRows.Count == 1)
             {
                 int idx = dataGridView1.SelectedRows[0].Index;

               
             }
         }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminPanel ob = new AdminPanel();
            this.Hide();
            ob.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
        }

        /* private void button1_Click(object sender, EventArgs e)
         {
             int id = Convert.ToInt32(IdBox.Text);
             string name = NameBox.Text;
             int age = Convert.ToInt32(AgeBox.Text);
             int salary = Convert.ToInt32(SalaryBox.Text);

             memregDAO.updateMember(new MemRegDTO(id, name, age, salary));
             LoadCustomersInfo();
         } */
    }
}
