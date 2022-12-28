namespace TimedTeam.Models.Reply
{
    public class ReplyDetail
    {
        public int Id { get; set; }
        public string? Text { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }
        // Don't need ModifiedUtc since we're not updating
    }
}