using System.ComponentModel.DataAnnotations;
using System.Security;

namespace MultiWebPageChristensen.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        [Required(ErrorMessage = "Please enter the Name of the Contact")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the Contacts number")]
        public string Number { get; set; }

        [Required(ErrorMessage = "Please enter an Address")]
        public string Address { get; set; }
        public string Note { get; set; }

        public string Slug =>
            Name?.Replace(' ', '-').ToLower() + '-' + Number;

    }
}
