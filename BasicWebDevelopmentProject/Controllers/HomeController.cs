using BasicWebDevelopmentProject.Helpers;
using BasicWebDevelopmentProject.Models.Dto;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net;
using System.Reflection.Metadata.Ecma335;

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
        public IActionResult Index(PersonalInfoDto Request)
        {
            // Here you can validate the submitted data with function on ValidationHelper
            
            if(!ValidationHelper.ValidateCitizenId(Request.CitizenId)) return BadRequest("invalid CitizenId");
            if(!ValidationHelper.ValidateCreditCard(Request.CreditCardNumber)) return BadRequest("invalid CreditCardNumber");
            
            return Ok();
            // throw new NotImplementedException();
        }
    }
}
