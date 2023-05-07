using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyWebApp.Pages;

public class SecondEventModel : PageModel
{
    private readonly ILogger<SecondEventModel> _logger;

    public SecondEventModel(ILogger<SecondEventModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
    
}