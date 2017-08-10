using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Gym_Management_System
{
    class EmployeeDAO
    {
        private string conString = @"Data Source=Shahir-Dell\SQLEXPRESS;Initial Catalog=gym;Integrated Security=True";
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlAdapter;
        private DataSet dataSet;
        public EmployeeDAO()
        {
            sqlConnection = new SqlConnection(conString);
        }
        public DataSet GetMember()
        {
            sqlConnection.Open();
            string sqlQuery = "SELECT * FROM employeePanel";
            sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            sqlAdapter = new SqlDataAdapter(sqlCommand);
            dataSet = new DataSet();
            sqlAdapter.Fill(dataSet);
            sqlConnection.Close();
            return dataSet;
        }
        public DataSet GetEmployee(int employeeid)
        {
            sqlConnection.Open();
            string sqlQuery = "SELECT * FROM employeePanel WHERE employeeid =" + employeeid;
            sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            sqlAdapter = new SqlDataAdapter(sqlCommand);
            dataSet = new DataSet();
            sqlAdapter.Fill(dataSet);
            sqlConnection.Close();
            return dataSet;
        }
        public void createEmployee(EmployeeDTO employeeDTO)
        {
            sqlConnection.Open();

            string query = "insert into employeePanel values('" + employeeDTO.NAME + "','" 
                                                            + employeeDTO.Employeeid + "','"
                                                             + employeeDTO.Pass + "','"
                                                            
                                                           + employeeDTO.Phone + "','"
                                                            + employeeDTO.JoiningDate + "','"
                                                           + employeeDTO.Position + "','"

                                                            
                                                            
                                                           + employeeDTO.Salary + "')"
                                                            ;

            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        
    }
}
