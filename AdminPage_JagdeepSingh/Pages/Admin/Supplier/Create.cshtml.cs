using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminPage_JagdeepSingh.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AdminPage_JagdeepSingh.Pages.Admin.Supplier
{
    public class SupplierCreateModel : PageModel
    {
        private readonly Context _context;

        [FromForm]
        public AdminPage_JagdeepSingh.Models.Supplier Supplier { get; set; }
        public SupplierCreateModel(Context context)
        {
            _context = context;
        }
        public void OnGet()
        {
        }
        public void OnPost()
        {
            if (Supplier.companyName != null && Supplier.contactName != null)
            {
                _context.Add(Supplier);
                _context.SaveChanges();
            }

        }
    }
}
