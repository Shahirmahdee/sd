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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Member_Registration ob = new Member_Registration();
            this.Hide();
            ob.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Payment ob = new Payment();
            this.Hide();
            ob.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login ob = new Login();
            this.Hide();
            ob.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EmployeeReg ob = new EmployeeReg();
            this.Hide();
            ob.ShowDialog();
            this.Close();
        }
    }
}
