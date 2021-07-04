using System;
using System.Globalization;
using System.Text;

namespace s2q.UI
{
    public class ListDisplay : IDisplay
    {
        private string[] values;
        private string header;

        public ListDisplay(string header, string[] values)
        {
            this.header = header;
            this.values = values;
        }

        public void Draw()
        {
            var sb = new StringBuilder(this.header);
            sb.Append('\n');
            foreach (var value in this.values)
            {
                sb.Append("*\t");
                sb.Append(value);
                sb.Append('\n');
            }

            Console.WriteLine(sb.ToString());
        }
    }
}