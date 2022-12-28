using Microsoft.AspNetCore.Mvc;
using TimedTeam.Models.Post;
using TimedTeam.Services.Post;

namespace Chitter.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostController : ControllerBase
    {
        private readonly IPostService _postService;
        public PostController(IPostService postService)
        {
            _postService = postService;
        }
        [HttpPost]
        public async Task<IActionResult> CreatePost([FromBody] PostCreate post)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (await _postService.CreatePostAsync(post))
            {
                return Ok("Post created successfully!");
            }

            return BadRequest("Unable to create new post.");
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPosts()
        {
            var posts = await _postService.GetAllPostsAsync();
            return Ok(posts);
        }
    }
}