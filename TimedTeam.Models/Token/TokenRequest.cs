using System.ComponentModel.DataAnnotations;

namespace TimedTeam.Models.Token
{
    public class TokenRequest
    {
        [Required]
        public string? Username { get; set; }
        [Required]
        public string? Password { get; set; }
    }
}