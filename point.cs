using System;
namespace graphicsengine
{
    class point{///should this be a struct?
        private double xx;
        private double yy;
        public double X{
            get{
                double res=xx;
                if(polar == true){
                    res = xcenter+distance*Math.Cos(angle);
                }
                return res;
            }
            set{
                if(polar){
                    xcenter = value;
                } else{
                    xx=value;
                }
            }
        }
        public double Y{
            get{
                double res=yy;
                if(polar == true){
                    res = ycenter+distance*Math.Sin(angle);
                }
                return res;
            }
            set {
                if(polar){
                    ycenter = value;
                } else{
                    yy=value;
                }
            }
        }
        public bool polar;
        public double xcenter;
        public double ycenter;
        public double distance;
        public double angle;

        public point(double x,double y){
            xx=x;
            yy=y;
            polar = false;
        }
        public point(double Angle, double Distance, double Xcenter, double Ycenter){
            angle=Angle;
            distance=Distance;
            xcenter=Xcenter;
            ycenter=Ycenter;
            polar = true;
        }
    }
}