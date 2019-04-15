using System;
using System.Collections.Generic;

namespace myApp
{
    public interface IWalking
    {
        void run();
        void walk();
    }

    public interface ISwimming
    {
        int MaximumDepth { get; }
        void swim();
    }
    class Program
    {
        static void Main(string[] args)
        {

            SeaTurtle ST1 = new SeaTurtle();
            PaintedDog PD1 = new PaintedDog();
            ST1.swim();
            PD1.walk();
            PD1.run();

        }
    }
}

