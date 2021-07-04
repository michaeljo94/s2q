using System.Runtime.InteropServices;
using s2q.Controller;
using s2q.Model.Actions;
using s2q.UI;

namespace s2q
{
    internal class Program
    {
        private Program(string[] args)
        {
            MainController mainController = new MainController(args);
        }

        private static void Main(string[] args)
        {
            var p = new Program(args);
        }
    }
}