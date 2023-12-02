using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InternetProvider.Pages.ConnectionPages
{
    public class ConnectionProviderModel : PageModel
    {
        public void OnGet()
        {
        }
        public IActionResult OnPost(int id) 
        {
            var connection = IndexModel.DBProvider.Connections.Find(id);
            if (connection != null)
            {
                IndexModel.DBProvider.Connections.Remove(connection);
                IndexModel.DBProvider.SaveChanges();
            }
            return Page();
        }

    }
}
