using BasicWebDevelopmentProject.Helpers;
using BasicWebDevelopmentProject.Models;
using BasicWebDevelopmentProject.Models.Dto;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BasicWebDevelopmentProject.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SubmitData(CheckRequestDataDto Request)
        {
            // Here you can validate the submitted data with function on ValidationHelper
            bool verified_card = ValidationHelper.ValidateCreditCard(Request.CreditCardNumber);
            bool verified_id = ValidationHelper.ValidateCitizenId(Request.CitizenId);
            VerifiedModel cm = new VerifiedModel();
            cm.card = verified_card;
            cm.id = verified_id;

            // Console.WriteLine("Card: " + verified_card.ToString() + ", ID: " + verified_id.ToString());

            return View(cm);
        }
    }
}
