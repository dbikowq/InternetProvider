using InternetProvider.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.Entity.Migrations;

namespace InternetProvider.Pages.ClientPages
{
    public class EditProviderModel : PageModel
    {
        public Client Client { get; set; }
        public IActionResult OnGet(int id)
        {
            //var client = IndexModel.DBProvider.Clients.Include("House").FirstOrDefault(x=>x.Id==id);
            var client = IndexModel.DBProvider.Clients.Find(id);
            if (client != null)
            {
                Client = client;
            }
            return Page();
        }

        public IActionResult OnPost(int id, int number, String address) 
        {
            var client = IndexModel.DBProvider.Clients.Find(id);
            if (client != null)
            {
                client.House.Number = number;
                client.House.Address = address;
                IndexModel.DBProvider.Clients.AddOrUpdate(client);
                IndexModel.DBProvider.SaveChanges();
                return RedirectToPage("/ClientPages/ClientProvider");
            }
            else
            {
                return NotFound();
            }
            
        }
    }
}
