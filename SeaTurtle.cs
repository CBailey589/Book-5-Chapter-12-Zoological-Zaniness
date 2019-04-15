using System.Collections.Generic;
using System;

namespace myApp
{
    class SeaTurtle : IWalking, ISwimming
    {
        public int MaximumDepth { get; } = 100;

        public void run()
        {
            Console.WriteLine("SeaTurtle is now running");
        }

        public void walk()
        {
            Console.WriteLine("SeaTurtle is now walking");
        }

        public void swim()
        {
            Console.WriteLine("SeaTurtle is now swimming");
        }
    }
}