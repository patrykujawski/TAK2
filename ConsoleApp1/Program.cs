using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string [] args)
        {
            var builder = new StringBuilder();
            foreach (var s in args)
            {
                builder.Append(s + " ");
            }
            var readLine = builder.ToString();

            var lines = readLine.Split(
                new[] { Environment.NewLine },
                StringSplitOptions.None
            );

            foreach (var line in lines)
            {
                var rpn = new Rpn();
                var calculate = rpn.Calculate(line);

                Console.WriteLine(calculate);
            }

            Console.WriteLine("press any key to exit");
            Console.ReadKey();
        }
    }
}
