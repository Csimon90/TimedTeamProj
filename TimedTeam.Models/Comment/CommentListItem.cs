using TimedTeam.Models.Post;
using TimedTeam.Models.Reply;

namespace TimedTeam.Models.Comment
{
    public class CommentListItem
    {
        public string? Text { get; set; }
        public int AuthorID { get; set; }
        public virtual PostDetail Posts {get; set;}
        public List<ReplyListItem> Replies {get;set;}
        // public List<PostListItem> Posts {get;set;}
    }
}