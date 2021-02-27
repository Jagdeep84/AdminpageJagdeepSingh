using Microsoft.AspNetCore.Mvc.RazorPages;
using AdminPage_JagdeepSingh.Models;
using Microsoft.AspNetCore.Mvc;
using AdminPage_JagdeepSingh.Contexts;

namespace AdminPage_JagdeepSingh.Pages.Admin
{
    
    public class ProductCreateModel : PageModel
    {
        private readonly Context _context;

        [FromForm]
       public AdminPage_JagdeepSingh.Models.Product Product { get; set; }

        public ProductCreateModel(Context context)
        {
            _context = context;
        }
        public void OnGet()
        {

        }

        public void OnPost()
        {
            if (Product.productName != null)
            {
                _context.Add(Product);
                _context.SaveChanges();
            }
            
        }
    }
}
