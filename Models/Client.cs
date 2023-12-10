using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Veezeta.Models
{
    public enum UserType { admin, doctor, patient }
    public enum Gender { Female, Male }


    public class Client
    {
      
            public string CId { get; set; }
             [Required]

            public string FullNamee { get; set; }
            [Required(ErrorMessage = "Email is required")]
            //[DataType(email)]

            public string Email { get; set; }
            [Required(ErrorMessage = "Password is required")]
            [MinLength(8)]
            public string Password { get; set; }

            [RegularExpression(@"^.*\.(jpg|gif|jpeg|png|bmp)$",
            ErrorMessage = "Please use an image with an extension of .jpg, .png, .gif, .bmp")]
            public string? Image { get; set; }

            [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
            ErrorMessage = "Entered phone format is not valid.")]
            public string Phone{ get; set; }



            public UserType type { get; set; }

            [Required]
            public Gender gender { get; set; }
            [Required]

            public DateTime dateOfBirth { get; set; }

          //  List<Booking> bookings { get; set; }
        }
}
