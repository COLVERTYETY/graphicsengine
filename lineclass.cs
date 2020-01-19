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
        public line( float x1, float y1, float x2, float y2, char fillchar=' '){
            A = new point(x1,y1);
            B = new point(x2,y2);
            spcecialchar = fillchar;
        }
        public float getuper(){
            float res=B.Y;
            if(A.Y>B.Y){
                res = A.Y;
            }
            return res;
        }
        public float getlower(){
            float res=B.Y;
            if(A.Y<B.Y){
                res = A.Y;
            }
            return res;
        }
        public float getrightmost(){
            float res=B.X;
            if(A.X>B.X){
                res = A.X;
            }
            return res;
        }
        public float getleftmost(){
            float res=B.X;
            if(A.X<B.X){
                res = A.X;
            }
            return res;
        }
        public float gethorizontalintersection(float y){   ///should this return a point?
            float dir = (getuper()-getlower())/(getrightmost()-getleftmost());
            float cst = A.Y-(dir*A.X);
            return  (y-cst)/dir;
        }
        public float getverticalintersection(float x){   ///should this return a point?
            float dir = (getuper()-getlower())/(getrightmost()-getleftmost());
            float cst = A.Y-(dir*A.X);
            return  (dir*x)+cst;
        }
    }
}