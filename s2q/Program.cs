namespace s2q
{
    internal class Program
    {
        private Program()
        {
            SearchEngineImpl yt = new YoutubeSearchEngine();
            SearchEngineImpl google = new GoogleSearchEngine();

            var pcc = new PlayerCtlController();
            var youtubeSC = new SearchController(pcc, yt);
            var googleSC = new SearchController(pcc, google);

            var youtubeBC = new BrowserController(youtubeSC.SearchUrl());
            var googleBC = new BrowserController(googleSC.SearchUrl());

            youtubeBC.Open();
            googleBC.Open();
        }

        private static void Main(string[] args)
        {
            var p = new Program();
        }
    }
}