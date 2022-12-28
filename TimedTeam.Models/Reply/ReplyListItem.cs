using TimedTeam.Models.Comment;

namespace TimedTeam.Models.Reply
{
    public class ReplyListItem
    {
        public string? Text { get; set; }
        public int AuthorID { get; set; }
        public List<CommentListItem> Comments { get; set; }
    }
}