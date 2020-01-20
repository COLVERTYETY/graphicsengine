using System;
namespace graphicsengine
{
    class Program
    {
        static void Main(string[] args)
        {
            frame first = new frame();
            first.initialze(100,30);
            float time = analyse.Measure(frame.fullflip);
            frame.sidelog("elapsed time: "+Convert.ToString(time).PadRight(4));
            frame.fill('#');
            time = analyse.Measure(frame.flip);
            frame.sidelog("elapsed time: "+Convert.ToString(time).PadRight(4));
            Console.ReadLine();
            frame.Clear();
            frame.drawcircle(10,10,7);
            time = analyse.Measure(frame.flip);
            frame.sidelog("elapsed time: "+Convert.ToString(time).PadRight(4));
            Console.ReadLine();
            frame.Clear();
            line firstline = new line(new point(5,5),new point(5,10),'|');
            line secondline = new line(new point(5,10),new point(10,10),'-');
            line thirdline = new line(new point(10,10),new point(10,5),'|');
            line fourthline = new line(new point(10,5),new point(5,5),'-');
            line diagonal  = new line(new point(0,0),new point(10,10),'\\');
            line seconddiagonal  = new line(new point(0,10),new point(10,0),'/');
            frame.renderline(firstline);
            frame.renderline(secondline);
            frame.renderline(thirdline);
            frame.renderline(fourthline);
            frame.renderline(diagonal);
            frame.renderline(seconddiagonal);
            time = analyse.Measure(frame.flip);
            frame.sidelog("elapsed time: "+Convert.ToString(time).PadRight(4));
            Console.ReadLine();
            frame.Clear();
            //new polygon(5,3,10,10,true);  // Noncompliant
            //new polygon(5,3,10,20,true);  // Noncompliant
            new polygon(10,10,60,20, true);  // Noncompliant
            frame.renderpolygons();
            time = analyse.Measure(frame.flip);
            frame.sidelog("elapsed time: "+Convert.ToString(time).PadRight(4));
            Console.ReadLine();
        }
    }
}   
