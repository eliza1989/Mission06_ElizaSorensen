using System.ComponentModel.DataAnnotations;

//Create a class for the film form that has getters and setters for each element and limits the Notes feild to 25 characters and defines FilmID as the key
namespace Mission06_Sorensen.Models
{
    public class Film
    {

        [Key]
        public int FilmID { get; set; }
        public string Category { get; set; }
        public  string Title { get; set; }

        public string Year { get; set; }

        public string Director { get; set; }

        public string Rating { get; set; }

        public bool Edited { get; set; }

        public string LentTo { get; set; }

        [Range(0, 25)]
        public string Notes { get; set; }
        

    }
}
