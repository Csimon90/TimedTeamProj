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
        public int PostId { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }
        [ForeignKey(nameof(ReplyEntity.Text))]
        public virtual ICollection<ReplyEntity> Replies { get; } = new List<ReplyEntity>();

        // public virtual PostEntity? Posts { get; set; }
    }
}