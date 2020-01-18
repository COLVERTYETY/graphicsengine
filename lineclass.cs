using System;
namespace graphicsengine 
{
    class line
    {
        public point A;
        public point B;
        public line(point aa, point bb){
            A = aa;
            B = bb;
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
            float cst = A.Y-dir*A.X;
            return  (y-cst)/dir;
        }
        public float getverticalintersection(float x){   ///should this return a point?
            float dir = (getuper()-getlower())/(getrightmost()-getleftmost());
            float cst = A.Y-dir*A.X;
            return  (dir*x)+cst;
        }
    }
}