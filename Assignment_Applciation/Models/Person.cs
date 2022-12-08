using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PeopleTest.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }


        public int CityId { get; set; }
        public City? City { get; set; }
        public List<Language>? Languages { get; set; }
    }
}
