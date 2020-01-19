using System;
using System.Diagnostics;
namespace graphicsengine
{
    class analyse{
        public static float Measure(Delegate tomeasure){
            Stopwatch sw = new Stopwatch();
            sw.Start();
            //tomeasure.Invoke();
            sw.Stop();
            return (float)sw.ElapsedMilliseconds;
        }
    }
}