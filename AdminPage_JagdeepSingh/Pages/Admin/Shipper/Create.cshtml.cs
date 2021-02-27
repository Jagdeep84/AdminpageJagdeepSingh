using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminPage_JagdeepSingh.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AdminPage_JagdeepSingh.Pages.Admin.Shipper
{
    public class ShipperCreateModel : PageModel
    {
        private readonly Context _context;

        [FromForm]
        public AdminPage_JagdeepSingh.Models.Shipper Shipper { get; set; }
        public ShipperCreateModel(Context context)
        {
            _context = context;
        }
        public void OnGet()
        {
        }
        public void OnPost()
        {
            if (Shipper.companyName != null)
            {
                _context.Add(Shipper);
                _context.SaveChanges();
            }

        }
    }
}
