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
            if(Request==null)return BadRequest();
            if(string.IsNullOrEmpty(Request.CreditCardNumber)||string.IsNullOrEmpty(Request.CitizenId))return BadRequest();
            bool credit = ValidationHelper.ValidateCreditCard(Request.CreditCardNumber);
            bool citizen = ValidationHelper.ValidateCitizenId(Request.CitizenId);
            if (!credit || !citizen)
            {
                return BadRequest();
            }

            // throw new NotImplementedException();

            return Ok();
        }
    }
}
