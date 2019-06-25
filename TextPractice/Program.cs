using System;
using System.Collections.Generic;
using System.Linq;
using TextPractice.Commands;
using TextPractice.Interfaces;

namespace TextPractice
{
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        static Type ExecuteType = typeof(IStringExecute);
        static List<Type> Commands = typeof(Program).Assembly.GetTypes()
            .Where(z => 
                ExecuteType.IsAssignableFrom(z)
                && !z.IsInterface && !z.IsInterface
            ).ToList();

        static void Main(string[] args)
        {
            if (args == null || args.Length < 2 || !int.TryParse(args[0], out var command) || string.IsNullOrWhiteSpace(args[1]))
            {
                Help();
                return;
            }

            var executor = (IStringExecute)Activator.CreateInstance(Commands[command]);
            Console.Write(executor.Execute(args[1]));
        }

        static void Help()
        {
            Console.WriteLine("Enter Command # followed by string");
            for(var i = 0; i < Commands.Count(); i++)
            {
                Console.WriteLine($"{i}: {new SplitAtCamelCase().Execute(Commands[i].Name)}");
            }
        }
    }
}
