using InternetProvider.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InternetProvider.Pages.ClientPages
{
    public class ClientCreateProviderModel : PageModel
    {
        public void OnGet()
        {
        }
        public IActionResult OnPost(int number, String address) 
        {
            Client client = new Client();
            client.House = new House() { Number = number,Address=address };
            IndexModel.DBProvider.Clients.Add(client);
            IndexModel.DBProvider.SaveChanges();
            return RedirectToPage("/ClientPages/ClientProvider");
        }

    }
}
