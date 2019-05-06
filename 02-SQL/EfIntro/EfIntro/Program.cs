using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using System;
using System.Collections.ObjectModel;

namespace EfIntro
{
    class Program
    {
        public static readonly LoggerFactory MyLoggerFactory
    = new LoggerFactory(new[] { new ConsoleLoggerProvider((_, __) => true, true) });
        static void Main(string[] args)
        {

            

        }
    }
}
