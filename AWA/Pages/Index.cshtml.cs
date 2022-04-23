using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AWA.Pages
{
    public class IndexModel : Infrastructure.BasePageModel
    {
        public IndexModel() : base()
        {

        }
        public string? FullName { get; set; }
        public void OnGet()
        {
            FullName = "Artan Arian";
        }
    }
}