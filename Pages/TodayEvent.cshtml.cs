using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyWebApp.Pages;

public class TodayEventModel : PageModel
{
    private readonly ILogger<TodayEventModel> _logger;

    public TodayEventModel(ILogger<TodayEventModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
    
}
