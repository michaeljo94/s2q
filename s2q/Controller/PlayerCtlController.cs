using System;
using System.Diagnostics;
using System.Text;

namespace s2q
{
    public class PlayerCtlController
    {
        private readonly string _album;
        private readonly string _artist;
        private readonly string _title;

        public PlayerCtlController()
        {
            _album = ReadPlayerCtl("album");
            _artist = ReadPlayerCtl("artist");
            _title = ReadPlayerCtl("title");
        }


        private string ReadPlayerCtl(string param)
        {
            var stdOutStringBuild = new StringBuilder();

            var startInfo = new ProcessStartInfo
            {
                FileName = "/usr/bin/playerctl",
                Arguments = "-p spotify metadata xesam:" + param,
                CreateNoWindow = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };

            var proc = new Process
            {
                StartInfo = startInfo
            };

            proc.OutputDataReceived += (sender, data) => { stdOutStringBuild.Append(data.Data); };
            try
            {
                proc.Start();
                proc.BeginOutputReadLine();
                proc.BeginErrorReadLine();
                proc.WaitForExit();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }


            return stdOutStringBuild.ToString();
        }

        public string GetAlbum()
        {
            return _album;
        }

        public string GetArtist()
        {
            return _artist;
        }

        public string GetTitle()
        {
            return _title;
        }
    }
}