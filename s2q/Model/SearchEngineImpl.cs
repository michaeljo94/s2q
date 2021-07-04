using System.Text;

namespace s2q
{
    public abstract class SearchEngineImpl : ISearchEngine

    {
        protected SearchEngineImpl(string searchUrl)
        {
            this._searchUrl = searchUrl;
        }

        private readonly string _searchUrl;

        public string GetSearchUrl()
        {
            return new(_searchUrl);
        }


        public string GetSearchParameters(string query)
        {
            return Parser.Encode(query);
        }

        public string GetSearchUrlWithParameters(string query)
        {
            var urlWithParam = new StringBuilder(GetSearchUrl());
            urlWithParam.Append(GetSearchParameters(query));
            return urlWithParam.ToString();
        }
    }
}