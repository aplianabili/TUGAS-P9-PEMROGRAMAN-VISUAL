using System.ComponentModel.DataAnnotations;

namespace DataBukuApp.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Author { get; set; }

        public int Year { get; set; }
    }
}
