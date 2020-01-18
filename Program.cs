using System;
namespace graphicsengine
{
    class Program
    {
        static void Main(string[] args)
        {
            frame first = new frame();
            first.initialze(60,30);
            frame.fullflip();
            frame.fill('#');
            frame.fullflip();
            Console.ReadLine();
            frame.Clear();
            frame.drawcircle(10,10,7);
            frame.fullflip();
            Console.ReadLine();
            frame.Clear();
            polygon second  =  new polygon(7,4,10,10);  // Noncompliant
            frame.renderpolygons();
            frame.fullflip();
            Console.ReadLine();
        }
    }
}   
