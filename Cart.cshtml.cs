using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ecommercePageRazor.Extensions;
using ecommercePageRazor.Models;

namespace ecommercePageRazor.Pages.Products
{
    public class CartModel : PageModel
    {
        public List<CartLine>? CartItems { get; set; }
        public void OnGet()
        {
            Cart cart = HttpContext.Session.Get<Cart>("Cart") ?? new Cart();
            CartItems = cart.Items;
        }
    }
}
