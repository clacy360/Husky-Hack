using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyWebApp.Pages;

public class MonthlyEventModel : PageModel
{
    private readonly ILogger<MonthlyEventModel> _logger;

    public MonthlyEventModel(ILogger<MonthlyEventModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
    
}
