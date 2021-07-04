using s2q.Exceptions;

namespace s2q
{
    public static class SearchEngineFactory
    {
        public static SearchEngineImpl GetSearchEngine(string searchEngineName)
        {
            switch (searchEngineName)
            {
                case "youtube":
                    return new YoutubeSearchEngine();
                case "google":
                    return new GoogleSearchEngine();
                default:
                    throw new SearchEngineNotFoundException();
            }
        }
    }
}