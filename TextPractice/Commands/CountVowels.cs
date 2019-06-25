using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TextPractice.Common;
using TextPractice.Interfaces;

namespace TextPractice.Commands
{
    public class CountVowels : IStringExecute
    {
        public string Execute(string x)
        {
            return x.ToLower().Count(z => Consts.VOWELS.Contains(z)).ToString();
        }
    }
}
