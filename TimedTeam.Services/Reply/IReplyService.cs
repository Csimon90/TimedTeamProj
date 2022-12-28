using TimedTeam.Models.Reply;

namespace TimedTeam.Services.Reply
{
    public interface IReplyService
    {
        Task<bool> CreateReplyAsync(ReplyCreate reply);
        Task<ReplyDetail> GetReplyByIDAsync(int commentId);
    }
}