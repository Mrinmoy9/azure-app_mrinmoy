using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using azure_app_mrinmoy.Data;

namespace azure_app_mrinmoy.Pages_Persons1
{
    public class IndexModel : PageModel
    {
        private readonly azure_app_mrinmoy.Data.AppDbContext _context;

        public IndexModel(azure_app_mrinmoy.Data.AppDbContext context)
        {
            _context = context;
        }

        public IList<Person> Person { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Person = await _context.persons.ToListAsync();
        }
    }
}
