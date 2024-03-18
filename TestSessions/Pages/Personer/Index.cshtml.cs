using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TestSessions.model;
using TestSessions.services;

namespace TestSessions.Pages.Personer
{
    public class IndexModel : PageModel
    {
        public User User{ get; set; }
        public IActionResult OnGet()
        {

            try
            {
                User = SessionHelper.Get<User>(HttpContext);
                return Page();
            }
            catch (NoSessionObjectException ne)
            {
                return RedirectToPage("/LoginPages/Login");
            }


        }
    }
}
