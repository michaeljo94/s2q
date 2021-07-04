using System;
using System.Text;
using s2q.Controller;

namespace s2q.UI
{
    public class CommandLineArgumentController
    {
        private readonly string[] _userInput;

        public CommandLineArgumentController(string[] userInput)
        {
            _userInput = userInput;
        }

        private string ParseArgs()
        {
            return this._userInput[0];
        }

        private string ActionArgs()
        {
            var sb = new StringBuilder();
            for (var i = 1; i < _userInput.Length; i++)
            {
                sb.Append(_userInput[i]);
            }

            if (_userInput.Length < 2)
            {
                sb.Append("list");
            }


            return sb.ToString();
        }

        public string GetCommandWord()
        {
            return this.ParseArgs();
        }

        public string GetCommandArgs()
        {
            return this.ActionArgs();
        }
    }
}