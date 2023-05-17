using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem
{
    class CarRentalDataAccessClass
    {
        private SqlConnection carRentalConnection;
        string carRentalConnString = ConfigurationManager.ConnectionStrings
            ["CarRentalSystem.Properties.Settings.CarRentalSystemDatabaseConnString"]
            .ConnectionString;
        private SqlConnection GetConnection()
        {
            if (null == carRentalConnection)
                carRentalConnection = new SqlConnection(carRentalConnString);
            return carRentalConnection;
        }//end GetConnection()

        private void OpenConnection()
        {
            if (carRentalConnection.State == System.Data.ConnectionState.Closed)
                carRentalConnection.Open();
        }//end OpenConnection()
        private void CloseConnection()
        {
            carRentalConnection.Close();
        }//end closeConnection()

        private SqlDataReader GetReader(string procNameOrQuery, CommandType cmdType,
           SqlParameter param1 = null, SqlParameter param2 = null,
           SqlParameter param3 = null)
        {
            SqlCommand carRentalSqlCommand = new SqlCommand(procNameOrQuery, this.GetConnection());
            carRentalSqlCommand.CommandType = cmdType;
            if (param1 != null) carRentalSqlCommand.Parameters.Add(param1);
            if (param2 != null) carRentalSqlCommand.Parameters.Add(param2);
            if (param3 != null) carRentalSqlCommand.Parameters.Add(param3);

            try
            {
                this.OpenConnection();
                return carRentalSqlCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                carRentalSqlCommand.Dispose();
            }
        }//end GetReader()

        public DataTable GetTable(string procNameOrQuery, CommandType cmdType,
           SqlParameter param1 = null, SqlParameter param2 = null,
           SqlParameter param3 = null)
        {
            DataTable table = new DataTable();
            SqlDataReader dataReader = null;

            try
            {
                dataReader = GetReader(procNameOrQuery, cmdType, param1, param2, param3);
                table.Load(dataReader);
                dataReader.Close();
                return table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //for inserting values into table
        public int ExecNonQuery(string procOrQuery, CommandType cmdType, SqlParameter param1 = null, SqlParameter param2 = null, SqlParameter param3 = null, SqlParameter param4 = null, SqlParameter param5 = null, SqlParameter param6 = null)
        {
            //instantiate the command object
            SqlCommand crSqlCommand = new SqlCommand(procOrQuery, this.GetConnection());
            crSqlCommand.CommandType = cmdType; //set the command type as incoming
            //cmdType : how the sql command text is being interpreted
            //set the parameters for the sql command(parameters are the incoming values)

            if (param1 != null) crSqlCommand.Parameters.Add(param1);
            if (param2 != null) crSqlCommand.Parameters.Add(param2);
            if (param3 != null) crSqlCommand.Parameters.Add(param3);
            if (param4 != null) crSqlCommand.Parameters.Add(param4);
            if (param5 != null) crSqlCommand.Parameters.Add(param5);
            if (param6 != null) crSqlCommand.Parameters.Add(param6);

            try
            {
                this.OpenConnection();
                return crSqlCommand.ExecuteNonQuery(); //if success it returns an integer
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CloseConnection(); //close the connection even if success or not : doesnt matter 
                //this is necessary for performance improvement
                crSqlCommand.Dispose();
                //dispose off the command
            }
        }

        public Object ExecScalarQuery(string procNameOrQuery, CommandType cmdType, SqlParameter param1 = null, SqlParameter param2 = null, SqlParameter param3 = null, SqlParameter param4 = null, SqlParameter param5 = null, SqlParameter param6 = null)
        {
            //instantiate the command object
            SqlCommand crSqlCommand = new SqlCommand(procNameOrQuery, this.GetConnection());
            crSqlCommand.CommandType = cmdType; //set the command type as incoming


            if (param1 != null) crSqlCommand.Parameters.Add(param1);
            if (param2 != null) crSqlCommand.Parameters.Add(param2);
            if (param3 != null) crSqlCommand.Parameters.Add(param3);
            if (param4 != null) crSqlCommand.Parameters.Add(param4);
            if (param5 != null) crSqlCommand.Parameters.Add(param5);
            if (param6 != null) crSqlCommand.Parameters.Add(param6);

            try
            {
                this.OpenConnection();
                return crSqlCommand.ExecuteScalar(); //if success it returns an integer
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CloseConnection(); //close the connection even if success or not : doesnt matter 
                //this is necessary for performance improvement
                crSqlCommand.Dispose();
                //dispose off the command
            }
        }
    }
}
