using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;

namespace DataLayer.Models
{
    public class User
    {
        #region Private Members        
        private XDocument xDoc;
        private LogFile logFile = new LogFile();
        private const string xmlFile = "AppConfig.xml";
        #endregion

        #region Constructors        
        public User() 
        {
            CreateEmptyXmlFile();
        }
        #endregion

        #region Private Methods        
        /// <summary>
        /// Creates Empty Configuration File with root elemet
        /// </summary>
        private void CreateEmptyXmlFile()
        {
            try
            {
                if (!File.Exists(xmlFile))
                {
                    File.Create(xmlFile).Close();
                    File.WriteAllText(xmlFile, "<users></users>");

                    logFile.GetLog($"The new File |{xmlFile}| was created.");
                }
            }
            catch (Exception ex)
            {

                logFile.GetLog(ex.Message);
            }
        }
        

        /// <summary>
        /// This method returns an unique ID.
        /// </summary>
        /// <param name="xmlFile">A raw string path to the xml file.</param>
        /// <returns>The unique Id.</returns>
        private int GetUniqueID(string xmlFile)
        {
            try
            {
                System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
                doc.Load(xmlFile);
                System.Xml.XmlElement root = doc.DocumentElement;
                System.Xml.XmlNodeList nodeList = root.GetElementsByTagName("user");
                return nodeList.Count + 1;
            }
            catch (Exception ex)
            {

                logFile.GetLog(ex.Message);
                return -1;
            }
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Creates a new user
        /// </summary>
        /// <param name="UserName">The User name.</param>
        /// <param name="UserPasword">The User Password.</param>
        /// <param name="ConfirmUserPassword">The conformation of the new user password</param>
        public void CreateNewUser(string UserName, string UserPasword, string ConfirmUserPassword) 
        {
            try
            {
                var id = GetUniqueID(xmlFile);

                if (UserPasword == ConfirmUserPassword)
                {
                    XElement xml = new XElement("user",
                    new XAttribute("id", $"{id}"),                    
                    new XElement("name", UserName),
                    new XElement("password", UserPasword)
                    );

                    var xDoc = XDocument.Load(xmlFile);
                    xDoc.Root.Add(xml);
                    xDoc.Save(xmlFile);                    

                    logFile.GetLog($"The new user |{UserName}| was created, with id |{id}|");
                    
                }
                else
                {
                    logFile.GetLog("The password and the conformation of the password are not the same!");
                }
            }
            catch (Exception ex)
            {

                logFile.GetLog(ex.Message);
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
                var xDoc = XDocument.Load(xmlFile);
                var length = GetUniqueID(xmlFile);
                for (int i = 1; i < length; i++)
                {                   
                    var target = xDoc.Root.Descendants("user").FirstOrDefault(x => x.Attribute("id").Value == $"{i}");
                    
                    string userName = target.Element("name").Value;
                    string userPassword = target.Element("password").Value;

                    if (userName == UserName && userPassword == UserPassword)
                    {
                        logFile.GetLog($"User |{UserName}| is Logged successfully.");
                        return true;
                    }
                    
                }

                return false;
            }
            catch (Exception ex)
            {
                logFile.GetLog(ex.Message);
                return false;
            }
        }

        #endregion
    }
}
