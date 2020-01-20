using System;
namespace graphicsengine 
{
    class line
    {
        public point A;
        public point B;
        public char spcecialchar=' ';
        public line(point aa, point bb,char fillchar=' '){
            A = aa;
            B = bb;
            spcecialchar = fillchar;
        }
        public line( double x1, double y1, double x2, double y2, char fillchar=' '){
            A = new point(x1,y1);
            B = new point(x2,y2);
            spcecialchar = fillchar;
        }
        public point getuper(){
            point res=B;
            if(A.Y>B.Y){
                res = A;
            }
            return res;
        }
        public point getlower(){
            point res=B;
            if(A.Y<B.Y){
                res = A;
            }
            return res;
        }
        public point getrightmost(){
            point res=B;
            if(A.X>B.X){
                res = A;
            }
            return res;
        }
        public point getleftmost(){
            point res=B;
            if(A.X<B.X){
                res = A;
            }
            return res;
        }
        public double gethorizontalintersection(double y){   ///should this return a point?
            double res=-1;
            if(getrightmost().X-getleftmost().X==0){
                res = getrightmost().X;
            } else{
                double dir = (getrightmost().Y-getleftmost().Y)/(getrightmost().X-getleftmost().X);
                double cst = A.Y-(dir*A.X);
                res = (y-cst)/dir;
            }
            return res ;
        }
        public double getverticalintersection(double x){   ///should this return a point?
            double dir = (getrightmost().Y-getleftmost().Y)/(getrightmost().X-getleftmost().X);
            double cst = A.Y-(dir*A.X);
            return  (dir*x)+cst;
        }
    }
}