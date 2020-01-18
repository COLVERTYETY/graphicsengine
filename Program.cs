using System;
namespace graphicsengine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
            frame first = new frame();
            first.initialze(40,20,1);
            first.fullflip();
            first.Clear();
            first.fullflip();
            Console.ReadLine();
            first.fill('#');
            first.fullflip();
            Console.ReadLine();
            first.Clear();
            polygon second  =  new polygon(10,10,5,5);
            frame.renderpolygons();
            first.fullflip();
            Console.ReadLine();
        }
    }
}   
