using System.ComponentModel.DataAnnotations;

namespace NetworkingAPI.Dtos
{
    public class UserForLoginDto
    {
        [Required]
        public string Username { get; set; }
        // these are verified in the controller parameter
        [Required]
        [StringLength(12, MinimumLength = 4, ErrorMessage = "You must specify password between 4 and 12 characters")]
        public string Password { get; set; }
    }
}