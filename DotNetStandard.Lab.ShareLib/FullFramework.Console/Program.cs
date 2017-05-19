using DotNetStandard.Lab.ShareLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullFramework.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var world = new World();
            System.Console.WriteLine(world.GetGreeting());
            System.Console.ReadKey();
        }
    }
}
