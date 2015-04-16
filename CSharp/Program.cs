using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {            
           
            PrintHello("Michael");
        }
        static void PrintHello(string name)
        {
            Console.WriteLine("Hello, {0}", name);
        }

    }
}
