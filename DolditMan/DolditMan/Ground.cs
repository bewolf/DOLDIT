using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DolditMan
{
    class Ground
    {
        public int X { get; set; }
        public int Size { get; set; }
        Thread t;
        public int Speed { get; set; }
        public void Start()
        {
            t = new Thread(new ThreadStart(Move));
            t.Start();
        }
        public void Move()
        {
            while (X+Size*100>0)
            {
                X -= 1;
                Thread.Sleep(Speed);
            }
        }
        public void Stop()
        {
            t.Abort();
        }

    }
}
