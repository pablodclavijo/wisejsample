using System.Collections.Generic;
using System.Data.SQLite;
using System;
using Dapper;
using Wisej35Sample.Models;
using System.Text;
using System.Collections.ObjectModel;
using System.Data.Common;


namespace Wisej35Sample
{
    public sealed class Database
    {
        private static readonly Lazy<Database> instance = new Lazy<Database>(() => new Database());
        private SQLiteConnection connection;
        private string connectionString = "Data Source=WisejSample.db;Version=3;";

        private Database()
        {
            connection = new SQLiteConnection(connectionString);
            connection.Open();
            SetupDatabase();
        }

        public static Database Instance
        {
            get { return instance.Value; }
        }

        private void SetupDatabase()
        {
            connection.Execute(@"
                CREATE TABLE IF NOT EXISTS Organizations (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT, 
                    Name TEXT, 
                    Street TEXT, 
                    Zip TEXT, 
                    City TEXT, 
                    Country TEXT
                )");

            connection.Execute(@"
                CREATE TABLE IF NOT EXISTS People (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT, 
                    Title TEXT, 
                    FirstName TEXT, 
                    LastName TEXT, 
                    PhoneNumber TEXT, 
                    Email TEXT, 
                    OrganizationId INTEGER,
                    FOREIGN KEY (OrganizationId) REFERENCES Organizations(Id)
                )");
        }

        #region Organization CRUD

        public void InsertOrganization(Organization organization)
        {
            string sql = "INSERT INTO Organizations (Name, Street, Zip, City, Country) VALUES (@Name, @Street, @Zip, @City, @Country)";
            connection.Execute(sql, organization);
        }

        public Collection<Organization> GetOrganizations()
        {
            var organizations = connection.Query<Organization>("SELECT * FROM Organizations").AsList();
            return new Collection<Organization>(organizations);
        }

        public Organization GetOrganizationById(int id)
        {
            return connection.QueryFirstOrDefault<Organization>("SELECT * FROM Organizations WHERE Id = @Id", new { Id = id });
        }

        public void UpdateOrganization(Organization organization)
        {
            var updateQuery = new StringBuilder("UPDATE Organizations SET ");
            var parameters = new DynamicParameters();

            if (!string.IsNullOrEmpty(organization.Name))
            {
                updateQuery.Append("Name = @Name, ");
                parameters.Add("Name", organization.Name);
            }
            if (!string.IsNullOrEmpty(organization.Street))
            {
                updateQuery.Append("Street = @Street, ");
                parameters.Add("Street", organization.Street);
            }
            if (!string.IsNullOrEmpty(organization.Zip))
            {
                updateQuery.Append("Zip = @Zip, ");
                parameters.Add("Zip", organization.Zip);
            }
            if (!string.IsNullOrEmpty(organization.City))
            {
                updateQuery.Append("City = @City, ");
                parameters.Add("City", organization.City);
            }
            if (!string.IsNullOrEmpty(organization.Country))
            {
                updateQuery.Append("Country = @Country, ");
                parameters.Add("Country", organization.Country);
            }

            // Remove the last comma and space
            updateQuery.Length -= 2;

            updateQuery.Append(" WHERE Id = @Id");
            parameters.Add("Id", organization.Id);

            connection.Execute(updateQuery.ToString(), parameters);
        }

        public void DeleteOrganization(int id)
        {
            connection.Execute("DELETE FROM Organizations WHERE Id = @Id", new { Id = id });
        }

        #endregion

        #region Person CRUD

        public void InsertPerson(Person person)
        {
            string sql = "INSERT INTO People (Title, FirstName, LastName, PhoneNumber, Email, OrganizationId) VALUES (@Title, @FirstName, @LastName, @PhoneNumber, @Email, @OrganizationId)";
            connection.Execute(sql, person);
        }

        public Collection<Person> GetPeople(int organizationId)
        {
            var people = connection.Query<Person>("SELECT * FROM People where OrganizationId = @OrganizationId", new { OrganizationId = organizationId }).AsList();
            return new Collection<Person>(people);
        }

        public Person GetPersonById(int id)
        {
            return connection.QueryFirstOrDefault<Person>("SELECT * FROM People WHERE Id = @Id", new { Id = id });
        }

        public void UpdatePerson(Person person)
        {
            var updateQuery = new StringBuilder("UPDATE People SET ");
            var parameters = new DynamicParameters();

            if (!string.IsNullOrEmpty(person.Title))
            {
                updateQuery.Append("Title = @Title, ");
                parameters.Add("Title", person.Title);
            }
            if (!string.IsNullOrEmpty(person.FirstName))
            {
                updateQuery.Append("FirstName = @FirstName, ");
                parameters.Add("FirstName", person.FirstName);
            }
            if (!string.IsNullOrEmpty(person.LastName))
            {
                updateQuery.Append("LastName = @LastName, ");
                parameters.Add("LastName", person.LastName);
            }
            if (!string.IsNullOrEmpty(person.PhoneNumber))
            {
                updateQuery.Append("PhoneNumber = @PhoneNumber, ");
                parameters.Add("PhoneNumber", person.PhoneNumber);
            }
            if (!string.IsNullOrEmpty(person.Email))
            {
                updateQuery.Append("Email = @Email, ");
                parameters.Add("Email", person.Email);
            }
            if (person.OrganizationId != 0)
            {
                updateQuery.Append("OrganizationId = @OrganizationId, ");
                parameters.Add("OrganizationId", person.OrganizationId);
            }

            updateQuery.Length -= 2;

            updateQuery.Append(" WHERE Id = @Id");
            parameters.Add("Id", person.Id);

            connection.Execute(updateQuery.ToString(), parameters);
        }

        public void DeletePerson(int id)
        {
            connection.Execute("DELETE FROM People WHERE Id = @Id", new { Id = id });
        }

        public void DeleteMembersFromOrg(int organizationId)
        {
            connection.Execute("DELETE FROM People WHERE OrganizationId = @Id", new { Id = organizationId });
        }

        #endregion
    }
}
