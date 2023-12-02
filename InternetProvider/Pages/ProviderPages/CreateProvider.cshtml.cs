using InternetProvider.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InternetProvider.Pages.ProviderPages
{
    public class CreateProviderModel : PageModel
    {
        [BindProperty]
        public Provider Provider { get; set; } = new Provider();

        public void OnGet()
        {

        }
        public IActionResult OnPostAsync()
        {
            IndexModel.DBProvider.Providers.Add(Provider);
            IndexModel.DBProvider.SaveChanges();
            return RedirectToPage("/Index");
        }
    }
}
