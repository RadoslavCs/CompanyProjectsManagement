using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataLayer.Models
{
    public class Project 
    {
        #region Constructors

        
        public Project() 
        { 
        
        }
        #endregion

        #region Properties        
        public int ProjectUniqueID { get; set; }
        public String XmlFile { get; set; }
        public String ProjectName { get; set; }
        public String Abbreviation { get; set; }
        public String Customer { get; set; }
        public String PropertyName { get; set; }
        public String PropertyValue { get; set; }
        #endregion

        #region Private Methods
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
                System.Xml.XmlNodeList nodeList = root.GetElementsByTagName("project");
                return nodeList.Count + 1;
            }
            catch (Exception ex)
            {
                //this.GetLog(ex.Message);
                //this.GetLog(ex.Data.ToString());

                return -1;
            }
        }

        #endregion

        #region Public Methods        
        /// <summary>
        /// Creates new project
        /// </summary>
        public void CreateProject() 
        {
            XElement xml =
               new XElement("project",
               new XAttribute("id", $"prj{GetUniqueID(XmlFile)}"),
               new XElement("name", ProjectName),
               new XElement("abbreviation", Abbreviation),
               new XElement("customer", Customer)
               );

            var xDoc = XDocument.Load(XmlFile);
            xDoc.Root.Add(xml);
            xDoc.Save(XmlFile);
        }

        /// <summary>
        /// Removes Projects
        /// </summary>
        public void RemoveProject() 
        {
            var _xDoc = XDocument.Load(XmlFile);

            var target = _xDoc.Root.Descendants("project").FirstOrDefault(x => x.Attribute("id").Value == $"prj{ProjectUniqueID}");
            target.Remove();
            _xDoc.Save(XmlFile);
        }

        /// <summary>
        /// Updates Project
        /// </summary>
        public void UpdateProject() 
        {
            var _xDoc = XDocument.Load(XmlFile);
            var target = _xDoc.Root.Descendants("project").FirstOrDefault(x => x.Attribute("id").Value == $"prj{ProjectUniqueID}");
            target.Element(PropertyName).Value = PropertyValue;
            _xDoc.Save(XmlFile);
        }

        #endregion
    }
}
