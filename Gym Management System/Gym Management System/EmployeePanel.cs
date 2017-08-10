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
    public partial class EmployeePanel : Form
    {
        public EmployeePanel()
        {
            InitializeComponent();
        }

        private int employeeid = 0;
        DataSet dataSet = new DataSet();
        EmployeeDAO employeeDAO = new EmployeeDAO();
         
        public EmployeePanel(int id)
        {
            InitializeComponent();
            this.employeeid = id;
            LoadProfile(id);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

          private void LoadProfile(int employeeid)
           {
               dataSet = employeeDAO.GetEmployee(employeeid);
               textBoxId.Text = dataSet.Tables[0].Rows[0]["employeeid"].ToString();
               textBoxName.Text = dataSet.Tables[0].Rows[0]["employeename"].ToString();
               textBoxPhone.Text = dataSet.Tables[0].Rows[0]["phone"].ToString();
              // PackagBox.Text = dataSet.Tables[0].Rows[0]["package"].ToString();
               textBoxJoining.Text = dataSet.Tables[0].Rows[0]["joiningDate"].ToString();
               textBoxPsition.Text = dataSet.Tables[0].Rows[0]["position"].ToString();
              // validityBox1.Text = dataSet.Tables[0].Rows[0]["validity"].ToString();
           }

        private void button1_Click(object sender, EventArgs e)
        {
            Login ob = new Login();
            this.Hide();
            ob.ShowDialog();
            this.Close();
        }
    }
}
