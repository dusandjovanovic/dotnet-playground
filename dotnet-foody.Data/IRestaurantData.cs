using dotnet_foody.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace dotnet_foody.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetRestaurantsByName(string name);

        Restaurant GetById(int id);
    }

    public class InMemoryRestautantData : IRestaurantData
    {
        List<Restaurant> restaurants;
        public InMemoryRestautantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant { Id = 1, Name = "Scott's pizza", Location = "Maryland", Cuisine = CuisineType.Italian },
                new Restaurant { Id = 2, Name = "Cinneman club", Location = "London", Cuisine = CuisineType.Mexican },
                new Restaurant { Id = 3, Name = "Indian corner", Location = "Trondheim", Cuisine = CuisineType.Indian }
            };
        }

        public IEnumerable<Restaurant> GetRestaurantsByName(string name = null)
        {
            return from r in restaurants
                   where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                   orderby r.Name
                   select r;
        }

        public Restaurant GetById(int id)
        {
            return restaurants.SingleOrDefault(r => r.Id == id);
        }
    }
}
