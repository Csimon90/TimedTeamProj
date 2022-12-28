using TimedTeam.Data;
using TimedTeam.Data.Entities;
using Microsoft.EntityFrameworkCore;
using TimedTeam.Models.Comment;

namespace TimedTeam.Services.Comment
{
    public class CommentService : ICommentService
    {
        private readonly int _postId;
        private readonly ApplicationDbContext _context;
        public CommentService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<bool> CreateCommentAsync(CommentCreate comment)
        {
            var commentEntity = new CommentEntity
            {
                Text = comment.Text,
                CreatedUtc = DateTimeOffset.Now
            };

            _context.Comments.Add(commentEntity);

            var numberOfChanges = await _context.SaveChangesAsync();

            return numberOfChanges == 1;
        }
        public async Task<CommentDetail?> GetCommentByIDAsync(int postID)
        {
            var commentEntity = await _dbContext.Comments
            .FirstOrDefaultAsync(e => 
            e.Id == postID);

            return commentEntity is null ? null : new CommentDetail
            {
                Id = commentEntity.Id,
                Text = commentEntity.Text,
                CreatedUtc = commentEntity.CreatedUtc,
            };
        }
    }
}