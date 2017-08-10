using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management_System
{
    class MemRegDAO
    {

        private string conString = @"Data Source=Shahir-Dell\SQLEXPRESS;Initial Catalog=gym;Integrated Security=True";
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlAdapter;
        private DataSet dataSet;
        public MemRegDAO()
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
            string sqlQuery = "SELECT * FROM memberPanel WHERE memberid =" + memberid;
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

            string query = "insert into memberPanel values('" + memRegDTO.memberID + "','"
                                                             + memRegDTO.Pass + "','"
                                                           + memRegDTO.NAME + "','"
                                                           + memRegDTO.Phone + "','"
                                                            + memRegDTO.Payment + "','"
                                                           + memRegDTO.Package + "','"
                                                            
                                                           + memRegDTO.Paid + "','"
                                                           + memRegDTO.Due + "','"
                                                           + memRegDTO.Validity + "')"
                                                            ;

            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public void updateMember(MemRegDTO memRegDTO)
        {
            sqlConnection.Open();

            string query = "update memberPanel set pass = '" + memRegDTO.Pass +
                                               "', name = '" + memRegDTO.NAME +
                                               "', phone = '" + memRegDTO.Phone +
                                                 "', payment = '" + memRegDTO.Payment +
                                                    "', package = '" + memRegDTO.Package +
                                                        "', paid = '" + memRegDTO.Paid +
                                                        "', due = '" + memRegDTO.Due +
                                                     "', validity = '" + memRegDTO.Validity +
                                                      "' where memberid = '"  + memRegDTO.memberID + "'";
             

            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close(); 
        }
    }
}
