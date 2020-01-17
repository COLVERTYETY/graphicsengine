using System;
namespace graphicsengine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            frame first = new frame();
            first.initialze(20,10,1);
            first.fullflip();
            Console.ReadLine();
        }
    }
}   
