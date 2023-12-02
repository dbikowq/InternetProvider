using InternetProvider.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.Entity.Migrations;

namespace InternetProvider.Pages.ConnectionPages
{
    public class ConnectionEditProviderModel : PageModel
    {
        [BindProperty]
        public Connection Connection { get; set; }
        public IActionResult OnGet(int id)
        {
            var connection = IndexModel.DBProvider.Connections.Find(id);
            if(connection != null)
            {
                Connection = connection;
            }
            return Page();
        }
        public IActionResult OnPost(Connection connection)
        {
            IndexModel.DBProvider.Connections.AddOrUpdate(connection);
            IndexModel.DBProvider.SaveChanges();
            return RedirectToPage("/ConnectionPages/ConnectionProvider");
        }
    }
}
