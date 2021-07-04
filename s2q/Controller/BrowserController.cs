using System;
using System.Diagnostics;

namespace s2q
{
    public class BrowserController
    {
        private readonly string _url;

        public BrowserController(string url)
        {
            _url = url;
        }

        public void Open()
        {
            var startInfo = new ProcessStartInfo
            {
                FileName = "/usr/bin/brave-browser",
                Arguments = _url,
                CreateNoWindow = false
            };
            var process = new Process
            {
                StartInfo = startInfo
            };

            try
            {
                process.Start();
                process.WaitForExit();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}