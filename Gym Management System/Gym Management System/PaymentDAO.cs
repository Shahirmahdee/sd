using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Gym_Management_System
{
    class PaymentDAO
    {
 
            private string conString = @"Data Source=Shahir-Dell\SQLEXPRESS;Initial Catalog=gym;Integrated Security=True";
            private SqlConnection sqlConnection;
            private SqlCommand sqlCommand;
            private SqlDataAdapter sqlAdapter;
            private DataSet dataSet;
            public PaymentDAO()
            {
                sqlConnection = new SqlConnection(conString);
            }
            public DataSet GetMember()
            {
                sqlConnection.Open();
                string sqlQuery = "SELECT memberid,name,payment,package,paid,due FROM memberPanel";
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
                string sqlQuery = "SELECT memberid,name,payment,package,paid,due,validity FROM memberPanel where memberid = " + memberid;
                sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
                sqlAdapter = new SqlDataAdapter(sqlCommand);
                dataSet = new DataSet();
                sqlAdapter.Fill(dataSet);
                sqlConnection.Close();
                return dataSet;
            }



 
        

    }
    }

