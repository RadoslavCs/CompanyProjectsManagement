using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace DataLayer.Models
{
    public class Database 
    {
        #region  Constructors        
        public Database() 
        {
           
        }
        #endregion

        #region Private Fields
        private Models.LogFile logFile = new LogFile();
        #endregion

        #region Private Properties
        private String query;
        private String dbName;        
        private String dbPath;
        private String dbSize;
        private String dbMaxSize;
        private String dbFileGrowth;
        private String logName;
        private String logSize;
        private String logDbMaxSize;
        private String logFileGrowth;
        private String connectionString;
        #endregion

        #region Public Properties


        public string DatabaseName { get => this.dbName; set => this.dbName = @value; }
        public string Query { get => this.query; set => this.query = @value; }
        public string DatabaseFilePath { get => this.dbPath; set => this.dbPath = @value; }
        public string DatabaseSize { get => this.dbSize; set => this.dbSize = @value; }
        public string DatabaseMAXSIZE { get => this.dbMaxSize; set => this.dbMaxSize = @value; }
        public string DatabaseFileGrouth { get => this.dbFileGrowth; set => this.dbFileGrowth = @value; }
        public string LogName { get => this.logName; set => this.logName = @value; }
        public string LogSize { get => this.logSize; set => this.logSize = @value; }
        public string LogDatabaseMAXSIZE { get => this.logDbMaxSize; set => this.logDbMaxSize = @value; }
        public string LogFileGrouth { get => this.logFileGrowth; set => this.logFileGrowth = @value; }
        public string ConnectionString { get => this.connectionString; set => this.connectionString = @value; }

        #endregion

        #region Public Methods        
        /// <summary>
        /// Creates a Database.
        /// </summary>        
        public void CreateDatabase() 
        {     

            try
            {
                String queryCreateDB = $"CREATE DATABASE {dbName} ON PRIMARY " +
                $"(NAME = {dbName}_Data, " +
                $"FILENAME = '{dbPath}{dbName}Data.mdf', " +
                $"SIZE = {dbSize}MB, MAXSIZE = {dbMaxSize}MB, FILEGROWTH = {dbFileGrowth}%)" +
                $"LOG ON (NAME = {logName}_Log, " +
                $"FILENAME = '{dbPath}{logName}Log.ldf', " +
                $"SIZE = {logSize}MB, " +
                $"MAXSIZE = {logDbMaxSize}MB, " +
                $"FILEGROWTH = {logFileGrowth}%)";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                SqlCommand sqlCmd = new SqlCommand(queryCreateDB, sqlConnection);

                sqlConnection.Open();
                sqlCmd.ExecuteNonQuery();
                
                logFile.GetLog($"Info: Database [{dbName}_DB] was created.{Environment.NewLine}");

                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
            catch (Exception ex)
            {
                logFile.GetLog(ex.Message);
                logFile.GetLog(ex.Data.ToString());
            }
           
        }

        /// <summary>
        /// Drops a Database
        /// </summary>
        /// <returns></returns>
        public void DropDatabase() 
        {
            try
            {
                String queryCreateDB = $@"DROP DATABASE {dbName};";

                SqlConnection sqlConnection = new SqlConnection(connectionString);
                SqlCommand sqlCmd = new SqlCommand(queryCreateDB, sqlConnection);

                sqlConnection.Open();
                sqlCmd.ExecuteNonQuery();


                logFile.GetLog($"Info: Database [{dbName}_DB] was droped.{Environment.NewLine}");
               
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }

            }
            catch (Exception ex)
            {
                logFile.GetLog(ex.Message);
                logFile.GetLog(ex.Data.ToString());
            }            

        }
        #endregion
    }
}
