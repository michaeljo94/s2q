using System.Transactions;

namespace s2q
{
    public class GoogleSearchEngine: SearchEngineImpl
    {


        public GoogleSearchEngine() : base("https://www.google.com/search?q=")
        {
            
        }
    }
}