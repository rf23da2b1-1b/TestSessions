using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TestSessions.model;
using TestSessions.services;

namespace TestSessions.Pages.LoginPages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public String Name { get; set; }

        [BindProperty]
        public String Pass { get; set; }

        [BindProperty]
        public String ErrorMsg { get; set; }


        public void OnGet()
        {
            ErrorMsg = string.Empty;
        }

        public IActionResult OnPost()
        {
            if (Name is null || Pass is null)
            {
                ErrorMsg = "Du skal skrive navn og Kodeord";
                return Page();
            } 

            if (Name != "Peter" || Pass != "Secret")
            {
                ErrorMsg = "Navn eller Kodeord er ikke korrekt";
                return Page();
            }

            User user = new User(Name);
            SessionHelper.Set(user, HttpContext);

            return RedirectToPage("/Personer/Index");
        }
    }
}
