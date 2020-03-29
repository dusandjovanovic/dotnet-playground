using dotnet_foody.Core;
using dotnet_foody.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace dotnet_foody.Pages.Restaurants
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;

        private readonly IRestaurantData restaurantData;

        private readonly ILogger<ListModel> logger;

        public string MessageEnv { get; set; }

        [TempData]
        public string Message { get; set; }

        public IEnumerable<Restaurant> Restaurants { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        public ListModel(IConfiguration config, IRestaurantData restaurantData, ILogger<ListModel> logger)
        {
            this.config = config;
            this.restaurantData = restaurantData;
            this.logger = logger;
        }

        public void OnGet(string searchTerm)
        {
            logger.LogWarning("Executing ListModel::GET");
            MessageEnv = config["Message"];
            Restaurants = restaurantData.GetRestaurantsByName(SearchTerm);
        }
    }
}