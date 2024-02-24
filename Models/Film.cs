using _6.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

//Create a class for the film form that has getters and setters for each element and limits the Notes feild to 25 characters and defines FilmID as the key, and limits min year
namespace Mission06_Sorensen.Models
{
    public class Movies
    {

        [Key]
        [Required]
        public int MovieId { get; set; }

        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }

        [Required(ErrorMessage = "Please Enter a Title")]
        public  string Title { get; set; }

        [Required(ErrorMessage = "Please Enter a Year")]
        [Range(1888, int.MaxValue, ErrorMessage ="Umm This Is Impossible. Please Enter a Year Where Movies Were Made")]
        public int Year { get; set; }

        public string? Director { get; set; }

        public string? Rating { get; set; }

        [Required(ErrorMessage = "Please Enter if the Movie is Edited")]
        public int Edited { get; set; }

        public string? LentTo { get; set; }


        [Required (ErrorMessage ="Please Enter if the Movie is Copied to Plex")]
        public int CopiedToPlex { get; set;}

        [StringLength(25, ErrorMessage ="Please Shorten Your Notes")]
        public string? Notes { get; set; }
        

    }



}
