namespace s2q
{
    public interface ISearchEngine
    {
        public string GetSearchUrl();
        public string GetSearchParameters(string query);
        public string GetSearchUrlWithParameters(string query);
    }
}