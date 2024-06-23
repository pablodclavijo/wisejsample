namespace Wisej35Sample.ModalForms
{
    partial class EditPersonModal
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
            this.textBoxPhone = new Wisej.Web.TextBox();
            this.personBindingSource = new Wisej.Web.BindingSource(this.components);
            this.textBoxEmail = new Wisej.Web.TextBox();
            this.textBoxName = new Wisej.Web.TextBox();
            this.textBoxLastname = new Wisej.Web.TextBox();
            this.textBoxTitle = new Wisej.Web.TextBox();
            this.buttonCancel = new Wisej.Web.Button();
            this.buttonAccept = new Wisej.Web.Button();
            this.organizationBindingSource = new Wisej.Web.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.DataBindings.Add(new Wisej.Web.Binding("Text", this.personBindingSource, "PhoneNumber", true, Wisej.Web.DataSourceUpdateMode.OnValidation, null, ""));
            this.textBoxPhone.LabelText = "Phone Number";
            this.textBoxPhone.Location = new System.Drawing.Point(64, 161);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(160, 53);
            this.textBoxPhone.TabIndex = 3;
            this.textBoxPhone.Watermark = "0123456789";
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(Wisej35Sample.Models.Person);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.DataBindings.Add(new Wisej.Web.Binding("Text", this.personBindingSource, "Email", true, Wisej.Web.DataSourceUpdateMode.OnValidation, null, ""));
            this.textBoxEmail.LabelText = "Email";
            this.textBoxEmail.Location = new System.Drawing.Point(257, 161);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(160, 53);
            this.textBoxEmail.TabIndex = 4;
            this.textBoxEmail.Watermark = "email@domain.com";
            // 
            // textBoxName
            // 
            this.textBoxName.DataBindings.Add(new Wisej.Web.Binding("Text", this.personBindingSource, "FirstName", true, Wisej.Web.DataSourceUpdateMode.OnValidation, null, ""));
            this.textBoxName.LabelText = "Name";
            this.textBoxName.Location = new System.Drawing.Point(64, 91);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(160, 53);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.Watermark = "Dwight";
            // 
            // textBoxLastname
            // 
            this.textBoxLastname.DataBindings.Add(new Wisej.Web.Binding("Text", this.personBindingSource, "LastName", true, Wisej.Web.DataSourceUpdateMode.OnValidation, null, ""));
            this.textBoxLastname.LabelText = "Last Name";
            this.textBoxLastname.Location = new System.Drawing.Point(257, 91);
            this.textBoxLastname.Name = "textBoxLastname";
            this.textBoxLastname.Size = new System.Drawing.Size(160, 53);
            this.textBoxLastname.TabIndex = 2;
            this.textBoxLastname.Watermark = "Schrute";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.DataBindings.Add(new Wisej.Web.Binding("Text", this.personBindingSource, "Title", true, Wisej.Web.DataSourceUpdateMode.OnValidation, null, ""));
            this.textBoxTitle.LabelText = "Title";
            this.textBoxTitle.Location = new System.Drawing.Point(65, 22);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(353, 53);
            this.textBoxTitle.TabIndex = 0;
            this.textBoxTitle.Watermark = "Assistant to the Regional Mangaer";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.LightCoral;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonCancel.ForeColor = System.Drawing.Color.FromName("@appWorkspace");
            this.buttonCancel.Location = new System.Drawing.Point(273, 244);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 37);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAccept
            // 
            this.buttonAccept.BackColor = System.Drawing.Color.LightGreen;
            this.buttonAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonAccept.ForeColor = System.Drawing.Color.FromName("@appWorkspace");
            this.buttonAccept.Location = new System.Drawing.Point(108, 244);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(100, 37);
            this.buttonAccept.TabIndex = 5;
            this.buttonAccept.Text = "Accept";
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // organizationBindingSource
            // 
            this.organizationBindingSource.DataSource = typeof(Wisej35Sample.Models.Organization);
            // 
            // EditPersonModal
            // 
            this.ClientSize = new System.Drawing.Size(481, 299);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxLastname);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAccept);
            this.HeaderBackColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditPersonModal";
            this.StartPosition = Wisej.Web.FormStartPosition.CenterParent;
            this.Text = "Person";
            this.Load += new System.EventHandler(this.EditPersonModal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.TextBox textBoxPhone;
        private Wisej.Web.TextBox textBoxEmail;
        private Wisej.Web.TextBox textBoxName;
        private Wisej.Web.TextBox textBoxLastname;
        private Wisej.Web.TextBox textBoxTitle;
        private Wisej.Web.Button buttonCancel;
        private Wisej.Web.Button buttonAccept;
        private Wisej.Web.BindingSource personBindingSource;
        private Wisej.Web.BindingSource organizationBindingSource;
    }
}
