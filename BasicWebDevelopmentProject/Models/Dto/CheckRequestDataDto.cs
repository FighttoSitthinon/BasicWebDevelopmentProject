using System.ComponentModel.DataAnnotations;

namespace BasicWebDevelopmentProject.Models.Dto
{
    public class CheckRequestDataDto
    {
        [Required]
        public String CitizenId { get; set; }
        [Required]
        public String CreditCardNumber { get; set; }
    }
}
