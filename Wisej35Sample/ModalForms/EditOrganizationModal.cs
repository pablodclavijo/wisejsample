using System;
using System.Linq;
using Wisej.Web;
using Wisej35Sample.Models;


namespace Wisej35Sample.ModalForms
{
    public partial class EditOrganizationModal : Wisej.Web.Form
    {
        private int? _id = null;
        private Organization organization = new Organization();
        private Database db = Database.Instance;
        public EditOrganizationModal(int id)
        {
            InitializeComponent();
            _id = id;
        }
        public EditOrganizationModal()
        {
            InitializeComponent();
        }

        private void InitializeOrganizationObject()
        {
            organization = _id == null ? new Organization()
                : db.GetOrganizationById((int)_id);
            organizationBindingSource.DataSource = organization;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("If you quit now, all unsaved changes will be discarded. Do you want to quit anyway?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.No) return;
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (!formValidated()) return;
            try
            {
                if(_id == null)
                {
                    db.InsertOrganization(organization);
                    AlertBox.Show("Organization successfully created");
                }
                else
                {
                    db.UpdateOrganization(organization);
                    AlertBox.Show("Organization successfully updated");
                }
                this.DialogResult = DialogResult.OK;
                this.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error was caught during the insertion: " + ex.Message);
            }
         }

        private bool formValidated()
        {
            bool[] inputsValidated =
            {
                validateField(textBoxName),
                validateField(textBoxStreet),
                validateField(textBoxZip),
                validateField(textBoxCity),
                validateField(textBoxCountry)
            };

            return !inputsValidated.Contains(false); 
        }

        private bool validateField(TextBox tb)
        {
            bool hasText = !String.IsNullOrEmpty(tb.Text);
            tb.Invalid = !hasText;
            return hasText;
        }

        private void EditOrganizationModal_Load(object sender, EventArgs e)
        {
            if(_id != null)
            {
                organization = db.GetOrganizationById((int)_id);
            }
            organizationBindingSource.DataSource = organization;
        }
    }
}
