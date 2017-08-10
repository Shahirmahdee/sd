using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management_System
{
    class MemberDAO
    {
        private string conString = @"Data Source=Shahir-Dell\SQLEXPRESS;Initial Catalog=gym;Integrated Security=True";
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlAdapter;
        private DataSet dataSet;
        public MemberDAO()
        {
            sqlConnection = new SqlConnection(conString);
        }
        public DataSet GetMember()
        {
            sqlConnection.Open();
            string sqlQuery = "SELECT * FROM memberPanel";
            sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            sqlAdapter = new SqlDataAdapter(sqlCommand);
            dataSet = new DataSet();
            sqlAdapter.Fill(dataSet);
            sqlConnection.Close();
            return dataSet;
        }
        public DataSet GetMember(int memberid)
        {
            sqlConnection.Open();
            string sqlQuery = "SELECT * FROM memberPanel where memberid = "+memberid;
            sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            sqlAdapter = new SqlDataAdapter(sqlCommand);
            dataSet = new DataSet();
            sqlAdapter.Fill(dataSet);
            sqlConnection.Close();
            return dataSet;
        }
        

        public void createMember(MemRegDTO memRegDTO)
        {
            sqlConnection.Open();

            string query = "insert into Memberinfo values('" + memRegDTO.memberID + "','"
                                                           + memRegDTO.NAME + "','"
                                                           + memRegDTO.Pass + "','"
                                                           + memRegDTO.Payment + "','"
                                                           + memRegDTO.Paid + "','"
                                                           + memRegDTO.Due + "','"
                                                           + memRegDTO.Package + "','"
                                                           + memRegDTO.Validity + "')";

            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

    }
}
