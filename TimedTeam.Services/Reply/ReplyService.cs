using Microsoft.EntityFrameworkCore;
using TimedTeam.Data;
using TimedTeam.Data.Entities;
using TimedTeam.Models.Reply;

namespace TimedTeam.Services.Reply
{
    public class ReplyService : IReplyService
    {
        private readonly int _commentId;
        private readonly ApplicationDbContext _context;
        public ReplyService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<bool> CreateReplyAsync(ReplyCreate reply)
        {
            var replyEntity = new ReplyEntity
            {
                Text = reply.Text,
                CreatedUtc = DateTimeOffset.Now
            };

            _context.Replies.Add(replyEntity);

            var numberOfChanges = await _context.SaveChangesAsync();

            return numberOfChanges == 1;
        }

        public async Task<ReplyDetail?> GetReplyByIDAsync(int commentID)
        {
            var replyEntity = await _dbContext.Replies
            .FirstOrDefaultAsync(e => 
            e.Id == commentId);

            return replyEntity is null ? null : new ReplyDetail
            {
                Id = replyEntity.Id,
                Text = replyEntity.Text,
                CreatedUtc = replyEntity.CreatedUtc,
            };
        }
    }
}