using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataTier
{
    public class Connections
    {
        //Connection to HP laptop 
        public static SqlConnection sqlConnection = new SqlConnection("Data Source = MATIASJAVEG355A\\SQLEXPRESS; Initial Catalog = ProyectV1; Integrated Security = True");
        //("Data Source = LAPTOP-82S43OE2\\SQLEXPRESS;Initial Catalog = ProyectV1; Integrated Security = True");

        //Open connection
        void OpenConnection()
        {            
            if (sqlConnection.State == ConnectionState.Closed)
            sqlConnection.Open();
        }

        //Close connection
        void CloseConnection()
        {
            if (sqlConnection.State == ConnectionState.Open)
                sqlConnection.Close();
        }

        public void ModifDBE(string sentenceSql, List<Parameters> list)
        {
            SqlCommand sqlCommand;
            try
            {
                OpenConnection();
                sqlCommand = new SqlCommand(sentenceSql, sqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                if (list != null)
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i].parameterDirection == ParameterDirection.Input)
                        {
                            sqlCommand.Parameters.AddWithValue(list[i].Name, list[i].Value);
                        }

                        if (list[i].parameterDirection == ParameterDirection.Output)
                        {
                            sqlCommand.Parameters.Add(list[i].Name, list[i].dbType, list[i].Size).Direction = ParameterDirection.Output;
                        }
                    }

                    sqlCommand.ExecuteNonQuery();
                    //Get output parameters
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (sqlCommand.Parameters[i].Direction == ParameterDirection.Output)
                            list[i].Value = sqlCommand.Parameters[i].Value.ToString();
                    }
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }

            CloseConnection();
            sqlCommand.Dispose();
        }

        //Method for the execution of procedures for INSERT, UPDATE, DELETE
        public void ModifDB(string sentenceSql, List<Parameters> list)
        {
            SqlCommand sqlCommand;
            try
            {
                OpenConnection();
                sqlCommand = new SqlCommand(sentenceSql, sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                if (list != null)
                {
                    for(int i=0; i < list.Count; i++)
                    {
                        if(list[i].parameterDirection == ParameterDirection.Input)
                        {                            
                            sqlCommand.Parameters.AddWithValue(list[i].Name, list[i].Value);
                        }

                        if(list[i].parameterDirection == ParameterDirection.Output)
                        {
                            sqlCommand.Parameters.Add(list[i].Name, list[i].dbType, list[i].Size).Direction = ParameterDirection.Output;
                        }
                    }
                    sqlCommand.ExecuteNonQuery();
                    //Get output parameters
                    for(int i = 0; i < list.Count; i++)
                    {
                        if (sqlCommand.Parameters[i].Direction == ParameterDirection.Output)
                            list[i].Value = sqlCommand.Parameters[i].Value.ToString();
                    }
                }

            }
            catch (Exception exception)
            {
                throw exception;
            }

            CloseConnection();
            sqlCommand.Dispose();
        }


        //Method for recover data with SELECT
        public DataTable GetData(string sentenceSql, List<Parameters> list)
        {
            
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter;

            try
            {

                OpenConnection();
                sqlDataAdapter = new SqlDataAdapter(sentenceSql, sqlConnection);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                if(list != null)
                {
                    for (int i = 0; i < list.Count; i++)
                        sqlDataAdapter.SelectCommand.Parameters.AddWithValue(list[i].Name, list[i].Value);
                }


                sqlDataAdapter.Fill(dataTable);
                sqlDataAdapter.Dispose();
            }
            catch (Exception exception)
            {

                throw exception;
            }

            CloseConnection();
            return dataTable;
            
        }

        public DataTable SearchClient(String clientCode)

        {
            String query = "SELECT ClientCode, ClientAddress1, ClientCity FROM Clients WHERE ClientCode = " + clientCode + ";";
            Console.WriteLine(query);
            DataTable dataTable = new DataTable();
            try
            {
                OpenConnection();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = sqlCommand;
                adapter.Fill(dataTable);
                
                adapter.Dispose();
            }
            catch (Exception exception)
            {
                throw exception; 
            }

            CloseConnection();
           
            return dataTable;

        }

        public String CheckLogin(String userName, String password)
        {
            String queryUserPassword = " SELECT UserName, SecretKey FROM Users WHERE UserName = " + userName + ";";
            _ = new List<string>();
            string result;
            try
            {
                OpenConnection();
                String resultConsultaUser = "";
                String resultConsultaPassword = "";

                SqlCommand sqlCommand = new SqlCommand(queryUserPassword, sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.HasRows)
                {

                    while (sqlDataReader.Read())
                    {

                        resultConsultaUser = sqlDataReader.GetString(0);
                        resultConsultaPassword = sqlDataReader.GetString(1);
                    }
                    sqlDataReader.NextResult();
                }

                if (userName.Equals(resultConsultaUser) && password.Equals(resultConsultaPassword))
                {
                    result = "Authentification correct";
                }
                else if (!userName.Equals(resultConsultaUser))
                {
                    result = "User not exist";
                }
                else if (!password.Equals(resultConsultaPassword))
                {
                    result = "Wrong password";
                }
                else
                {
                    result = "dataread error";
                }

                sqlDataReader.Dispose();
            }
            catch (Exception e)
            {

                throw e;
            }

            CloseConnection();

            return result;
        }

    }
}
