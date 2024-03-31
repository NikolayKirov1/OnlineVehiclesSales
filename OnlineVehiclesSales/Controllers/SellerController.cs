using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineVehiclesSales.Core.Models.Seller;

namespace OnlineVehiclesSales.Controllers
{
    [Authorize]
    public class SellerController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Become()
        {
            var model = new BecomeSellerFormModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Become(BecomeSellerFormModel model)
        {
            return RedirectToAction(nameof(CarController.All), "House");
        }
    }
}
