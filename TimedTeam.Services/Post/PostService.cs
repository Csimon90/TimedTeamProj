using TimedTeam.Data;
using TimedTeam.Data.Entities;
using TimedTeam.Models.Post;
using Microsoft.EntityFrameworkCore;

namespace TimedTeam.Services.Post
{
    public class PostService : IPostService
    {
        private readonly int _userId;
        private readonly ApplicationDbContext _context;
        public PostService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<bool> CreatePostAsync(PostCreate post)
        {
            var postEntity = new PostEntity
            {
                Title = post.Title,
                Content = post.Content,
                CreatedUtc = DateTimeOffset.Now,
                AuthorId = _userId
            };

            _context.Posts.Add(postEntity);

            var numberOfChanges = await _context.SaveChangesAsync();

            return numberOfChanges == 1;
        }

        public async Task<IEnumerable<PostListItem>> GetAllPostsAsync()
        {
            var posts = await _context.Posts
            .Select(entity => new PostListItem
            {
                Id = entity.Id,
                Title = entity.Title,
                Content = entity.Content,
                CreatedUtc = entity.CreatedUtc  
            })
            .ToListAsync();

            return posts;
        }
    }
}