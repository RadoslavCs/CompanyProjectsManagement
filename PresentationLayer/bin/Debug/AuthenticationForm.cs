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

/// <summary>
/// This is an Authentication Form
/// </summary>
namespace PresentationLayer
{
    public partial class AuthenticationForm : Form
    {
        #region Private Members
        private ApplicationLayer.ApplicationLayer applicationLayer = new ApplicationLayer.ApplicationLayer();
        #endregion

        #region Constructors
        public AuthenticationForm()
        {
            
            InitializeComponent();
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// TThis method checks the operations that are listed in the "cmbOperations" combo box and
        /// ensures that the user has access to the text boxes corresponding to the operation.
        /// </summary>
        private void CheckForm() 
        {
            try
            {
                if (cmbActions.Text == "Log as Existing User")
                {
                    btnOK.Text = cmbActions.Text;
                    btnOK.Visible = true;

                    txtName.Visible = true;
                    txtUserPassword.Visible = true;

                    txtConfirmPassword.Visible = false;
                    lblConfirmPassword.Visible = false;
                }

                if (cmbActions.Text == "Create New User")
                {
                    btnOK.Text = cmbActions.Text;
                    btnOK.Visible = true;

                    txtName.Visible = true;
                    txtUserPassword.Visible = true;

                    txtConfirmPassword.Visible = true;
                    lblConfirmPassword.Visible = true;
                }

                if (checkSee.Checked == true)
                {
                    txtName.ForeColor = Color.Black;
                    txtUserPassword.ForeColor = Color.Black;
                    txtConfirmPassword.ForeColor = Color.Black;
                }
                else if (checkSee.Checked == false)
                {
                    txtName.ForeColor = Color.White;
                    txtUserPassword.ForeColor = Color.White;
                    txtConfirmPassword.ForeColor = Color.White;
                }
            }
            catch (Exception ex)
            {
                applicationLayer.GetLog(ex.Message);
                applicationLayer.GetLog(ex.Data.ToString());
            }
        
        }

        /// <summary>
        /// The button calls this method, which can check the credentials 
        /// of the existing user and also create a new user.
        /// </summary>
        private void GetAuthentication() 
        {
            try
            {
                if (cmbActions.Text == "Log as Existing User" &&
                btnOK.Text == "Log as Existing User" &&
                applicationLayer.CheckExistingUser(txtName.Text, txtUserPassword.Text) == true)
                {
                    applicationLayer.GetLog($"The User |{txtName.Text}| is Logged ");                    
                    btnOK.Dispose();
                    txtName.Text = String.Empty;
                    txtName.ReadOnly = true;                   
                    txtUserPassword.Text = String.Empty;
                    txtUserPassword.ReadOnly = true;                    
                    txtConfirmPassword.Text = String.Empty;
                    txtConfirmPassword.ReadOnly = true;                    
                    cmbActions.Enabled = false;                    
                    lblName.Text = String.Empty;
                    lblPassword.Text = String.Empty;
                    lblConfirmPassword.Text = String.Empty;
                    

                    ComPrjManForm comPrjManForm = new ComPrjManForm();
                    comPrjManForm.Show();
                    
                }
                else
                {
                    applicationLayer.GetLog($"User |{txtName.Text}| does not exist");

                    MessageBox.Show($"User |{txtName.Text}| does not exist!!!",
                        "User Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }

                if (cmbActions.Text == "Create New User" &&
                    btnOK.Text == "Create New User")
                {
                    applicationLayer.GetNewUser(txtName.Text, txtUserPassword.Text, txtConfirmPassword.Text);

                    MessageBox.Show($"New user {txtName.Text} created.",
                        "New User", 
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    applicationLayer.GetLog($"The new user |{txtName.Text}| was created.");
                }

            }
            catch (Exception ex)
            {
                applicationLayer.GetLog(ex.Data.ToString());
                applicationLayer.GetLog(ex.Message);
            }
        }
        #endregion

        #region Events
        private void checkForm1_Tick(object sender, EventArgs e)
        {
            CheckForm();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkForm1.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            checkForm1.Stop();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            GetAuthentication();
        }
        #endregion
    }
}
