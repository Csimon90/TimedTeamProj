using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TimedTeam.Data.Entities
{
    public class CommentEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Text { get; set; }
        public int AuthorId { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }
        public virtual ICollection<ReplyEntity> Replies { get; } = new List<ReplyEntity>();
        [ForeignKey(nameof(Id))]
        public virtual ICollection<PostEntity> Posts { get; } = new List<PostEntity>();
    }
}