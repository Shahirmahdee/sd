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
    public partial class EmployeeReg : Form
    {
        EmployeeDAO employeeDAO = new EmployeeDAO();
        public EmployeeReg()
        {
            InitializeComponent();
            loademployee();
        }

        private void loademployee()
        {
            dataGridView1.DataSource = employeeDAO.GetMember().Tables[0];

        }
        private void button1_Click(object sender, EventArgs e)
        {
            int employeeid = Convert.ToInt32(IdBox.Text);
            string name = NameBox.Text;
            int Phone = Convert.ToInt32(PhoneBox.Text);
            string joinigdate = JoinBox.Text;
            string pass = PassBox.Text;
            int salary = Convert.ToInt32(SalaryBox.Text);
           // string package = PackageBox.Text;
           // int due = Convert.ToInt32(DueBox.Text);
            string position = PsitionBox.Text;

            EmployeeDAO b = new EmployeeDAO();
            b.createEmployee(new EmployeeDTO(name, employeeid, pass, Phone,joinigdate, position, salary));
            loademployee();

            IdBox.Clear();
            PassBox.Clear();
            NameBox.Clear();
            PhoneBox.Clear();
            JoinBox.Clear();
            PsitionBox.Clear();
            SalaryBox.Clear();
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            AdminPanel ob = new AdminPanel();
            this.Hide();
            ob.ShowDialog();
            this.Close();
        }
    }
}
