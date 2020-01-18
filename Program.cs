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
            first.initialze(60,30,1);
            first.fullflip();
            first.Clear();
            first.fullflip();
            Console.ReadLine();
            first.fill('#');
            first.fullflip();
            Console.ReadLine();
            first.Clear();
            first.drawcircle(10,10,5);
            first.fullflip();
            Console.ReadLine();
            first.Clear();
            polygon second  =  new polygon(3,3,5,5);
            frame.renderpolygons();
            first.fullflip();
            Console.ReadLine();
        }
    }
}   
