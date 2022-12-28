namespace TimedTeam.Models.Post
{
    public class PostDetail
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }

        // Don't need MotifiedUtc because we're not updating
    }
}