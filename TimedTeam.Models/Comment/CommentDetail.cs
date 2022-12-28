namespace TimedTeam.Models.Comment
{
    public class CommentDetail
    {
        public int Id { get; set; }
        public string? Text { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }
        // Don't need ModifiedUtc since we're not updating
    }
}