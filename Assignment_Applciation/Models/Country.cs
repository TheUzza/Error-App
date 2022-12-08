using System.ComponentModel.DataAnnotations;

namespace PeopleTest.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }
        public List<City>? Cities { get; set; }
        [Required]
        [MaxLength(80)]
        public string? CountryName { get; set; }
    }
}
