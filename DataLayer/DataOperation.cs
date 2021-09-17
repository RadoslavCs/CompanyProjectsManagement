using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;

namespace DataLayer
{
    public class DataOperation
    {
        #region Private Members        
        private Models.Project project = new Models.Project();
        #endregion

        #region Public Methods
        /// <summary>
        /// The method inserts a new project data
        /// </summary>        
        /// <param name="prjName">A String project name.</param>
        /// <param name="abbreviation">A String project abbreviation.</param>
        /// <param name="customer">A String customer name.</param>        
        /// <param name="xmlFile">A raw string path to the xml file</param>
        public void InsertData(string prjName, string abbreviation, string customer, string xmlFile)
        {
            try
            {
                project.ProjectName = prjName;
                project.Abbreviation = abbreviation;
                project.Customer = customer;
                project.XmlFile = xmlFile;

                project.CreateProject();
            }
            catch (Exception ex)
            {
                this.GetLog(ex.Message);
                this.GetLog(ex.Data.ToString());
            }
        }

        /// <summary>
        /// The method removes a project data.
        /// </summary>
        /// <param name="prjId">An Integer unique project id.</param>        
        /// <param name="xmlFile">A raw string path to the xml file</param>
        public void RemoveData(int prjId, string xmlFile)
        {
            try
            {
                project.ProjectUniqueID = prjId;
                project.XmlFile = xmlFile;

                project.RemoveProject();
            }
            catch (Exception ex)
            {
                this.GetLog(ex.Message);
                this.GetLog(ex.Data.ToString());
            }
        }

        /// <summary>
        /// This method updates existing value to the new one.
        /// </summary>
        /// <param name="prjId">An Integer unique project id.</param>
        /// <param name="propertyName">A String existing item.</param>
        /// <param name="propertyValue">A String neew item.</param>        
        /// <param name="xmlFile">A raw string path to the xml file</param>
        public void UpdateData(
            int prjId,
            string propertyName, //id, name, abbreviation, customer 
            string propertyValue,
            string xmlFile)
        {
            try
            {
                project.ProjectUniqueID = prjId;
                project.PropertyName = propertyName;
                project.PropertyValue = propertyValue;
                project.XmlFile = xmlFile;

                project.UpdateProject();
            }
            catch (Exception ex)
            {

                this.GetLog(ex.Message);
                this.GetLog(ex.Data.ToString());
            }
        }

        /// <summary>
        /// Reads XML data into dataset by using specified file.
        /// </summary>
        /// <param name="xmlFile">A raw string path to the xml file</param>
        /// <returns>Projects Dataset</returns>
        public System.Data.DataSet GetPojectsDataSet(string xmlFile)
        {
            try
            {
                System.Data.DataSet ds = new System.Data.DataSet();
                ds.ReadXml(xmlFile);
                return ds;
            }
            catch (Exception ex)
            {
                this.GetLog(ex.Message);
                this.GetLog(ex.Data.ToString());

                return null;
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
                Models.LogFile logFile = new Models.LogFile();
                logFile.GetLog(Message);
            }
            catch (Exception ex)
            {
                this.GetLog(ex.Message);
                this.GetLog(ex.Data.ToString());
            }

        }

        /// <summary>
        /// Creates a new user
        /// </summary>
        /// <param name="UserName">The User name.</param>
        /// <param name="UserPasword">The User Password.</param>
        /// <param name="ConfirmUserPassword">The conformation of the new user password</param>
        public void GetNewUser(string UserName, string UserPassword, string ConfirmUserPassword) 
        {
            try
            {
                Models.User user = new Models.User();
                user.CreateNewUser(UserName, UserPassword, ConfirmUserPassword);
            }
            catch (Exception ex)
            {
                this.GetLog(ex.Message);
                this.GetLog(ex.Data.ToString());
            }
        }

        /// <summary>
        /// Checks existing user credentials.
        /// </summary>
        /// <param name="UserName">The User name. </param>
        /// <param name="UserPassword">The User Password.</param>
        /// <returns></returns>
        public bool CeckUser(string UserName, string UserPassword) 
        {
            try
            {
                Models.User user = new Models.User();
                return user.CheckExistingUser(UserName, UserPassword);
            }
            catch (Exception ex)
            {
                this.GetLog(ex.Message);
                this.GetLog(ex.Data.ToString());
                return false;
            }
        }

        #endregion
    }
}
