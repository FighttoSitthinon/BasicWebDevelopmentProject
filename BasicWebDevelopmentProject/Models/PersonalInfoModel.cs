using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace BasicWebDevelopmentProject.Models
{
    public class PersonalInfoModel
    {
        public string? CitizenId { get; set; }
        public string? CreditCardNumber { get; set; }
    }
}
