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
            first.initialze(60,30);
            frame.fullflip();
            frame.Clear();
            frame.fullflip();
            Console.ReadLine();
            frame.fill('#');
            frame.fullflip();
            Console.ReadLine();
            frame.Clear();
            frame.drawcircle(10,10,3);
            frame.fullflip();
            Console.ReadLine();
            frame.Clear();
            polygon second  =  new polygon(3,3,5,5);
            frame.renderpolygons();
            frame.fullflip();
            Console.ReadLine();
        }
    }
}   
