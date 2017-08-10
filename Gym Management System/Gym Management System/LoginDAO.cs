using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management_System
{
    class LoginDAO
    {
        private string conString = @"Data Source=Shahir-Dell\SQLEXPRESS;Initial Catalog=gym;Integrated Security=True";
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlAdapter;
        private DataSet dataSet;
        public LoginDAO()
        {
            sqlConnection = new SqlConnection(conString);
        }
        public bool verifyLogin(LoginDTO loginDTO)
        {
            bool status = false;
            string sqlQuery = "";
            int id = 0;
            if (loginDTO.USERTYPE == "ADMIN")
            {
                sqlQuery = "SELECT id FROM adminPanel WHERE id = " + loginDTO.ID + " AND pass = '" + loginDTO.PASSWORD + "'";
            }
            else if (loginDTO.USERTYPE == "MEMBER")
            {
                sqlQuery = "SELECT memberid FROM memberPanel WHERE memberid = " + loginDTO.ID + " AND pass = '" + loginDTO.PASSWORD + "'";
            }
             
            else if (loginDTO.USERTYPE == "EMPLOYEE")
            {
                sqlQuery = "SELECT employeeid FROM employeePanel WHERE employeeid = " + loginDTO.ID + " AND passw = '" + loginDTO.PASSWORD + "'";
            }
            sqlConnection.Open();
            sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            sqlAdapter = new SqlDataAdapter(sqlCommand);
            dataSet = new DataSet();
            sqlAdapter.Fill(dataSet);

            if (loginDTO.USERTYPE == "ADMIN")
            {
                foreach (DataTable dateTable in dataSet.Tables)
                {
                    foreach (DataRow dataRow in dateTable.Rows)
                    {
                        foreach (DataColumn dataColumn in dateTable.Columns)
                        {
                            id = Convert.ToInt32(dataRow["id"].ToString());
                        }
                    }
                }
            }
            else if (loginDTO.USERTYPE == "MEMBER")
            {
                foreach (DataTable dateTable in dataSet.Tables)
                {
                    foreach (DataRow dataRow in dateTable.Rows)
                    {
                        foreach (DataColumn dataColumn in dateTable.Columns)
                        {
                            id = Convert.ToInt32(dataRow["memberid"].ToString());
                        }
                    }
                }
            }

            else if (loginDTO.USERTYPE == "EMPLOYEE")
            {
                foreach (DataTable dateTable in dataSet.Tables)
                {
                    foreach (DataRow dataRow in dateTable.Rows)
                    {
                        foreach (DataColumn dataColumn in dateTable.Columns)
                        {
                            id = Convert.ToInt32(dataRow["employeeid"].ToString());
                        }
                    }
                }
            }

            if (id > 0)
            {
                status = true;
            }
            sqlConnection.Close();
            return status;
        }
    }
}
