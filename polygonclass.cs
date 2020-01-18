using System;
using System.Collections.Generic;
namespace graphicsengine
{
    class polygon{
        static List<polygon> allthePolygon;
        public List<line> lines;
        public point [] points;
        public polygon(point [] pointarray){
            points = pointarray;
            for(int i = 0; i < (points.Length-1);i++){
                lines.Add(new line(points[i],points[i+1]));
            }
            allthePolygon.Add(this);
        }
        public polygon(int radius, int n , int offsetx , int offsety){///regular polygon //still requires offset implementation
            points = new point[n];
            int index=0;
            for(double i=0.0F;i<(2*Math.PI);i+=((2*Math.PI)/(Convert.ToDouble(n)))){
                float x = (float)( radius * Math.Cos(i));
                float y = (float)( radius * Math.Sin(i));
                index++;
                points[index]=new point(x + offsetx ,y + offsety);
            }
            for(int i = 0; i < (points.Length-1);i++){
                lines.Add(new line(points[i],points[i+1]));
            }
            allthePolygon.Add(this);
        }
    }
}