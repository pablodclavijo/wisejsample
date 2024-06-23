using System.Collections.Generic;

namespace Wisej35Sample.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int OrganizationId { get; set; }
        public Organization Organization { get; set; }

    }
}
