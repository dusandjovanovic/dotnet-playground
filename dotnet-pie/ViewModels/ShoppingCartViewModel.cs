using dotnet_pie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_pie.ViewModels
{
    public class ShoppingCartViewModel
    {
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }

        public decimal ShoppingCartTotal { get; set; }
    }
}
