using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PeopleTest.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }// Key


        [Required]
        [MaxLength(80)]
        public string? CityName { get; set; }
        public List<Person>? People { get; set; }
        public int CountryId { get; set; }
        public Country? Country { get; set; }
    }
}
