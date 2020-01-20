using System;
namespace graphicsengine
{
    class frame{
        const char usedchar='*';
        const char emptychar=' ';
        public static int logline=0;
        static char[,] display;
        static char[,] todisplay;
        
        public void initialze(int width , int height){
            display=new char[width,height];  // Noncompliant
            todisplay = new char[width,height];  // Noncompliant
            for(int i=0; i<width;i++){
                for(int j = 0;j<height;j++){
                    display[i,j]=emptychar;
                    todisplay[i,j]=emptychar;
                }
            }
        }
        
        public static void fullflip(){
            Console.Clear();
            for(int x=0; x<display.GetLength(0);x++){
                for(int y=0;y<display.GetLength(1);y++){
                    Console.SetCursorPosition(x,y);
                    display[x,y]=todisplay[x,y];
                    Console.Write(display[x,y]);  // Noncompliant
                }
            }
        }
        public static void Clear(){
            for(int i =0; i <todisplay.GetLength(0);i++){
                for(int j=0; j<todisplay.GetLength(1);j++){
                    todisplay[i,j]=emptychar;
                }
            }
        }
        public static void fill(char filler){
            for(int i =0; i <todisplay.GetLength(0);i++){
                for(int j=0; j<todisplay.GetLength(1);j++){
                    todisplay[i,j]=filler;
                }
            }
        }
        public static void sidelog(string txt, int xoffset=0, int yoffset=-1,int extrapadding=10){
            if(yoffset==-1){yoffset=logline;logline++;/*if(logline>todisplay.GetLength(1)){logline=0;}*/}
            Console.SetCursorPosition(todisplay.GetLength(0)+xoffset,yoffset);
            Console.Write(txt.PadRight(extrapadding));
        }
        public static void renderline(line li){
            char thechar = usedchar;
            if(li.spcecialchar!=' '){
                thechar = li.spcecialchar;
            }
            if ((li.getuper().Y-li.getlower().Y)>(li.getrightmost().X-li.getleftmost().X)){
                for( double i = li.getlower().Y; i<li.getuper().Y; i++){
                double x = li.gethorizontalintersection(i);
                int y = (int)(i);
                int xx = (int)(x);
                if( xx>=0 && xx<todisplay.GetLength(0) && y>=0 && y<todisplay.GetLength(1)){
                    todisplay[xx,y]=thechar;
                } else {
                    sidelog("limit error 1: " + Convert.ToString(x)+" "+ Convert.ToString(y));
                }}     
            }else {
                for( double i = li.getleftmost().X; i<li.getrightmost().X; i++){
                    double y = li.getverticalintersection(i);
                    int yy = (int)(y);
                    int x = (int)(i);
                    if( x>=0 && x<todisplay.GetLength(0) && yy>=0 && yy<todisplay.GetLength(1)){
                        todisplay[x,yy]=thechar;
                    } else {
                        sidelog("limit error 2: " + Convert.ToString(x)+" "+ Convert.ToString(y));
                    }
                }
            }            
        }
        public static void renderpolygons(){
            foreach( polygon poly in polygon.allthePolygon){
                foreach(line li in poly.lines){
                    renderline(li);
                }
            }
        }
        public static void drawcircle(int xcenter, int ycenter, int radius, char fillchar='*'){
            for(int x=0; x<todisplay.GetLength(0);x++){
                for(int y=0;y<todisplay.GetLength(1);y++){
                    if(Math.Sqrt((x-xcenter)*(x-xcenter)+(y-ycenter)*(y-ycenter))<radius){
                        todisplay[x,y]=fillchar;
                    }
                }
            }
        }
        public static void flip(){
            for(int x=0; x<display.GetLength(0);x++){
                for(int y=0;y<display.GetLength(1);y++){
                    if(display[x,y]!=todisplay[x,y]){
                        Console.SetCursorPosition(x,y);
                        Console.Write(todisplay[x,y]);
                        display[x,y]=todisplay[x,y];  // Noncompliant
                    }
                }
            }
        }

    }
}