using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.DirectoryServices.AccountManagement;

public class IndexModel : PageModel
{
    public string Message { get; set; }

    public void OnGet()
    {
    }

    public IActionResult OnPostLogin(string username, string password)
    {
        using (var context = new PrincipalContext(ContextType.Domain, "YOURDOMAIN"))
        {
            bool isValid = context.ValidateCredentials(username, password);
            if (isValid)
            {
                Message = "Authentication successful";
            }
            else
            {
                Message = "Authentication failed";
            }
        }
        return Page();
    }
}
