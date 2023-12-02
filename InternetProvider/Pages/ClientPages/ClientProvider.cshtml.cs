using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InternetProvider.Pages.ClientPages
{
    public class ClientProviderModel : PageModel
    {
        public void OnGet()
        {
        }
        public IActionResult OnPost(int id) 
        { 
            var client = IndexModel.DBProvider.Clients.Find(id);
            if(client != null)
            {
                IndexModel.DBProvider.Clients.Remove(client);
                IndexModel.DBProvider.SaveChanges();
            }
            return Page();
        }
    }
}
