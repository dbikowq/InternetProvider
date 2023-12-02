using InternetProvider.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InternetProvider.Pages
{
    [IgnoreAntiforgeryToken]
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public static DBProvider DBProvider { get; private set; } = new DBProvider();

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public String Message { get; private set; } = "";
        public void OnGet(String name)
        {
            Message = name;
        }
        public IActionResult OnPostDelete(int id)
        {
            var provider = DBProvider.Providers.Find(id);
            if (provider != null)
            {
                DBProvider.Providers.Remove(provider);
                DBProvider.SaveChanges();
            }
            return RedirectToPage();
        }
    }
}