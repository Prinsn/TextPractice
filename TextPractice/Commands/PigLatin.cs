using System;
using System.Collections.Generic;
using System.Text;
using TextPractice.Common;
using TextPractice.Interfaces;

namespace TextPractice.Commands
{
    /// <summary>
    /// Rudementary pig latin, lexicographic analysis is beyond the scope of a string
    /// </summary>
    public class PigLatin : IStringExecute
    {

        public string Execute(string x)
        {
            var splitAt = 0;
            var lower = x.ToLower();
            while (!Consts.VOWELS.Contains(lower[splitAt]))
            {
                splitAt++;
            }

            var suffix = x.Substring(0, splitAt);
            var core = x.Substring(splitAt, x.Length - splitAt);
            return $"{core}{suffix}ay";
        }
    }
}
