using System.ComponentModel.DataAnnotations;

namespace ConsoleApp16.Pustok.Models
{
    public  class Genre
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
    }
}
