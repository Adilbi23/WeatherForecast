using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ConsoleLogger : ILogger 
    {
        public void Log(string text)
        {
            Console.WriteLine($"{text} в консоль");
        }
    }
}
