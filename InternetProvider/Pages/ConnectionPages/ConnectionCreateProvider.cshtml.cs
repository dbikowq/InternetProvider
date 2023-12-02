using InternetProvider.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InternetProvider.Pages.ConnectionPages
{
    public class ConnectionCreateProviderModel : PageModel
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
            IndexModel.DBProvider.Connections.Add(connection);
            IndexModel.DBProvider.SaveChanges();
            return RedirectToPage("/ConnectionPages/ConnectionProvider");
        }
    }
}
