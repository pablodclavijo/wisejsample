using Wisej.Web;

namespace Wisej35Sample
{
    partial class MainPage
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

        #region Wisej.NET Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.label1 = new Wisej.Web.Label();
            this.dataGridViewOrganization = new Wisej.Web.DataGridView();
            this.colId = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colName = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colStreet = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colZip = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colCity = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colCountry = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colPeople = new Wisej.Web.DataGridViewTextBoxColumn();
            this.organizationBindingSource = new Wisej.Web.BindingSource(this.components);
            this.dataGridView2 = new Wisej.Web.DataGridView();
            this.colId_1 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colTitle = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colFirstname = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colLastname = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colPhonenumber = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colEmail = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colOrganizationid = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colOrganization = new Wisej.Web.DataGridViewTextBoxColumn();
            this.personBindingSource = new Wisej.Web.BindingSource(this.components);
            this.label2 = new Wisej.Web.Label();
            this.buttonAddOrganization = new Wisej.Web.Button();
            this.buttonDeleteOrganization = new Wisej.Web.Button();
            this.buttonEditOrganization = new Wisej.Web.Button();
            this.buttonDeleteMember = new Wisej.Web.Button();
            this.buttonEditMember = new Wisej.Web.Button();
            this.buttonAddMember = new Wisej.Web.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrganization)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("label1.ResponsiveProfiles"))));
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Organizations";
            // 
            // dataGridViewOrganization
            // 
            this.dataGridViewOrganization.AutoGenerateColumns = false;
            this.dataGridViewOrganization.BackColor = System.Drawing.Color.FromName("@tabHighlight");
            this.dataGridViewOrganization.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colStreet,
            this.colZip,
            this.colCity,
            this.colCountry,
            this.colPeople});
            this.dataGridViewOrganization.DataSource = this.organizationBindingSource;
            this.dataGridViewOrganization.EditMode = Wisej.Web.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewOrganization.Location = new System.Drawing.Point(33, 50);
            this.dataGridViewOrganization.Name = "dataGridViewOrganization";
            this.dataGridViewOrganization.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("dataGridViewOrganization.ResponsiveProfiles"))));
            this.dataGridViewOrganization.ShowColumnVisibilityMenu = false;
            this.dataGridViewOrganization.Size = new System.Drawing.Size(1195, 231);
            this.dataGridViewOrganization.TabIndex = 1;
            this.dataGridViewOrganization.CellClick += new Wisej.Web.DataGridViewCellEventHandler(this.dataGridViewOrganization_CellClick);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("colId.ResponsiveProfiles"))));
            this.colId.ValueType = typeof(int);
            this.colId.Visible = false;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("colName.ResponsiveProfiles"))));
            this.colName.ValueType = typeof(string);
            this.colName.Width = 300;
            // 
            // colStreet
            // 
            this.colStreet.DataPropertyName = "Street";
            this.colStreet.HeaderText = "Street";
            this.colStreet.Name = "colStreet";
            this.colStreet.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("colStreet.ResponsiveProfiles"))));
            this.colStreet.ValueType = typeof(string);
            this.colStreet.Width = 250;
            // 
            // colZip
            // 
            this.colZip.DataPropertyName = "Zip";
            this.colZip.HeaderText = "Zip";
            this.colZip.Name = "colZip";
            this.colZip.ValueType = typeof(string);
            // 
            // colCity
            // 
            this.colCity.DataPropertyName = "City";
            this.colCity.HeaderText = "City";
            this.colCity.Name = "colCity";
            this.colCity.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("colCity.ResponsiveProfiles"))));
            this.colCity.ValueType = typeof(string);
            this.colCity.Width = 230;
            // 
            // colCountry
            // 
            this.colCountry.DataPropertyName = "Country";
            this.colCountry.HeaderText = "Country";
            this.colCountry.Name = "colCountry";
            this.colCountry.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("colCountry.ResponsiveProfiles"))));
            this.colCountry.ValueType = typeof(string);
            this.colCountry.Width = 250;
            // 
            // colPeople
            // 
            this.colPeople.DataPropertyName = "People";
            this.colPeople.HeaderText = "People";
            this.colPeople.Name = "colPeople";
            this.colPeople.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("colPeople.ResponsiveProfiles"))));
            this.colPeople.ValueType = typeof(System.Collections.Generic.ICollection<Wisej35Sample.Models.Person>);
            this.colPeople.Visible = false;
            // 
            // organizationBindingSource
            // 
            this.organizationBindingSource.DataSource = typeof(Wisej35Sample.Models.Organization);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackColor = System.Drawing.Color.FromName("@tabHighlight");
            this.dataGridView2.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.colId_1,
            this.colTitle,
            this.colFirstname,
            this.colLastname,
            this.colPhonenumber,
            this.colEmail,
            this.colOrganizationid,
            this.colOrganization});
            this.dataGridView2.DataSource = this.personBindingSource;
            this.dataGridView2.EditMode = Wisej.Web.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2.Location = new System.Drawing.Point(33, 401);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("dataGridView2.ResponsiveProfiles"))));
            this.dataGridView2.ShowColumnVisibilityMenu = false;
            this.dataGridView2.Size = new System.Drawing.Size(1195, 244);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellClick += new Wisej.Web.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // colId_1
            // 
            this.colId_1.DataPropertyName = "Id";
            this.colId_1.HeaderText = "Id";
            this.colId_1.Name = "colId_1";
            this.colId_1.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("colId_1.ResponsiveProfiles"))));
            this.colId_1.ValueType = typeof(int);
            this.colId_1.Visible = false;
            // 
            // colTitle
            // 
            this.colTitle.DataPropertyName = "Title";
            this.colTitle.HeaderText = "Title";
            this.colTitle.Name = "colTitle";
            this.colTitle.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("colTitle.ResponsiveProfiles"))));
            this.colTitle.ValueType = typeof(string);
            this.colTitle.Width = 300;
            // 
            // colFirstname
            // 
            this.colFirstname.DataPropertyName = "FirstName";
            this.colFirstname.HeaderText = "First Name";
            this.colFirstname.Name = "colFirstname";
            this.colFirstname.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("colFirstname.ResponsiveProfiles"))));
            this.colFirstname.ValueType = typeof(string);
            this.colFirstname.Width = 200;
            // 
            // colLastname
            // 
            this.colLastname.DataPropertyName = "LastName";
            this.colLastname.HeaderText = "Last Name";
            this.colLastname.Name = "colLastname";
            this.colLastname.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("colLastname.ResponsiveProfiles"))));
            this.colLastname.ValueType = typeof(string);
            this.colLastname.Width = 200;
            // 
            // colPhonenumber
            // 
            this.colPhonenumber.DataPropertyName = "PhoneNumber";
            this.colPhonenumber.HeaderText = "Phone Number";
            this.colPhonenumber.Name = "colPhonenumber";
            this.colPhonenumber.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("colPhonenumber.ResponsiveProfiles"))));
            this.colPhonenumber.ValueType = typeof(string);
            this.colPhonenumber.Width = 150;
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("colEmail.ResponsiveProfiles"))));
            this.colEmail.ValueType = typeof(string);
            this.colEmail.Width = 300;
            // 
            // colOrganizationid
            // 
            this.colOrganizationid.DataPropertyName = "OrganizationId";
            this.colOrganizationid.HeaderText = "OrganizationId";
            this.colOrganizationid.Name = "colOrganizationid";
            this.colOrganizationid.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("colOrganizationid.ResponsiveProfiles"))));
            this.colOrganizationid.ValueType = typeof(int);
            this.colOrganizationid.Visible = false;
            // 
            // colOrganization
            // 
            this.colOrganization.DataPropertyName = "Organization";
            this.colOrganization.HeaderText = "colOrganization";
            this.colOrganization.Name = "colOrganization";
            this.colOrganization.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("colOrganization.ResponsiveProfiles"))));
            this.colOrganization.ValueType = typeof(Wisej35Sample.Models.Organization);
            this.colOrganization.Visible = false;
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(Wisej35Sample.Models.Person);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(19, 361);
            this.label2.Name = "label2";
            this.label2.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("label2.ResponsiveProfiles"))));
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Members";
            // 
            // buttonAddOrganization
            // 
            this.buttonAddOrganization.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddOrganization.CssStyle = "border: 1px solid;";
            this.buttonAddOrganization.ForeColor = System.Drawing.Color.Black;
            this.buttonAddOrganization.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/square-add-button.svg";
            this.buttonAddOrganization.Location = new System.Drawing.Point(1029, 300);
            this.buttonAddOrganization.Name = "buttonAddOrganization";
            this.buttonAddOrganization.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("buttonAddOrganization.ResponsiveProfiles"))));
            this.buttonAddOrganization.Size = new System.Drawing.Size(54, 37);
            this.buttonAddOrganization.TabIndex = 4;
            this.buttonAddOrganization.ToolTipText = "Add new Organization";
            this.buttonAddOrganization.Click += new System.EventHandler(this.buttonAddOrganization_Click);
            // 
            // buttonDeleteOrganization
            // 
            this.buttonDeleteOrganization.Anchor = Wisej.Web.AnchorStyles.Top;
            this.buttonDeleteOrganization.BackColor = System.Drawing.Color.Transparent;
            this.buttonDeleteOrganization.CssStyle = "border: 1px solid;";
            this.buttonDeleteOrganization.ForeColor = System.Drawing.Color.Black;
            this.buttonDeleteOrganization.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/rubbish-bin-delete-button.svg";
            this.buttonDeleteOrganization.Location = new System.Drawing.Point(1149, 300);
            this.buttonDeleteOrganization.Name = "buttonDeleteOrganization";
            this.buttonDeleteOrganization.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("buttonDeleteOrganization.ResponsiveProfiles"))));
            this.buttonDeleteOrganization.Size = new System.Drawing.Size(54, 37);
            this.buttonDeleteOrganization.TabIndex = 6;
            this.buttonDeleteOrganization.ToolTipText = "Delete Organization";
            this.buttonDeleteOrganization.Click += new System.EventHandler(this.buttonDeleteOrganization_Click);
            // 
            // buttonEditOrganization
            // 
            this.buttonEditOrganization.BackColor = System.Drawing.Color.Transparent;
            this.buttonEditOrganization.CssStyle = "border: 1px solid;";
            this.buttonEditOrganization.ForeColor = System.Drawing.Color.Black;
            this.buttonEditOrganization.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/create-new-pencil-button.svg";
            this.buttonEditOrganization.Location = new System.Drawing.Point(1089, 300);
            this.buttonEditOrganization.Name = "buttonEditOrganization";
            this.buttonEditOrganization.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("buttonEditOrganization.ResponsiveProfiles"))));
            this.buttonEditOrganization.Size = new System.Drawing.Size(54, 37);
            this.buttonEditOrganization.TabIndex = 5;
            this.buttonEditOrganization.ToolTipText = "Edit Organization";
            this.buttonEditOrganization.Click += new System.EventHandler(this.buttonEditOrganization_Click);
            // 
            // buttonDeleteMember
            // 
            this.buttonDeleteMember.BackColor = System.Drawing.Color.Transparent;
            this.buttonDeleteMember.CssStyle = "border: 1px solid;";
            this.buttonDeleteMember.ForeColor = System.Drawing.Color.Black;
            this.buttonDeleteMember.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/rubbish-bin-delete-button.svg";
            this.buttonDeleteMember.Location = new System.Drawing.Point(1149, 666);
            this.buttonDeleteMember.Name = "buttonDeleteMember";
            this.buttonDeleteMember.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("buttonDeleteMember.ResponsiveProfiles"))));
            this.buttonDeleteMember.Size = new System.Drawing.Size(54, 37);
            this.buttonDeleteMember.TabIndex = 9;
            this.buttonDeleteMember.ToolTipText = "Delete Member";
            this.buttonDeleteMember.Click += new System.EventHandler(this.buttonDeleteMember_Click);
            // 
            // buttonEditMember
            // 
            this.buttonEditMember.BackColor = System.Drawing.Color.Transparent;
            this.buttonEditMember.CssStyle = "border: 1px solid;";
            this.buttonEditMember.ForeColor = System.Drawing.Color.Black;
            this.buttonEditMember.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/create-new-pencil-button.svg";
            this.buttonEditMember.Location = new System.Drawing.Point(1089, 666);
            this.buttonEditMember.Name = "buttonEditMember";
            this.buttonEditMember.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("buttonEditMember.ResponsiveProfiles"))));
            this.buttonEditMember.Size = new System.Drawing.Size(54, 37);
            this.buttonEditMember.TabIndex = 8;
            this.buttonEditMember.ToolTipText = "Edit Member";
            this.buttonEditMember.Click += new System.EventHandler(this.buttonEditMember_Click);
            // 
            // buttonAddMember
            // 
            this.buttonAddMember.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddMember.CssStyle = "border: 1px solid;";
            this.buttonAddMember.ForeColor = System.Drawing.Color.Black;
            this.buttonAddMember.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/square-add-button.svg";
            this.buttonAddMember.Location = new System.Drawing.Point(1029, 666);
            this.buttonAddMember.Name = "buttonAddMember";
            this.buttonAddMember.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("buttonAddMember.ResponsiveProfiles"))));
            this.buttonAddMember.Size = new System.Drawing.Size(54, 37);
            this.buttonAddMember.TabIndex = 7;
            this.buttonAddMember.ToolTipText = "Add new Member";
            this.buttonAddMember.Click += new System.EventHandler(this.buttonAddMember_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 721);
            this.Controls.Add(this.buttonDeleteMember);
            this.Controls.Add(this.buttonEditMember);
            this.Controls.Add(this.buttonAddMember);
            this.Controls.Add(this.buttonDeleteOrganization);
            this.Controls.Add(this.buttonEditOrganization);
            this.Controls.Add(this.buttonAddOrganization);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridViewOrganization);
            this.Controls.Add(this.label1);
            this.HeaderBackColor = System.Drawing.Color.Black;
            this.Location = new System.Drawing.Point(25, 25);
            this.Name = "MainPage";
            this.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("$this.ResponsiveProfiles"))));
            this.StartPosition = Wisej.Web.FormStartPosition.CenterScreen;
            this.Text = "Adresses Manager";
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrganization)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dataGridViewOrganization;
        private DataGridView dataGridView2;
        private Label label2;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colStreet;
        private DataGridViewTextBoxColumn colZip;
        private DataGridViewTextBoxColumn colCity;
        private DataGridViewTextBoxColumn colCountry;
        private DataGridViewTextBoxColumn colPeople;
        private BindingSource organizationBindingSource;
        private DataGridViewTextBoxColumn colId_1;
        private DataGridViewTextBoxColumn colTitle;
        private DataGridViewTextBoxColumn colFirstname;
        private DataGridViewTextBoxColumn colLastname;
        private DataGridViewTextBoxColumn colPhonenumber;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colOrganizationid;
        private DataGridViewTextBoxColumn colOrganization;
        private BindingSource personBindingSource;
        private Button buttonAddOrganization;
        private Button buttonDeleteOrganization;
        private Button buttonEditOrganization;
        private Button buttonDeleteMember;
        private Button buttonEditMember;
        private Button buttonAddMember;
    }
}

