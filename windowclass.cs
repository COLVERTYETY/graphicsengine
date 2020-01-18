using System;
namespace graphicsengine
{
    class frame{
        public char usedchar='*';
        public char emptychar=' ';
        public int size =1;
        public char[,] display;
        public char[,] todisplay;
        
        public void initialze(int width , int height, int newsize){
            display=new char[width,height];
            for(int i=0; i<width;i++){
                for(int j = 0;j<height;j++){
                    display[i,j]=emptychar;
                }
            }
            todisplay=display;
            size = newsize;
        }
        
        public void fullflip(){
            todisplay=display;
            Console.Clear();
            //Console.SetBufferSize(display.GetLength(0),display.GetLength(1));
            for(int x=0; x<display.GetLength(0);x++){
                for(int y=0;y<display.GetLength(1);y++){
                    Console.SetCursorPosition(x,y);
                    Console.Write(todisplay[x,y]);
                }
            }
        }
        public void flip(){
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