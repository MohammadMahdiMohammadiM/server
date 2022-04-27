using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AWA.Pages
{
    public class Page002Model : Infrastructure.BasePageModel
    {
        public Page002Model()
        {

        }

        public string? FullName { get; set; }
        public void OnGet()
        {
            FullName = "Artan Arian";
        }
    }
}
