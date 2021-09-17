using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DataLayer.Models
{
    class LogFile
    {
        #region Private Members        
        private const string logFile = "AppLog.txt";
        #endregion

        #region Constructors        
        /// <summary>
        /// Initializing this class will create a new file 
        /// if it does not exist
        /// </summary>
        public LogFile() 
        {
            if (!File.Exists(logFile))
            {
                File.Create(logFile).Close();
            }
        }
        #endregion

        #region Public Methods        
        /// <summary>
        /// Creates a Log File
        /// </summary>
        /// <param name="Message">The input string Message</param>
        public void GetLog(string Message) 
        {
            File.AppendAllText(logFile, $"[{DateTime.Now}]:[{Message}]\n");
            
        }
        #endregion

    }
}
