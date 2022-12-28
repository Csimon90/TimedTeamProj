using TimedTeam.Models.Comment;

namespace TimedTeam.Services.Comment
{
    public interface ICommentService
    {
        Task<bool> CreateCommentAsync(CommentCreate comment);
        Task<CommentDetail> GetCommentByIDAsync(int postId);
    }
}