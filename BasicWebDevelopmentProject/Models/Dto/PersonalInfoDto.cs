using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace BasicWebDevelopmentProject.Models.Dto
{
    public class PersonalInfoDto
    {
        [Display(Name = "Thai Citizen ID")]
        public string CitizenId { get; set; }

        [Display(Name = "Credit Card Number")]
        public string CreditCardNumber { get; set; }

    }
}
