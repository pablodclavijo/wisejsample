using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Wisej.Web;
using Wisej35Sample.ModalForms;
using Wisej35Sample.Models;

namespace Wisej35Sample
{
    public partial class MainPage : Form
    {
        private int? organizationId = null;
        private int? personId = null;
        private Collection<Organization> organizations = new Collection<Organization>();
        private Collection<Person> people = new Collection<Person>();
        private Database db = Database.Instance;
        public MainPage()
        {
            InitializeComponent();
        }

        private void dataGridViewOrganization_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                organizationId = null;
                personId = null;
                return;
            }
            organizationId = (int)dataGridViewOrganization.Rows[e.RowIndex].Cells[0].Value;
            loadPeople();
            personId = null;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                personId = null;
                return;
            }
            personId = (int)dataGridView2.Rows[e.RowIndex].Cells[0].Value;
        }

        private void loadOrganizations()
        
        {
            organizations = db.GetOrganizations();
            organizationBindingSource.DataSource = organizations;
            organizationId = null;
            dataGridViewOrganization.ClearSelection();
            people.Clear();
            personId = null;
            Application.Update(this);
        }
        private void loadPeople()
        {
            people.Clear();
            personId = null;
            if(organizationId != null) people = (Collection<Person>)db.GetPeople((int)organizationId);
            personBindingSource.DataSource = people;
            dataGridView2.ClearSelection();
        }
        private void buttonAddOrganization_Click(object sender, EventArgs e)
        {
            EditOrganizationModal modal = new EditOrganizationModal();
            DialogResult dr = modal.ShowDialog();
            if (dr == DialogResult.OK) loadOrganizations();
        }

        private void buttonEditOrganization_Click(object sender, EventArgs e)
        {
            if (organizationId == null)
            {
                AlertBox.Show("Please select an organization from the grid", MessageBoxIcon.Error);
                return;
            }

            EditOrganizationModal modal = new EditOrganizationModal((int)organizationId);
            DialogResult dr = modal.ShowDialog();
            if (dr == DialogResult.OK) loadOrganizations();
        }

        private void buttonDeleteOrganization_Click(object sender, EventArgs e)
        {
            if (organizationId == null)
            {
                AlertBox.Show("Please select an organization from the grid", MessageBoxIcon.Error);
                return;
            }
            DialogResult dr = MessageBox.Show("Are you sure you want to delete the organization? This action is permanent", "Delete Organization", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            db.DeleteOrganization((int)organizationId);
            db.DeleteMembersFromOrg((int)organizationId);
            loadPeople();
            loadOrganizations();
        }

        private void buttonAddMember_Click(object sender, EventArgs e)
        {
            if(organizationId == null)
            {
                AlertBox.Show("Select an organization from the grid to add a member", MessageBoxIcon.Error);
                return;
            }
            EditPersonModal modal = new EditPersonModal((int)organizationId);
            DialogResult dr = modal.ShowDialog();
            if (dr == DialogResult.OK) reloadMembers();
        }

        private void buttonEditMember_Click(object sender, EventArgs e)
        {
            if (personId == null)
            {
                AlertBox.Show("Please select a person from the grid", MessageBoxIcon.Error);
                return;
            }
            EditPersonModal modal = new EditPersonModal((int)personId, (int)organizationId);
            DialogResult dr = modal.ShowDialog();
            if (dr == DialogResult.OK) reloadMembers();
        }

        private void buttonDeleteMember_Click(object sender, EventArgs e)
        {
            if (personId == null)
            {
                AlertBox.Show("Please select a person from the grid", MessageBoxIcon.Error);
                return;
            }
            DialogResult dr = MessageBox.Show("Are you sure you want to delete the person? This action is permanent", "Delete Member", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            db.DeletePerson((int)personId);
            reloadMembers();
        }

        private void reloadMembers()
        {
            people = (Collection<Person>)db.GetPeople((int)organizationId);
            personBindingSource.DataSource = people;
            dataGridView2.ClearSelection();
            personId = null;
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            loadOrganizations();
        }

    }
}
