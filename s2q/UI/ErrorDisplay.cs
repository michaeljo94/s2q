using System;

namespace s2q.UI
{
    public class ErrorDisplay : IDisplay
    {
        private readonly Exception _e;
        private readonly string _msg;
        private readonly bool _verbose;

        public ErrorDisplay(Exception e, string msg) : this(e, msg, false)
        {
            _e = e;
            _msg = msg;
        }

        public ErrorDisplay(Exception e, string msg, bool verbose)
        {
            _verbose = verbose;
        }

        public void Draw()
        {
            if (this._verbose)
            {
                Console.Error.WriteLine(_e.ToString());
            }

            Console.WriteLine(_msg);
        }
    }
}