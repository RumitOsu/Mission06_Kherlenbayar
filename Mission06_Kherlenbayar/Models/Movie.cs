using Microsoft.CodeAnalysis.Options;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Emit;
using System.Text.RegularExpressions;

namespace Mission06_Kherlenbayar.Models
{
    public class Movie
    {
        public int MovieId { get; set; }

        [Required]
        public int CategoryId { get; set; } // Foreign key for the Category

        [Required]
        [MaxLength(255)]
        public string? Title { get; set; }

        [Required]
        [Range(1888, int.MaxValue, ErrorMessage = "Year must be greater than 1888")]
        public int Year { get; set; } // Year the movie was released

        [MaxLength(255)] // sensible maximum length for Director's name
        public string? Director { get; set; } // Director of the movie

        [MaxLength(50)] // a sensible maximum length for Rating
        public string? Rating { get; set; } // Rating, e.g., PG, R

        [Required]
        public bool Edited { get; set; } // Whether the movie is edited

        public string? LentTo { get; set; }

        [Required]
        public int CopiedToPlex { get; set; } // 0 for No, 1 for Yes


        [MaxLength(25)]
        public string? Notes { get; set; } // Additional notes about the movie

        // Navigation property for the Category
        public Category Category { get; set; }
    }
    public class Category
    {
        public int CategoryId { get; set; } // Primary key

        [Required]
        [MaxLength(255)] // sensible maximum length for CategoryName
        public string? CategoryName { get; set; }

        // Navigation property for related Movies
        public ICollection<Movie> Movies { get; set; }
    }
}