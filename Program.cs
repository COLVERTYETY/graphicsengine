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
            polygon second  =  new polygon(2,3,5,5);
            frame.renderpolygons();
            first.flip();
        }
    }
}   
