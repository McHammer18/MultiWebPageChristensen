using System.ComponentModel.DataAnnotations;
using System.Security;

namespace MultiWebPageChristensen.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        [Required(ErrorMessage = "Please enter the Name of the Movie")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the year the Movie came out.")]
        [Range(1889, 2050, ErrorMessage = "Year must be between 1889 and 2024")]
        public string Number { get; set; }

        [Required(ErrorMessage = "Please enter a Rating")]
        [Range(1, 5, ErrorMessage = " Ratings are on the 5 star scale")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter the Genre")]
        public string Note { get; set; }

        public string Slug =>
            Name?.Replace(' ', '-').ToLower() + '-' + Number;

    }
}
