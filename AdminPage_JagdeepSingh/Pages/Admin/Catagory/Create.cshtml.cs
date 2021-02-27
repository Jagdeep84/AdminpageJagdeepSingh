using AdminPage_JagdeepSingh.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AdminPage_JagdeepSingh.Models;
namespace AdminPage_JagdeepSingh.Pages.Admin.Catagory
{
    public class CatagoryCreateModel : PageModel
    {
        private readonly Context _context;

        [FromForm]
        public AdminPage_JagdeepSingh.Models.Category Category { get; set; }

        public CatagoryCreateModel(Context context)
        {
            _context = context;
        }
        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (Category.categoryName != null)
            {
                _context.Add(Category);
                _context.SaveChanges();
            }

        }
    }
}
