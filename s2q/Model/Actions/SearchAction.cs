using s2q.Exceptions;

namespace s2q.Model.Actions
{
    public class SearchAction : IAction
    {
        private SearchController _searchController;
        private readonly SearchEngineImpl _searchEngine;
        private readonly PlayerCtlController _playerCtlControl;
        private readonly BrowserController _browserController;


        public SearchAction(string searchEngine)
        {
            _playerCtlControl = new PlayerCtlController();
            _searchEngine = InitializeSearchEngine(searchEngine);
            _searchController = new SearchController(this._playerCtlControl, _searchEngine);
            _browserController = new BrowserController(_searchController.SearchUrl());
        }

        private SearchEngineImpl InitializeSearchEngine(string searchEngine)
        {
            try
            {
                return SearchEngineFactory.GetSearchEngine(searchEngine);
            }
            catch (SearchEngineNotFoundException)
            {
                return SearchEngineFactory.GetSearchEngine("youtube");
            }
        }

        public void Run()
        {
            _browserController.Open();
        }
    }
}