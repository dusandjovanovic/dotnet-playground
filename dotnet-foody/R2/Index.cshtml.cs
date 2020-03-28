using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using dotnet_foody.Core;
using dotnet_foody.Data;

namespace dotnet_foody.R2
{
    public class IndexModel : PageModel
    {
        private readonly dotnet_foody.Data.DotnetFoodyDbContext _context;

        public IndexModel(dotnet_foody.Data.DotnetFoodyDbContext context)
        {
            _context = context;
        }

        public IList<Restaurant> Restaurant { get;set; }

        public async Task OnGetAsync()
        {
            Restaurant = await _context.Restaurants.ToListAsync();
        }
    }
}
