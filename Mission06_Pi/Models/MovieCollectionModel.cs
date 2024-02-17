using System.ComponentModel.DataAnnotations;

namespace Mission06_Pi.Models
{
    public class MovieCollectionModel
    {
        [Key]
        [Required]
        public int MovieID { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }
        public bool? Edited { get; set; }
        public string? Lent_To { get; set; }
        [StringLength(25, ErrorMessage = "Notes must not exceed 25 characters long")]
        public string? Notes { get; set; }
    }
}
