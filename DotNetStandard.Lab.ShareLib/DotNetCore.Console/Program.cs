using DotNetStandard.Lab.ShareLib;
using System;

namespace DotNetCore.Console
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