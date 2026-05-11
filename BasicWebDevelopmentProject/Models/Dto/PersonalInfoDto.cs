using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace BasicWebDevelopmentProject.Models.Dto
{
    public class PersonalInfoDto
    {
        [Display(Name = "Thai Citizen ID")]
        public required string CitizenId { get; set; }

        [Display(Name = "Credit Card Number")]
        public required string CreditCardNumber { get; set; }

    }
}
