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
        public polygon(int radius, int n , double offsetx , double offsety, bool numbered = false){///regular polygon 
        
            points.Clear();
            for(int i=0;i<(n);i++){
                double x = (double)( radius * Math.Cos((2*i*Math.PI)/n));
                double y = (double)( radius * Math.Sin((2*i*Math.PI)/n));
                points.Add(new point(x + offsetx ,y + offsety));
            }
            line temp;
            for(int i = 0; i < (points.Count-1);i++){
                temp = (new line(points[i],points[i+1]));
                if(numbered){
                    temp.spcecialchar=Convert.ToChar(Convert.ToString(i));  
                }
                lines.Add(temp);
            }
            temp = (new line(points[0],points[points.Count-1]));
                if(numbered){
                    temp.spcecialchar=Convert.ToChar(Convert.ToString(points.Count-1));  
                }
                lines.Add(temp);
            allthePolygon.Add(this);
        }
    }
}