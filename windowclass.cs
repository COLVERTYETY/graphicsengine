using System;
namespace graphicsengine
{
    class frame{
        const char usedchar='*';
        const char emptychar=' ';
        const int size =1;
        static char[,] display;
        static char[,] todisplay;
        
        public void initialze(int width , int height){
            display=new char[width,height];
            todisplay = new char[width,height];
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
                    Console.Write(display[x,y]);
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
        public static void renderpolygons(){
            foreach( polygon poly in polygon.allthePolygon){
                foreach(line li in poly.lines){
                    for( float i = li.getlower(); i<li.getuper(); i+=size){
                        float x = li.gethorizontalintersection(i);
                        int y = (int)(i/size);
                        int xx = (int)(x);
                        if( xx>=0 && xx<todisplay.GetLength(0) && y>=0 && y<todisplay.GetLength(1)){
                            todisplay[xx,y]=usedchar;
                        }
                    }
                    for( float i = li.getleftmost(); i<li.getrightmost(); i+=size){
                        float y = li.getverticalintersection(i);
                        int yy = (int)(y);
                        int x = (int)(i/size);
                        if( x>=0 && x<todisplay.GetLength(0) && yy>=0 && yy<todisplay.GetLength(1)){
                            todisplay[x,yy]=usedchar;
                        }
                    }
                }
            }
        }
        public static void drawcircle(int xcenter, int ycenter, int radius){
            for(int x=0; x<todisplay.GetLength(0);x++){
                for(int y=0;y<todisplay.GetLength(1);y++){
                    if(Math.Sqrt((x-xcenter)*(x-xcenter)+(y-ycenter)*(y-ycenter))<radius){
                        todisplay[x,y]=usedchar;
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
                        display[x,y]=todisplay[x,y];
                    }
                }
            }
        }

    }
}