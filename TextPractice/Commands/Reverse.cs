using System;
using System.Collections.Generic;
using System.Text;
using TextPractice.Interfaces;

namespace TextPractice.Commands
{
    public class Reverse : IStringExecute
    {
        public string Execute(string s)
        {
            var sb = new StringBuilder();
            for(var i = s.Length -1; i >= 0; i--)
            {
                sb.Append(s[i]);
            }

            return sb.ToString();
        }
    }
}
