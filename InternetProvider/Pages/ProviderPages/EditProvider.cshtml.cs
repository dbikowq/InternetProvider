using InternetProvider.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.Entity.Migrations;

namespace InternetProvider.Pages.ProviderPages
{
    public class EditProviderModel : PageModel
    {
        [BindProperty]
        public Provider? Provider { get; set; }

        public IActionResult OnGet(int id)
        {
            var pr = IndexModel.DBProvider.Providers.Find(id);
            if (pr == null) return NotFound();
            Provider = pr;
            return Page();
        }
        public IActionResult OnPost()
        {
            IndexModel.DBProvider.Providers.AddOrUpdate(Provider);
            IndexModel.DBProvider.SaveChanges();

            return RedirectToPage("/Index");
        }
    }
}
