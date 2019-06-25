using System;
using System.Collections.Generic;
using System.Text;
using TextPractice.Interfaces;

namespace TextPractice.Commands
{
    public class CheckIfPalindrome : IStringExecute
    {
        public string Execute(string x)
        {
            var middle = x.Length / 2;
            var oddOffset = middle % 2 == 0 ? 0 : 1;
            var a = x.Substring(0, middle);

            //Middle character in odd length string doesn't matter
            middle += oddOffset;
            var b = x.Substring(middle, x.Length - middle);
            b = new Reverse().Execute(b);
            return (a == b).ToString();
        }
    }
}
