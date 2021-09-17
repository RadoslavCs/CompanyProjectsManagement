using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Models
{
    public class ConnectionString
    {
        #region Private Properties
        private string _dbConnectionString { get; set; }
        #endregion

        #region Constructors        
        public ConnectionString(string dBConnectionString)
        {
            _dbConnectionString = dBConnectionString;
        }
        #endregion

        #region Public Methods        
        /// <summary>
        /// Get a Database connection string.
        /// </summary>
        /// <returns>Database Connection String</returns>
        public String GetConnectionString() 
        {
            return _dbConnectionString;
        }
        #endregion

    }
}
