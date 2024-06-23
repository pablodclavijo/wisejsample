using System;
using System.Collections.Generic;
using System.Linq;
using Wisej.Web;
using Wisej35Sample.Models;

namespace Wisej35Sample.ModalForms
{
    public partial class EditPersonModal : Wisej.Web.Form
    {
        private int? _id = null;
        private int _organizationId;
        private Person person = new Person();
        private Database db = Database.Instance;

        public EditPersonModal(int id, int organizationId)
        {
            InitializeComponent();
            _id = id;
            _organizationId = organizationId;
        }
        public EditPersonModal(int organizationId)
        {
            InitializeComponent();
            _organizationId = organizationId;
        }

        private void InitializePersonObject()
        {
            person = _id == null ? new Person()
                : db.GetPersonById((int)_id);
            personBindingSource.DataSource = person;
        }

        private bool formValidated()
        {
            bool[] inputsValidated =
            {
                validateField(textBoxTitle),
                validateField(textBoxName),
                validateField(textBoxLastname),
                validateField(textBoxPhone),
                validateField(textBoxEmail),
            };

            return !inputsValidated.Contains(false);
        }

        private bool validateField(TextBox tb)
        {
            bool hasText = !String.IsNullOrEmpty(tb.Text);
            tb.Invalid = !hasText;
            return hasText;
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (!formValidated()) return;
            try
            {
                if (_id == null)
                {
                    person.OrganizationId = _organizationId;
                    db.InsertPerson(person);
                    AlertBox.Show("Person successfully created");
                }
                else
                {
                    db.UpdatePerson(person);
                    AlertBox.Show("Person successfully updated");
                }
                this.DialogResult = DialogResult.OK;
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error was caught during the insertion: " + ex.Message);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("If you quit now, all unsaved changes will be discarded. Do you want to quit anyway?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.No) return;
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
        }

        private void EditPersonModal_Load(object sender, EventArgs e)
        {
            if (_id != null) person = db.GetPersonById((int)_id); 
            personBindingSource.DataSource = person;
        }
    }
}
