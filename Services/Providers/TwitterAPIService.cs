using Twitter_API.Services.Interfaces;
using TwitterSharp;
using TwitterSharp.Client;

namespace Twitter_API.Services.Providers
{
    public class TwitterAPIService : ITwitterAPIService
    {
        private readonly IConfiguration _configuration;
        public TwitterAPIService(IConfiguration configuration )
        {
            _configuration = configuration;
            
        }

        public async Task<string> GetTweetFromID(string tweetID)
        {
            var client = new TwitterClient(_configuration.GetSection("Twitter-API-V2")["BearerToken"]);
            var answer = await client.GetTweetAsync(tweetID);
            
            Console.WriteLine(answer.Text);
            return answer.Text;
        }

        public async Task<string> GetUserFromUsername(string username)
        {
            var client = new TwitterClient(_configuration.GetSection("Twitter-API-V2")["BearerToken"]);
            var answer = await client.GetUserAsync(username);

            Console.WriteLine(answer.Id); // 1022468464513089536
            return answer.Id;
        }





        
    }

}


