using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StockAPI_Razor.Data.Entities;
using StockAPI_Razor.Data.Repositories;
using StockAPI_Razor.Models;

namespace StockAPI_Razor.Pages.User
{
    public class NewUserModel : PageModel
    {
        private ICustomerRepository _customerRepository;
        
        public NewUserModel(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        [BindProperty]
        public CreateUserModel NewUser { get; set; }
        Customer newCustomer = new Customer();
        
        public void OnGet()
        {
        }
        public async Task <IActionResult> OnPost() 
        {
            //save product to database
            if(ModelState.IsValid)
            {
                newCustomer.FirstName = NewUser.FirstName;
                newCustomer.LastName = NewUser.LastName;
                newCustomer.Address = NewUser.Address;
                newCustomer.City = NewUser.City;
                newCustomer.State = NewUser.State;
                newCustomer.PostalCode = NewUser.PostalCode;
                newCustomer.PhoneNumber =   NewUser .PhoneNumber;
                newCustomer.Email = NewUser.Email;
                newCustomer.Password = NewUser.Password;
                newCustomer.AccountBalance = NewUser.AccountBalance;
                await _customerRepository.AddCustomer(newCustomer);
                return RedirectToPage("UserDetails");
            }
            return Page();
        
        }
    }
}
