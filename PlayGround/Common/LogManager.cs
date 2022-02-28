using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class LogManager
    {
        static LogManager()
        {
            Name = "Simpler Log";
        }

        public static void Print()
        {
            Console.WriteLine("Print");
        }

        public static string Name { get; set; }
    }
}   
