using System.Data;
using Microsoft.Data.SqlClient;

namespace CafePos.Models
{
    #region Stored Procedure
    public static class StoredProcedure
    {
        public static SP_Parameter CreateParameter(string name, string value, string datatype)
        {
            SP_Parameter sp_Parameter = new SP_Parameter()
            {
                ParameterName = name,
                ParameterValue = value,
                DataType = datatype
            };
            return sp_Parameter;
        }
        public async static Task<DataSet> GetDataSet(string query)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, GlobalConnectionString.Connection());
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            return await Task.Run(() => dataSet);
        }

        #region  Data Table
        public async static Task<DataTable> GetDataTable(string query)
        {
            try
            {
                SqlConnection connectionString = new SqlConnection(GlobalConnectionString.ConnectionString());
                DataTable dataTable = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString);
                adapter.Fill(dataTable);
                return await Task.Run(() => dataTable);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async static Task<DataTable> GetDataTable(string spName, params SP_Parameter[] spParameters)
        {
            try
            {
                SqlConnection connectionString = new SqlConnection(GlobalConnectionString.ConnectionString());
                using (SqlCommand com = new SqlCommand(spName, connectionString))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    int totalparameters = spParameters.Length;
                    foreach (var parameter in spParameters)
                    {
                        var name = parameter.ParameterName;
                        object value = null;

                        if (parameter.DataType == "string")
                        {
                            value = Convert.ToString(parameter.ParameterValue);
                        }
                        else if (parameter.DataType == "int")
                        {
                            value = Convert.ToInt32(parameter.ParameterValue);
                        }
                        else if (parameter.DataType == "double")
                        {
                            value = Convert.ToDouble(parameter.ParameterValue);
                        }
                        else if (parameter.DataType == "decimal")
                        {
                            value = Convert.ToDecimal(parameter.ParameterValue);
                        }
                        //else if (parameter.DataType == "decimal")
                        //{
                        //    value = Convert.ToDecimal(parameter.ParameterValue);
                        //}
                        else
                        {
                            value = Convert.ToString(parameter.ParameterValue);
                        }
                        com.Parameters.AddWithValue(name, value);

                    }
                    DataTable dataTable = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(com);
                    adapter.Fill(dataTable);
                    return await Task.Run(() => dataTable);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        public static int GetExecuteNonQuery(string spName, params SP_Parameter[] spParameters)
        {
            SqlConnection connectionString = new SqlConnection(GlobalConnectionString.ConnectionString());
            connectionString.Open();
            SqlTransaction transaction;
            transaction = connectionString.BeginTransaction();
            try
            {
                using (SqlCommand com = new SqlCommand(spName, connectionString, transaction))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    int totalparameters = spParameters.Length;
                    foreach (var parameter in spParameters)
                    {
                        var name = parameter.ParameterName;
                        object value = null;

                        if (parameter.DataType == "string")
                        {
                            value = Convert.ToString(parameter.ParameterValue);
                        }
                        else if (parameter.DataType == "int")
                        {
                            value = Convert.ToInt64(parameter.ParameterValue);
                        }
                        else if (parameter.DataType == "double")
                        {
                            value = Convert.ToDouble(parameter.ParameterValue);
                        }
                        else if (parameter.DataType == "decimal")
                        {
                            value = Convert.ToDecimal(parameter.ParameterValue);
                        }
                        else if (parameter.DataType == "datetime")
                        {
                            value = Convert.ToDateTime(parameter.ParameterValue);
                        }
                        else if (parameter.DataType == "Bool")
                        {
                            value = Convert.ToBoolean(parameter.ParameterValue);
                        }
                        else
                        {
                            value = Convert.ToString(parameter.ParameterValue);
                        }
                        com.Parameters.AddWithValue(name, value);
                    }

                    int GetValue = com.ExecuteNonQuery();
                    transaction.Commit();
                    connectionString.Close();
                    return GetValue;
                }
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                return -1;
            }

        }
        public static string GetExecuteNonQueryM(string spName, params SP_Parameter[] spParameters)
        {
            SqlConnection connectionString = new SqlConnection(GlobalConnectionString.ConnectionString());
            connectionString.Open();
            SqlTransaction transaction;
            transaction = connectionString.BeginTransaction();
            try
            {
                using (SqlCommand com = new SqlCommand(spName, connectionString, transaction))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    int totalparameters = spParameters.Length;
                    foreach (var parameter in spParameters)
                    {
                        var name = parameter.ParameterName;
                        object value = null;

                        if (parameter.DataType == "string")
                        {
                            value = Convert.ToString(parameter.ParameterValue);
                        }
                        else if (parameter.DataType == "int")
                        {
                            value = Convert.ToInt64(parameter.ParameterValue);
                        }
                        else if (parameter.DataType == "double")
                        {
                            value = Convert.ToDouble(parameter.ParameterValue);
                        }
                        else if (parameter.DataType == "decimal")
                        {
                            value = Convert.ToDecimal(parameter.ParameterValue);
                        }
                        else if (parameter.DataType == "datetime")
                        {
                            value = Convert.ToDateTime(parameter.ParameterValue);
                        }
                        else if (parameter.DataType == "Bool")
                        {
                            value = Convert.ToBoolean(parameter.ParameterValue);
                        }
                        else
                        {
                            value = Convert.ToString(parameter.ParameterValue);
                        }
                        com.Parameters.AddWithValue(name, value);
                    }
                    com.ExecuteNonQuery();
                    transaction.Commit();
                    connectionString.Close();
                    return "true";
                }
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                return ex.Message;
            }
        }

    }

    #endregion

    #region SP Parameter
    public class SP_Parameter
    {
        public string ParameterName { get; set; }
        public string ParameterValue { get; set; }
        public string DataType { get; set; }
    }

    #endregion

    #region Global Connection String
    public static class GlobalConnectionString
    {
        public static string ConnectionString()
        {
            return @"Server=. ;Database=ZADSOL_CAFE_ELITE_GRILL_2.0 ;  Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;";
            //return @"Server=. ;Database=CafePos;  Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;";
            //return @"Server=UMERPC\SQLEXPRESS ;Database=POS ; Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;";
        }
        public static SqlConnection Connection()
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString());
            return sqlConnection;
        }
    }
    
    #endregion

}