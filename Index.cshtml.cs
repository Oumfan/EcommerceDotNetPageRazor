using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ecommercePageRazor.Data;
using ecommercePageRazor.Models;

namespace ecommercePageRazor.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly ecommercePageRazor.Data.ApplicationDbContext _context;

        public IndexModel(ecommercePageRazor.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.User != null)
            {
                User = await _context.User.ToListAsync();
            }
        }
    }
}
