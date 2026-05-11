using BasicWebDevelopmentProject.Helpers;
using BasicWebDevelopmentProject.Models.Dto;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Runtime.CompilerServices;

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
            bool value = ValidationHelper.ValidateCreditCard(Request.CreditCardNumber);
            if (value == null || value == false)
            {
                return BadRequest();
            }

            // throw new NotImplementedException();

            return Ok();
        }
    }
}
