namespace TimedTeam.Models.Token
{
    public class TokenResponse
    {
        public string? Token { get; set; }
        public DateTime IssuedAt { get; set; }
        public DateTime Expires { get; set; }
    }
}