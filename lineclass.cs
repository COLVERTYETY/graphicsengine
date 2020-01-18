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
            float res=B.y;
            if(A.y>B.y){
                res = A.y;
            }
            return res;
        }
        public float getlower(){
            float res=B.y;
            if(A.y<B.y){
                res = A.y;
            }
            return res;
        }
        public float getrightmost(){
            float res=B.x;
            if(A.x>B.x){
                res = A.x;
            }
            return res;
        }
        public float getleftmost(){
            float res=B.x;
            if(A.x<B.x){
                res = A.x;
            }
            return res;
        }
        public float gethorizontalintersection(int y){   ///should this return a point?
            float dir = (getuper()-getlower())/(getrightmost()-getleftmost());
            float cst = A.y-dir*A.x;
            return  (y-cst)/dir;
        }
        public float getverticalintersection(int x){   ///should this return a point?
            float dir = (getuper()-getlower())/(getrightmost()-getleftmost());
            float cst = A.y-dir*A.x;
            return  (dir*x)+cst;
        }
    }
}