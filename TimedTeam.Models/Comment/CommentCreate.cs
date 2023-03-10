using System.ComponentModel.DataAnnotations;

namespace TimedTeam.Models.Comment
{
    public class CommentCreate
    {
        [Required]
        [MaxLength(250, ErrorMessage = "{0} must contain no more than {1} characters.")]
        public string? Text { get; set; }
        [Required]
        public int PostId { get; set; }
    }
}