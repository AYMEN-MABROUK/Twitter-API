using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Twitter_API.Services.Interfaces;

namespace Twitter_API.Controllers
{
    //[Authorize]
    [Route("api/[controller]/[action]/")]
    [ApiController]
    public class TwitterAPIController : ControllerBase
    {
        private readonly ITwitterAPIService _twitterAPIService;

        public TwitterAPIController(
            ITwitterAPIService twitterAPIService)
        {
            _twitterAPIService = twitterAPIService;
        }

        [HttpGet("{tweetID}")]
        public async Task<ActionResult> GetTweetFromID(string tweetID)
        {
            HttpContext.Items.Add("action","twitterAPI.GetTweetFromID");
            var tweetText = await _twitterAPIService.GetTweetFromID(tweetID);
            return Ok(tweetText);
        }

        [HttpGet("{username}")]
        public async Task<ActionResult> GetUserFromUsername(string username)
        {
            HttpContext.Items.Add("action","twitterAPI.GetUserFromUsername");
            var userID = await _twitterAPIService.GetUserFromUsername(username);
            return Ok(userID);
        }

        
    }
}
