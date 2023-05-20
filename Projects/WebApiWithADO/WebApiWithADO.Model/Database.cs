using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WebApiWithADO.Model
{
    public class Database
    {
        string connectionString = "Server=125.253.121.171;Database=data_HocBackEnd_LT;uid=user22401;pwd=123456789";
        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataAdapter da;

        public Database()
        {
            cnn = new SqlConnection(connectionString);
        }

        //Select
        public DataTable GetDataTable(ref string err,string commandText,CommandType commandType,params SqlParameter[] sqlParameters)
        {
            DataTable dataTable = new DataTable();
            try
            {
                //1. Mo ket noi
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
                cnn.Open();
                //2. thuc hien thao tac select
                cmd = new SqlCommand(commandText, cnn);
                cmd.CommandType = commandType;
                cmd.CommandTimeout = 3600;
                //add tham so
                if (sqlParameters != null) 
                { 
                    foreach (var item in sqlParameters)
                    {
                        cmd.Parameters.Add(item);
                    }
                }
                //goi du lieu ve dataTable
                da = new SqlDataAdapter(cmd);
                da.Fill(dataTable);
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            finally
            {
                //3. dong ke noi
                cnn.Close();
            }
            return dataTable;
        }

        //Insert, Update, Delete
        public int MyExcuteNonQuery(ref string err, string commandText, CommandType commandType, params SqlParameter[] sqlParameters)
        {
            int result = 0;
            try
            {
                //1. Mo ket noi
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
                cnn.Open();
                //2. thuc hien thao tac select
                cmd = new SqlCommand(commandText, cnn);
                cmd.CommandType = commandType;
                cmd.CommandTimeout = 3600;
                //add tham so
                if (sqlParameters != null)
                {
                    foreach (var item in sqlParameters)
                    {
                        cmd.Parameters.Add(item);
                    }
                }
                //goi du lieu ve dataTable
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            finally
            {
                //3. dong ke noi
                cnn.Close();
            }
            return result;
        }

    }
}
