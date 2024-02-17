using System.ComponentModel.DataAnnotations;

namespace Mission06_Kherlenbayar.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        
        [Required]
        public string Title { get; set; }
        
        [Required]
        public string Director { get; set; }
        
        [Required]
        public int Year { get; set; }
        
        [Required]
        public string Rating { get; set; }
        
        public bool Edited { get; set; }

        // Make these properties nullable
        public string? LentTo { get; set; }

        [MaxLength(25)]
        public string? Notes { get; set; }
    }
}
