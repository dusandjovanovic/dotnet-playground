using System.ComponentModel.DataAnnotations;

namespace dotnet_foody.Core
{
    public class Restaurant
    {
        [Required]
        public int Id { get; set; }

        [Required, StringLength(128)]
        public string Name { get; set; }

        [Required, StringLength(128)]
        public string Location { get; set; }

        public CuisineType Cuisine { get; set; }
    }
}