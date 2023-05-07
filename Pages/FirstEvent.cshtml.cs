using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyWebApp.Pages;

public class FirstEventModel : PageModel
{
    private readonly ILogger<FirstEventModel> _logger;

    public FirstEventModel(ILogger<FirstEventModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
    
}
