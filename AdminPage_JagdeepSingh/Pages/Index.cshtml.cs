using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AdminPage_JagdeepSingh.Contexts;

namespace AdminPage_JagdeepSingh.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly Context _context;


         public IndexModel(ILogger<IndexModel> logger, Context context)
        {
            _logger = logger;
            _context = context;
        }

        public void OnGet()
        {
            ViewData["ProdCount"] =  _context.Products.Count();
            ViewData["ProdList"] = _context.Products.Take(5).ToList();
        }
    }
}
