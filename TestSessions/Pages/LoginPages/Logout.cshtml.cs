using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TestSessions.model;
using TestSessions.services;

namespace TestSessions.Pages.LoginPages
{
    public class LogoutModel : PageModel
    {
        public IActionResult OnGet()
        {
            SessionHelper.Clear<User>(HttpContext);

            return RedirectToPage("/Index");
        }
    }
}
