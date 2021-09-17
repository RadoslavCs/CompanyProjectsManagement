using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.IO;

namespace DataLayer.Models

{
    class DatabaseColumn
    {
        #region Private Fields
        private Models.LogFile logFile = new LogFile();

        private String databaseName;
        private String tableName;
        private String connectionString;
        private String databasePath;
        #endregion

        #region Constructors
        public DatabaseColumn()
        {

        }

        public DatabaseColumn(String DatabaseName, String TableName, String ConnectionString, String DatabasePath)
        {

            databaseName = DatabaseName;
            tableName = TableName;
            connectionString = ConnectionString;
            databasePath = DatabasePath;
        }
        #endregion

        #region Public Properties
        public string DatabaseName { get => databaseName; set => databaseName = value; }
        public string TableName { get => tableName; set => tableName = value; }
        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public string DatabasePath { get => databasePath; set => databasePath = value; }
        #endregion

        #region Public Methods
        
        /// <summary>
        /// Creates a column in the database
        /// </summary>
        /// <param name="ColumnName">Column Name</param>
        /// <param name="CharactersCount">The count of the column character</param>
        /// <param name="IsNull">The column can have a null value</param>
        public void CreateColumn(String ColumnName, Int32 CharactersCount, bool IsNull) 
        {
            try
            {
                String nullNotNull = String.Format(IsNull == true ? "null" : "not null");
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();


                    //ALTER TABLE dbo.doc_exa ADD column_b VARCHAR(20) NULL, column_c INT NULL ;
                    String cmd = $@"USE {databaseName} " +
                        $@"ALTER TABLE dbo.{tableName} ADD {ColumnName} VARCHAR({CharactersCount.ToString()}) {nullNotNull};";

                    using (SqlCommand command = new SqlCommand(cmd, connection))
                        command.ExecuteNonQuery();

                   logFile.GetLog($"Info: DatabaseColumn [{ColumnName}] was created.{Environment.NewLine}");
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
