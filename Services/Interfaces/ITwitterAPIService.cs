namespace Twitter_API.Services.Interfaces
{
    public interface ITwitterAPIService
    {
        public Task<string> GetTweetFromID(string tweetID);
        public Task<string> GetUserFromUsername(string username);
    }
}