using System.Web;

namespace s2q
{
    public static class Parser
    {
        public static string Encode(string target)
        {
            return HttpUtility.UrlEncode(target);
        }
    }
}