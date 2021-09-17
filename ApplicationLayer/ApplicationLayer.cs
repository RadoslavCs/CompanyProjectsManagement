using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace ApplicationLayer
{
    public class ApplicationLayer
    {
        
        #region Private Members
        private DataLayer.DataOperation dataOperation = new DataOperation();
        #endregion

        #region Public Methods
        /// <summary>
        /// Inserts project into the projects
        /// </summary>
        /// <param name="prjName">Project Name</param>
        /// <param name="abbreviation">Project Abbreviation</param>
        /// <param name="customer">Customer Name</param>
        /// <param name="xmlFile">Path to the xml file</param>
        public void InsertProject(string prjName, string abbreviation, string customer, string xmlFile)
        {
            try
            {
                dataOperation.InsertData(prjName, abbreviation, customer, xmlFile); 
            }
            catch (Exception ex)
            {
                dataOperation.GetLog(ex.Message);
                dataOperation.GetLog(ex.Data.ToString());
            }
            
        }

        /// <summary>
        /// Updates existing project.
        /// </summary>
        /// <param name="prjID">The project Id number.</param>
        /// <param name="propertyName">The project property name.</param>
        /// <param name="propertyValue">The value of the property.</param>
        /// <param name="xmlFile">Path to the xml file</param>
        public void UpdateProject(int prjID, string propertyName, string propertyValue, string xmlFile)
        {
            try
            {
                dataOperation.UpdateData(prjID, propertyName, propertyValue, xmlFile);
            }
            catch (Exception ex)
            {
                dataOperation.GetLog(ex.Message);
                dataOperation.GetLog(ex.Data.ToString());
            }
            
        }

        /// <summary>
        /// Removes all dat of the project from the projects.xml file.
        /// </summary>
        /// <param name="prjID">The project Id number.</param>
        /// <param name="xmlFile">Path to the xml file</param>
        public void DeleteProject(int prjID, string xmlFile)
        {
            try
            {
                dataOperation.RemoveData(prjID, xmlFile);
            }
            catch (Exception ex)
            {
                dataOperation.GetLog(ex.Message);
                dataOperation.GetLog(ex.Data.ToString());
            }
        }

        /// <summary>
        /// Reads XML data into dataset by using specified file.
        /// </summary>
        /// <param name="xmlFile">A raw string path to the xml file</param>
        /// <returns>Projects Dataset</returns>
        public System.Data.DataSet GetProjectsDataset(string xmlFile)
        {
            try
            {
                return dataOperation.GetPojectsDataSet(xmlFile);
            }
            catch (Exception ex)
            {
                dataOperation.GetLog(ex.Message);
                dataOperation.GetLog(ex.Data.ToString());

                return null;
            }
        }

        /// <summary>
        /// Creates a new user
        /// </summary>
        /// <param name="UserName">The User name.</param>
        /// <param name="UserPasword">The User Password.</param>
        /// <param name="ConfirmUserPassword">The conformation of the new user password</param>
        public void GetNewUser(string UserName, string UserPasword, string ConfirmUserPassword) 
        {
            try
            {
                dataOperation.GetNewUser(UserName,UserPasword,ConfirmUserPassword);
            }
            catch (Exception ex)
            {
                dataOperation.GetLog(ex.Message);
                dataOperation.GetLog(ex.Data.ToString());
            }
        }


        /// <summary>
        /// Checks existing user credentials.
        /// </summary>
        /// <param name="UserName">The User name. </param>
        /// <param name="UserPassword">The User Password.</param>
        /// <returns></returns>
        public bool CheckExistingUser(string UserName, string UserPassword) 
        {
            try
            {
                return dataOperation.CeckUser(UserName,UserPassword);
            }
            catch (Exception ex)
            {
                dataOperation.GetLog(ex.Message);
                dataOperation.GetLog(ex.Data.ToString());
                return false;
            }
        }


        /// <summary>
        /// This Method write logs into log file
        /// </summary>
        /// <param name="Message">A Message which is recorded into the log file. </param>
        public void GetLog(string Message)
        {
            try
            {
                dataOperation.GetLog(Message);
            }
            catch (Exception ex)
            {
                GetLog(ex.Message);
                GetLog(ex.Data.ToString());
            }

        }

        #endregion
    }
}
