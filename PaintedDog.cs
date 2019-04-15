using System.Collections.Generic;
using System;

namespace myApp
{
    class PaintedDog : IWalking
    {
        public void run()
        {
            Console.WriteLine("Painted Dog is now running");
        }

        public void walk()
        {
            Console.WriteLine("Painted Dog is now walking");
        }
    }
}