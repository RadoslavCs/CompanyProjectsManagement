using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationLayer;

namespace PresentationLayer
{
    public partial class ComPrjManForm : Form
    {
        #region Private Members
        private const string xmlFile = "projects.xml";
        private ApplicationLayer.ApplicationLayer applicationLayer = new ApplicationLayer.ApplicationLayer();
        #endregion

        #region Constructor
        public ComPrjManForm()
        {
            InitializeComponent();
            DisplayProjectsData();
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// This method displays a Projects data in the Data Grid view.
        /// </summary>
        private void DisplayProjectsData()
        {
            try
            {
                dataGridView.DataSource = applicationLayer.GetProjectsDataset(xmlFile).Tables[0];
            }
            catch (Exception ex)
            {
                applicationLayer.GetLog(ex.Message);
                applicationLayer.GetLog(ex.Data.ToString());
            }
        }

        /// <summary>
        /// TThis method checks the operations that are listed in the "cmbOperations" combo box and
        /// ensures that the user has access to the text boxes corresponding to the operation.
        /// </summary>
        private void CheckForm()
        {
            try
            {
                if (cmbOperations.Text == "Insert Project")
                {
                    btnAction.Text = "Insert Project";
                    btnAction.Visible = true;

                    txtID.ReadOnly = true;
                    txtPrjName.ReadOnly = false;
                    txtAbbreviation.ReadOnly = false;
                    txtCustomer.ReadOnly = false;
                    cmbPrjProperty.Enabled = false;
                    txtPropertyValue.ReadOnly = true;

                }

                if (cmbOperations.Text == "Update Project")
                {
                    btnAction.Text = "Update Project";
                    btnAction.Visible = true;

                    txtID.ReadOnly = false;
                    txtPrjName.ReadOnly = true;
                    txtAbbreviation.ReadOnly = true;
                    txtCustomer.ReadOnly = true;
                    cmbPrjProperty.Enabled = true;
                    txtPropertyValue.ReadOnly = false;
                }


                if (cmbOperations.Text == "Remove Project")
                {
                    btnAction.Text = "Remove Project";
                    btnAction.Visible = true;

                    txtID.ReadOnly = false;
                    txtPrjName.ReadOnly = true;
                    txtAbbreviation.ReadOnly = true;
                    txtCustomer.ReadOnly = true;
                    cmbPrjProperty.Enabled = false;
                    txtPropertyValue.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                applicationLayer.GetLog(ex.Message);
                applicationLayer.GetLog(ex.Data.ToString());
            }
        }


        /// <summary>
        /// Provides right operation on the button click event. 
        /// </summary>
        private void GetBtnActions()
        {
            try
            {
                if (btnAction.Text == "Insert Project" &&
                cmbOperations.Text == "Insert Project")
                {
                    applicationLayer.InsertProject(
                        txtPrjName.Text,
                        txtAbbreviation.Text,
                        txtCustomer.Text, xmlFile);
                }

                if (btnAction.Text == "Update Project" &&
                    cmbOperations.Text == "Update Project")
                {
                    applicationLayer.UpdateProject(
                        int.Parse(txtID.Text),
                        cmbPrjProperty.Text,
                        txtPropertyValue.Text,
                        xmlFile);
                }

                if (btnAction.Text == "Remove Project" &&
                    cmbOperations.Text == "Remove Project")
                {
                    applicationLayer.DeleteProject(
                         int.Parse(txtID.Text),
                         xmlFile);
                }
                DisplayProjectsData();
            }
            catch (Exception ex)
            {
                applicationLayer.GetLog(ex.Message);
                applicationLayer.GetLog(ex.Data.ToString());
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        #endregion

        #region Events
        private void ComPrjManForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void checkForm_Tick(object sender, EventArgs e)
        {

            CheckForm();

        }

        private void ComPrjManForm_Load(object sender, EventArgs e)
        {
            checkPrjForm.Start();
        }

        private void ComPrjManForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            checkPrjForm.Stop();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            GetBtnActions();
        }
        #endregion
    }
}
