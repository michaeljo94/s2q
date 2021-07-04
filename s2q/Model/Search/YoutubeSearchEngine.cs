using System.Transactions;

namespace s2q
{
    public class YoutubeSearchEngine: SearchEngineImpl
    {


        public YoutubeSearchEngine() : base("https://www.youtube.com/results?search_query=")
        {
            
        }
    }
}