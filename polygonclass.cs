using System;
using System.Collections.Generic;
namespace graphicsengine
{
    class polygon{
        public static List<polygon> allthePolygon = new List<polygon>();
        public List<line> lines = new List<line>();
        public List<point> points = new List<point>();
        public polygon(point [] pointarray){
            points.Add(points[0]);
            for(int i = 0; i < (points.Count-1);i++){
                lines.Add(new line(points[i],points[i+1]));
                points.Add(points[i+1]);
            }
            allthePolygon.Add(this);
        }
        public polygon(int radius, int n , float offsetx , float offsety){///regular polygon 
        
            points.Clear();
            for(int i=0;i<(n-1);i++){
                float x = (float)( radius * Math.Cos((2*i*Math.PI)/n));
                float y = (float)( radius * Math.Sin((2*i*Math.PI)/n));
                points.Add(new point(x + offsetx ,y + offsety));
            }
            for(int i = 0; i < (points.Count-1);i++){
                lines.Add(new line(points[i],points[i+1]));
            }
            allthePolygon.Add(this);
        }
    }
}