
namespace PresentationLayer
{
    partial class ComPrjManForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComPrjManForm));
            this.grpBoxPrjData = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.grpProjectProperties = new System.Windows.Forms.GroupBox();
            this.lblPropertyValue = new System.Windows.Forms.Label();
            this.lblProjectProperty = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblAbbreviation = new System.Windows.Forms.Label();
            this.lblPrjName = new System.Windows.Forms.Label();
            this.lblPrjId = new System.Windows.Forms.Label();
            this.cmbPrjProperty = new System.Windows.Forms.ComboBox();
            this.txtPrjName = new System.Windows.Forms.TextBox();
            this.txtAbbreviation = new System.Windows.Forms.TextBox();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.txtPropertyValue = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.grpLogo = new System.Windows.Forms.GroupBox();
            this.pictureCompanyLogo = new System.Windows.Forms.PictureBox();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.cmbOperations = new System.Windows.Forms.ComboBox();
            this.btnAction = new System.Windows.Forms.Button();
            this.checkPrjForm = new System.Windows.Forms.Timer(this.components);
            this.grpBoxPrjData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.grpProjectProperties.SuspendLayout();
            this.grpLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCompanyLogo)).BeginInit();
            this.grpOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxPrjData
            // 
            this.grpBoxPrjData.Controls.Add(this.dataGridView);
            resources.ApplyResources(this.grpBoxPrjData, "grpBoxPrjData");
            this.grpBoxPrjData.Name = "grpBoxPrjData";
            this.grpBoxPrjData.TabStop = false;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView, "dataGridView");
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            // 
            // grpProjectProperties
            // 
            this.grpProjectProperties.Controls.Add(this.lblPropertyValue);
            this.grpProjectProperties.Controls.Add(this.lblProjectProperty);
            this.grpProjectProperties.Controls.Add(this.lblCustomer);
            this.grpProjectProperties.Controls.Add(this.lblAbbreviation);
            this.grpProjectProperties.Controls.Add(this.lblPrjName);
            this.grpProjectProperties.Controls.Add(this.lblPrjId);
            this.grpProjectProperties.Controls.Add(this.cmbPrjProperty);
            this.grpProjectProperties.Controls.Add(this.txtPrjName);
            this.grpProjectProperties.Controls.Add(this.txtAbbreviation);
            this.grpProjectProperties.Controls.Add(this.txtCustomer);
            this.grpProjectProperties.Controls.Add(this.txtPropertyValue);
            this.grpProjectProperties.Controls.Add(this.txtID);
            resources.ApplyResources(this.grpProjectProperties, "grpProjectProperties");
            this.grpProjectProperties.Name = "grpProjectProperties";
            this.grpProjectProperties.TabStop = false;
            // 
            // lblPropertyValue
            // 
            resources.ApplyResources(this.lblPropertyValue, "lblPropertyValue");
            this.lblPropertyValue.Name = "lblPropertyValue";
            // 
            // lblProjectProperty
            // 
            resources.ApplyResources(this.lblProjectProperty, "lblProjectProperty");
            this.lblProjectProperty.Name = "lblProjectProperty";
            // 
            // lblCustomer
            // 
            resources.ApplyResources(this.lblCustomer, "lblCustomer");
            this.lblCustomer.Name = "lblCustomer";
            // 
            // lblAbbreviation
            // 
            resources.ApplyResources(this.lblAbbreviation, "lblAbbreviation");
            this.lblAbbreviation.Name = "lblAbbreviation";
            // 
            // lblPrjName
            // 
            resources.ApplyResources(this.lblPrjName, "lblPrjName");
            this.lblPrjName.Name = "lblPrjName";
            // 
            // lblPrjId
            // 
            resources.ApplyResources(this.lblPrjId, "lblPrjId");
            this.lblPrjId.Name = "lblPrjId";
            // 
            // cmbPrjProperty
            // 
            this.cmbPrjProperty.FormattingEnabled = true;
            this.cmbPrjProperty.Items.AddRange(new object[] {
            resources.GetString("cmbPrjProperty.Items"),
            resources.GetString("cmbPrjProperty.Items1"),
            resources.GetString("cmbPrjProperty.Items2")});
            resources.ApplyResources(this.cmbPrjProperty, "cmbPrjProperty");
            this.cmbPrjProperty.Name = "cmbPrjProperty";
            // 
            // txtPrjName
            // 
            resources.ApplyResources(this.txtPrjName, "txtPrjName");
            this.txtPrjName.Name = "txtPrjName";
            // 
            // txtAbbreviation
            // 
            resources.ApplyResources(this.txtAbbreviation, "txtAbbreviation");
            this.txtAbbreviation.Name = "txtAbbreviation";
            // 
            // txtCustomer
            // 
            resources.ApplyResources(this.txtCustomer, "txtCustomer");
            this.txtCustomer.Name = "txtCustomer";
            // 
            // txtPropertyValue
            // 
            resources.ApplyResources(this.txtPropertyValue, "txtPropertyValue");
            this.txtPropertyValue.Name = "txtPropertyValue";
            // 
            // txtID
            // 
            resources.ApplyResources(this.txtID, "txtID");
            this.txtID.Name = "txtID";
            // 
            // grpLogo
            // 
            this.grpLogo.Controls.Add(this.pictureCompanyLogo);
            resources.ApplyResources(this.grpLogo, "grpLogo");
            this.grpLogo.Name = "grpLogo";
            this.grpLogo.TabStop = false;
            // 
            // pictureCompanyLogo
            // 
            resources.ApplyResources(this.pictureCompanyLogo, "pictureCompanyLogo");
            this.pictureCompanyLogo.Image = global::PresentationLayer.Properties.Resources.our_leaf_clover_icon1;
            this.pictureCompanyLogo.Name = "pictureCompanyLogo";
            this.pictureCompanyLogo.TabStop = false;
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.cmbOperations);
            resources.ApplyResources(this.grpOptions, "grpOptions");
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.TabStop = false;
            // 
            // cmbOperations
            // 
            this.cmbOperations.FormattingEnabled = true;
            this.cmbOperations.Items.AddRange(new object[] {
            resources.GetString("cmbOperations.Items"),
            resources.GetString("cmbOperations.Items1"),
            resources.GetString("cmbOperations.Items2")});
            resources.ApplyResources(this.cmbOperations, "cmbOperations");
            this.cmbOperations.Name = "cmbOperations";
            // 
            // btnAction
            // 
            resources.ApplyResources(this.btnAction, "btnAction");
            this.btnAction.Name = "btnAction";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // checkPrjForm
            // 
            this.checkPrjForm.Tick += new System.EventHandler(this.checkForm_Tick);
            // 
            // ComPrjManForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.grpLogo);
            this.Controls.Add(this.grpProjectProperties);
            this.Controls.Add(this.grpBoxPrjData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ComPrjManForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ComPrjManForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ComPrjManForm_FormClosed);
            this.Load += new System.EventHandler(this.ComPrjManForm_Load);
            this.grpBoxPrjData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.grpProjectProperties.ResumeLayout(false);
            this.grpProjectProperties.PerformLayout();
            this.grpLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureCompanyLogo)).EndInit();
            this.grpOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxPrjData;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox grpProjectProperties;
        private System.Windows.Forms.Label lblPropertyValue;
        private System.Windows.Forms.Label lblProjectProperty;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblAbbreviation;
        private System.Windows.Forms.Label lblPrjName;
        private System.Windows.Forms.Label lblPrjId;
        private System.Windows.Forms.ComboBox cmbPrjProperty;
        private System.Windows.Forms.TextBox txtPrjName;
        private System.Windows.Forms.TextBox txtAbbreviation;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.TextBox txtPropertyValue;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.GroupBox grpLogo;
        private System.Windows.Forms.PictureBox pictureCompanyLogo;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.ComboBox cmbOperations;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Timer checkPrjForm;
    }
}