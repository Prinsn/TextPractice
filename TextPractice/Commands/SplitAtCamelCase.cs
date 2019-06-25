using System;
using System.Collections.Generic;
using System.Text;
using TextPractice.Interfaces;

namespace TextPractice.Commands
{
    public class SplitAtCamelCase : IStringExecute
    {
        public string Execute(string x)
        {
            var sb = new StringBuilder();
            var first = true;
            var outputs = new List<string>();
            foreach (var c in x)
            {
                
                if (first)
                {
                    sb.Append(c);
                    first = false;
                    continue;
                }
                else 
                {
                    var sc = "" + c;
                    if(("" + c).ToUpper()[0] == c)
                    {
                        outputs.Add(sb.ToString());
                        sb.Clear();
                    }
                }

                sb.Append(c);
            }

            if(sb.Length > 0)
            {
                outputs.Add(sb.ToString());
            }

            return string.Join(" ", outputs);
        }
    }
}
