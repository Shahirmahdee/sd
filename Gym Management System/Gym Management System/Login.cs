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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string userType = typeComboBox.SelectedItem.ToString();
            int id = Convert.ToInt32(((UpDownBase)numericUpDownId).Text);
            string password = textBoxPassword.Text;

            

            LoginDAO loginDAO = new LoginDAO();
            bool verification = loginDAO.verifyLogin(new LoginDTO(userType, id, password));
           // MessageBox.Show(""+verification);
            
            if (verification == true)
            {
                //MessageBox.Show("Ok");
                if (userType == "ADMIN")
                {
                    AdminPanel adminPanel = new AdminPanel();
                    this.Hide();
                    adminPanel.ShowDialog();
                    this.Close();
                }
                else if (userType == "MEMBER")
                {
                    MemberPanel memberPanel = new MemberPanel(id);
                    this.Hide();
                    memberPanel.ShowDialog();
                    this.Close();
                }
                else if (userType == "EMPLOYEE")
                {
                    EmployeePanel employeePanel = new EmployeePanel(id);
                    this.Hide();
                    employeePanel.ShowDialog();
                    this.Close();
                }
            }
            else if (verification == false)
            {
                MessageBox.Show("Login failed");
            }
            
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
