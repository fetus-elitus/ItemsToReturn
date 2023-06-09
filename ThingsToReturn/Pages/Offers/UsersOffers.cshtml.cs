using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace ThingsToReturn.Pages
{
    [BindProperties]
    [Authorize]
    public class UsersOffersModel: PageModel
    {
        private readonly IOfferService _offerService;
        public OfferToListVM OfferList { get; set; }

        public UsersOffersModel(ILogger<UsersOffersModel> logger, IOfferService offerService)
        {
            _offerService = offerService;
        }
        public void OnGet()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            OfferList = _offerService.GetUsersOffers(claim);
        }

        public IActionResult OnPost()
        {
            return Page();
        }
    }
}
