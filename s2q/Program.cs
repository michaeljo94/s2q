using System;
using System.Text;

namespace s2q
{
    class Program
    {
        static void Main(string[] args)
        {
            var pcc = new PlayerCtlController();
            var sb = new StringBuilder();
            sb.Append(pcc.GetArtist());
            sb.Append('-');
            sb.Append(pcc.GetAlbum());
            sb.Append('-');
            sb.Append(pcc.GetTitle());
            Console.WriteLine(sb.ToString());
        }
    }
}