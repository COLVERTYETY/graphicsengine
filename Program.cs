using System;
namespace graphicsengine
{
    class Program
    {
        static void demo(){
            
            frame.initialze(100,30);
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
            new polygon(5,3,10,10,true);  // Noncompliant
            new polygon(5,4,10,20,true);  // Noncompliant
            new polygon(5,5,20,20, true);  // Noncompliant
            new polygon(5,6,20,10, true);  // Noncompliant
            new polygon(10,5,40,20, true);  // Noncompliant
            frame.renderpolygons();
            time = analyse.Measure(frame.flip);
            frame.sidelog("elapsed time: "+Convert.ToString(time).PadRight(4));
            Console.ReadLine();
        }
        static void dynamic(){
            frame.initialze(300,80);
            frame.fullflip();
            polygon polarpol = new polygon(50,8,100,50,false,true);
            frame.renderpolygons();
            frame.flip();
            frame.drawcircle(100,100,50,'0');
            polygon triangle = new polygon(30,4,110,50);
            frame.renderpolygons();
            frame.flip();
            while(true){
                foreach(point i in triangle.points){
                    i.X++;
                    if(i.X>300){
                        i.X=0;
                    }
                }
                foreach(point i in polarpol.points){
                    i.angle+=0.1;
                }
                double cleartime = analyse.Measure(frame.Clear);
                double rendertime = analyse.Measure(frame.renderpolygons);
                double fliptime = analyse.Measure(frame.flip);
                frame.sidelog("cleartime:  "+Convert.ToString(cleartime).PadRight(3)+"ms",0,0);
                frame.sidelog("rendertime: "+Convert.ToString(rendertime).PadRight(3)+"ms",0,1);
                frame.sidelog("fliptime:   "+Convert.ToString(fliptime).PadRight(3)+"ms",0,2);
                frame.sidelog("total:      "+Convert.ToString(cleartime+rendertime+fliptime).PadRight(3)+"ms",0,3);
                frame.sidelog("framerate:  "+Convert.ToString(1000/(cleartime+rendertime+fliptime)).PadRight(3)+"fps   ",0,4);
            }
        }
        static void Main(string[] args)
        {
            dynamic();
        }
    }
}   
