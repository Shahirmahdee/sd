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
    public partial class MemberPanel : Form
    {
        private int id=0;
        DataSet dataSet = new DataSet();
        MemberDAO memberDAO = new MemberDAO();
        public MemberPanel()
        {
            InitializeComponent();
        }
        public MemberPanel(int id)
        {
            InitializeComponent();
            this.id = id;
            LoadProfile(id);
        }

        private void LoadProfile(int id)
        {
            dataSet = memberDAO.GetMember(id);
            textBoxId.Text = dataSet.Tables[0].Rows[0]["memberid"].ToString();
            textBoxName.Text = dataSet.Tables[0].Rows[0]["name"].ToString();
            textBoxPhone.Text = dataSet.Tables[0].Rows[0]["phone"].ToString();
            PackageBox.Text = dataSet.Tables[0].Rows[0]["package"].ToString();
            textBoxPayment.Text = dataSet.Tables[0].Rows[0]["payment"].ToString();
            DueBox.Text = dataSet.Tables[0].Rows[0]["due"].ToString();
            validityBox1.Text = dataSet.Tables[0].Rows[0]["validity"].ToString();
        }


        private void MemberPanel_Load(object sender, EventArgs e)
        {

        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login ob = new Login();
            this.Hide();
            ob.ShowDialog();
            this.Close();
        }

        private void PackageBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
