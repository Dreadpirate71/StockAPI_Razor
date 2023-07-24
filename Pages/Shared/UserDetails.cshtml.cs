using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StockAPI_Razor.Data.Entities;
using StockAPI_Razor.Data.Repositories;

namespace StockAPI_Razor.Pages.Shared
{
    public class UserDetailsModel : PageModel
    {
        
        private ICustomerRepository _customerRepository;
      
        public UserDetailsModel(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        [FromRoute]
        public int id { get; set; }
        [BindProperty]
        public Customer? CustomerDetails { get; set; }
        public async Task<IActionResult> OnGet()
        {
            CustomerDetails = await _customerRepository.GetCustomerById(id);
            return Page();
        }
    }
}
