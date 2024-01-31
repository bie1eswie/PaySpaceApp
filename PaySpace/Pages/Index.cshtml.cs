using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PaySpace.Model.Models;
using PaySpace.Service.Abstract;

namespace PaySpace.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ICalculatorRequestService calculatorRequestService;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        [BindProperty]
        public CalculatorRequest CalculatorRequest { get; set; }
        //public async Task<IActionResult> OnPostAsync()
        //{
        //    var response = calculatorRequestService.GetCalculatorResponse(CalculatorRequest);
            
        //}
    }
}