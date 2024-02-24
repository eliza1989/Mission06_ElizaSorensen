using System.ComponentModel.DataAnnotations;


// create a model of type category that holds the ID and Name and uses the Category Id as the key
namespace _6.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        public string? CategoryName { get; set; }    
    }
}
