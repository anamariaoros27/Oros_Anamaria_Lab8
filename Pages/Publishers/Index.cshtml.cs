using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Oros_Anamaria_Lab8.Data;
using Oros_Anamaria_Lab8.Models;

namespace Oros_Anamaria_Lab8.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Oros_Anamaria_Lab8.Data.Oros_Anamaria_Lab8Context _context;

        public IndexModel(Oros_Anamaria_Lab8.Data.Oros_Anamaria_Lab8Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; }
  

        public async Task OnGetAsync()
        {
            Publisher = await _context.Publisher.ToListAsync();
        }
    }
}
