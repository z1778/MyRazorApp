using System.Text.Json;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyRazorApp.Models;

namespace MyRazorApp.Pages.Staff;

public class IndexModel : PageModel
{
    private readonly IWebHostEnvironment _environment;

    // Inject IWebHostEnvironment to safely resolve server file paths
    public IndexModel(IWebHostEnvironment environment)
    {
        _environment = environment;
    }

    // Strongly-typed list exposed to the Razor View via @Model.StaffList
    public List<StaffMember> StaffList { get; set; } = [];

    public async Task OnGetAsync()
    {
        // Resolve absolute path to data/staff.json
        var filePath = Path.Combine(_environment.ContentRootPath, "data", "staff.json");

        if (System.IO.File.Exists(filePath))
        {
            var jsonString = await System.IO.File.ReadAllTextAsync(filePath);

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            StaffList = JsonSerializer.Deserialize<List<StaffMember>>(jsonString, options) ?? [];
        }
    }
}