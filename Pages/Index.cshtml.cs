using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StrayPetOnline.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public int Id { get; set; }
        public string Title { get; set; }
        public string Img { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public void OnPost()
        {

        }
    }
}