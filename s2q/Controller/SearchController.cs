using System.Text;

namespace s2q
{
    public class SearchController
    {
        private readonly PlayerCtlController _playerCtlController;
        private readonly SearchEngineImpl _searchEngine;

        public SearchController(PlayerCtlController playerCtlController, SearchEngineImpl searchEngine)

        {
            _playerCtlController = playerCtlController;
            _searchEngine = searchEngine;
        }

        public string SearchUrl()
        {
            var query = new StringBuilder();
            query.Append(_playerCtlController.GetArtist());
            query.Append('-');
            query.Append(_playerCtlController.GetAlbum());
            query.Append('-');
            query.Append(_playerCtlController.GetTitle());

            return this._searchEngine.GetSearchUrlWithParameters(query.ToString());
        }
    }
}