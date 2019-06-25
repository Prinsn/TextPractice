using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TextPractice.Interfaces;

namespace TextPractice.Commands
{
    public class CountWords : IStringExecute
    {
        public string Execute(string x)
        {
            return x.Split(" ").Count().ToString();
        }
    }
}
