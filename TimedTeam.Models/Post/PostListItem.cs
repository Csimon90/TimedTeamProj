using TimedTeam.Models.Comment;

namespace TimedTeam.Models.Post
{
    public class PostListItem
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }
        public List<CommentListItem> Comments {get;set;}
    }
}