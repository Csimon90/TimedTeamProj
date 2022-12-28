using Microsoft.AspNetCore.Mvc;
using TimedTeam.Models.Comment;
using TimedTeam.Services.Comment;

namespace TimedTeam.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CommentController : ControllerBase
    {
        private readonly ICommentService _commentService;
        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }
        [HttpPost]
        public async Task<IActionResult> CreateComment([FromBody] CommentCreate comment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (await _commentService.CreateCommentAsync(comment))
            {
                return Ok("Comment created successfully!");
            }

            return BadRequest("Unable to create new comment.");
        }

        [HttpGet, Route("{postId}")]
        public async Task<IActionResult> GetCommentById(int postId)
        {
            var detail = await _commentService.GetCommentByIDAsync(postId);

            return detail is not null
            ? Ok(detail)
            : NotFound();
        }
    }
}