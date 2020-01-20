using System;
using System.Diagnostics;
namespace graphicsengine
{
    static class analyse{
        public static float Measure(Action tomeasure){
            Stopwatch sw = new Stopwatch();
            sw.Start();
            tomeasure();
            sw.Stop();
            return (float)sw.ElapsedMilliseconds;
        }
    }
}