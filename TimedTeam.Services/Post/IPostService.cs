using TimedTeam.Models.Post;

namespace TimedTeam.Services.Post
{
    public interface IPostService 
    {
        Task<bool> CreatePostAsync(PostCreate post);
        Task<IEnumerable<PostListItem>> GetAllPostsAsync();
        // Task<PostDetail> GetPostByIDAsync(int postId);
    }
}