using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace DataLayer.Models
{
    class DatabaseTable 
    {
        #region Private Fields
        private Models.LogFile logFile = new LogFile();
        #endregion

        #region Public Methods        
        /// <summary>
        /// Creates a DatabaseTable
        /// </summary>
        /// <param name="DatabaseName"></param>
        /// <param name="TableName"></param>
        /// <param name="dbPath"></param>
        /// <param name="Log"></param>
        /// <param name="ConnectionString"></param>
        public void CreateTable( String DatabaseName,
            String TableName, 
            String dbPath, 
            String Log, 
            String ConnectionString) 
        {            
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    
                    String cmd = $@"USE {DatabaseName}  "+
                        $@"CREATE TABLE dbo.{TableName} ( "+
                        "ID int PRIMARY KEY NOT NULL);";

                    using (SqlCommand command = new SqlCommand(cmd, connection))
                        command.ExecuteNonQuery();                    

                    this.logFile.GetLog($"Info: DatabaseTable [{TableName}] was created.{Environment.NewLine}");
                }
            }
            catch (Exception ex)
            {                
                this.logFile.GetLog(ex.Message);
                this.logFile.GetLog(ex.Data.ToString());
            }
            
        }

        #endregion
    }
}
