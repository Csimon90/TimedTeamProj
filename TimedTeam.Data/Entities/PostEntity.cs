using System.ComponentModel.DataAnnotations;

namespace TimedTeam.Data.Entities
{
    public class PostEntity
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        [Required]
        public string? Content { get; set; }
        public int AuthorId { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }
        // virtual list comments
        public virtual List<CommentEntity> Comments { get; } = new List<CommentEntity>();
    }
}