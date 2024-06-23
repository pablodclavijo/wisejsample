using System.Collections.Generic;

namespace Wisej35Sample.Models
{
    public class Organization
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public ICollection<Person> People { get; set; }
    }
}
