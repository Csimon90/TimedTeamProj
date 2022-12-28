using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TimedTeam.Data.Entities
{
    public class ReplyEntity
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(Id))]
        public virtual ICollection<CommentEntity> Comments { get; } = new List<CommentEntity>();
        public string? Text { get; set; }
    }
}