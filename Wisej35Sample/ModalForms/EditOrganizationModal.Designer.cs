namespace Wisej35Sample.ModalForms
{
    partial class EditOrganizationModal
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
            this.buttonAccept = new Wisej.Web.Button();
            this.buttonCancel = new Wisej.Web.Button();
            this.textBoxName = new Wisej.Web.TextBox();
            this.textBoxZip = new Wisej.Web.TextBox();
            this.textBoxStreet = new Wisej.Web.TextBox();
            this.textBoxCountry = new Wisej.Web.TextBox();
            this.textBoxCity = new Wisej.Web.TextBox();
            this.organizationBindingSource = new Wisej.Web.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.organizationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAccept
            // 
            this.buttonAccept.BackColor = System.Drawing.Color.LightGreen;
            this.buttonAccept.ForeColor = System.Drawing.Color.FromName("@appWorkspace");
            this.buttonAccept.Location = new System.Drawing.Point(109, 230);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(100, 37);
            this.buttonAccept.TabIndex = 5;
            this.buttonAccept.Text = "Accept";
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.LightCoral;
            this.buttonCancel.ForeColor = System.Drawing.Color.FromName("@appWorkspace");
            this.buttonCancel.Location = new System.Drawing.Point(274, 230);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 37);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.DataBindings.Add(new Wisej.Web.Binding("Text", this.organizationBindingSource, "Name", true, Wisej.Web.DataSourceUpdateMode.OnValidation, null, ""));
            this.textBoxName.LabelText = "Name";
            this.textBoxName.Location = new System.Drawing.Point(64, 22);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(353, 53);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.Watermark = "Example Co. LTD";
            // 
            // textBoxZip
            // 
            this.textBoxZip.DataBindings.Add(new Wisej.Web.Binding("Text", this.organizationBindingSource, "Zip", true, Wisej.Web.DataSourceUpdateMode.OnValidation, null, ""));
            this.textBoxZip.LabelText = "Zip Code";
            this.textBoxZip.Location = new System.Drawing.Point(296, 84);
            this.textBoxZip.Name = "textBoxZip";
            this.textBoxZip.Size = new System.Drawing.Size(120, 53);
            this.textBoxZip.TabIndex = 2;
            this.textBoxZip.Watermark = "12345";
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.DataBindings.Add(new Wisej.Web.Binding("Text", this.organizationBindingSource, "Street", true, Wisej.Web.DataSourceUpdateMode.OnValidation, null, ""));
            this.textBoxStreet.LabelText = "Street";
            this.textBoxStreet.Location = new System.Drawing.Point(63, 84);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(215, 53);
            this.textBoxStreet.TabIndex = 1;
            this.textBoxStreet.Watermark = "Elm St.";
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.DataBindings.Add(new Wisej.Web.Binding("Text", this.organizationBindingSource, "Country", true, Wisej.Web.DataSourceUpdateMode.OnValidation, null, ""));
            this.textBoxCountry.LabelText = "Country";
            this.textBoxCountry.Location = new System.Drawing.Point(256, 146);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(160, 53);
            this.textBoxCountry.TabIndex = 4;
            this.textBoxCountry.Watermark = "Wakanda";
            // 
            // textBoxCity
            // 
            this.textBoxCity.DataBindings.Add(new Wisej.Web.Binding("Text", this.organizationBindingSource, "City", true, Wisej.Web.DataSourceUpdateMode.OnValidation, null, ""));
            this.textBoxCity.LabelText = "City";
            this.textBoxCity.Location = new System.Drawing.Point(63, 146);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(163, 53);
            this.textBoxCity.TabIndex = 3;
            this.textBoxCity.Watermark = "Springfield";
            // 
            // organizationBindingSource
            // 
            this.organizationBindingSource.DataSource = typeof(Wisej35Sample.Models.Organization);
            // 
            // EditOrganizationModal
            // 
            this.ClientSize = new System.Drawing.Size(481, 299);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxCountry);
            this.Controls.Add(this.textBoxStreet);
            this.Controls.Add(this.textBoxZip);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAccept);
            this.HeaderBackColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditOrganizationModal";
            this.StartPosition = Wisej.Web.FormStartPosition.CenterParent;
            this.Text = "Organization";
            this.Load += new System.EventHandler(this.EditOrganizationModal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.organizationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.Button buttonAccept;
        private Wisej.Web.Button buttonCancel;
        private Wisej.Web.TextBox textBoxName;
        private Wisej.Web.TextBox textBoxZip;
        private Wisej.Web.TextBox textBoxStreet;
        private Wisej.Web.TextBox textBoxCountry;
        private Wisej.Web.TextBox textBoxCity;
        private Wisej.Web.BindingSource organizationBindingSource;
    }
}
