namespace Mission06_Sorensen.Models
{
    public class Film
    {
        public int FilmID { get; }
        public string Category { get; set; }
        public  string Title { get; set; }

        public string Year { get; set; }

        public string Director { get; set; }

        public string Rating { get; set; }

        public bool Edited { get; set; }

        public string LentTo { get; set; }

        public string Notes { get; set; }

    }
}
