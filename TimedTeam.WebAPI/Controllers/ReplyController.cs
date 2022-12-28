using Microsoft.AspNetCore.Mvc;
using TimedTeam.Models.Post;
using TimedTeam.Models.Reply;
using TimedTeam.Services.Post;
using TimedTeam.Services.Reply;

namespace Chitter.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReplyController : ControllerBase
    {
        private readonly IReplyService _replyService;
        public ReplyController(IReplyService replyService)
        {
            _replyService = replyService;
        }
        [HttpPost]
        public async Task<IActionResult> CreateReply([FromBody] ReplyCreate reply)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (await _replyService.CreateReplyAsync(reply))
            {
                return Ok("Reply created successfully!");
            }

            return BadRequest("Unable to create new reply.");
        }

        [HttpGet, Route("{commentId}")]
        public async Task<IActionResult> GetReplyById(int commentId)
        {
            var detail = await _replyService.GetReplyByIDAsync(commentId);

            return detail is not null
            ? Ok(detail)
            : NotFound();
        }
    }
}