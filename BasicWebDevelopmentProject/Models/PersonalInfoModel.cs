using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace BasicWebDevelopmentProject.Models
{
    public class PersonalInfoModel
    {
        [StringLength(13, MinimumLength = 13)]
        [Required]
        public string? CitizenId { get; set; }
        [StringLength(16, MinimumLength = 16)]
        [Required]
        public string? CreditCardNumber { get; set; }
    }
}
