using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StockAPI_Razor.Data.Entities;
using StockAPI_Razor.Data.Repositories;
using StockAPI_Razor.Models;

namespace StockAPI_Razor.Pages.BrokerCompany
{
    public class NewBrokerAdminModel : PageModel
    {
        private IBrokerCompanyRepository _brokerCompanyRepository;
        public NewBrokerAdminModel(IBrokerCompanyRepository brokerCompanyRepository)
        {
            _brokerCompanyRepository = brokerCompanyRepository;
        }

        [BindProperty]
        public CreateBrokerModel NewBroker { get; set; }
        BrokerAdmin newBrokerAdmin = new BrokerAdmin();
        public void OnGet()
        {
        }
        public async Task <IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                newBrokerAdmin.FirstName = NewBroker.FirstName;
                newBrokerAdmin.LastName = NewBroker.LastName;
                newBrokerAdmin.Password = NewBroker.Password;
                newBrokerAdmin.Email = NewBroker.Email;
                await _brokerCompanyRepository.AddBroker(newBrokerAdmin);
                return RedirectToPage("GetAllBrokers");
            }
            return Page();
        }
    }
}
