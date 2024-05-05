using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VAPW_backend
{
    public class CarWash : IDisposable
    {
        // vrata 
        public bool predniVrataOtevrena { get; private set; } = false;
        public bool zadniVrataOtevrena { get; private set; } = false;

        public SemaforState predniSemafor { get; private set; }
        public SemaforState zadniSemafor { get; private set; }

        public CarState autoPozice { get; private set; }

        // booleans pro vstup uživatele
        public bool jeAutoPripraveno { get; private set; } = false;
        public 



        private bool Running { get; set; }
        private int WorkingCycleMs { get; set; }

        private Thread _thread = new Thread(new ParameterizedThreadStart(ThreadProcedure));

        private static void ThreadProcedure(object obj)
        {
            var carWash = (CarWash)obj;
            var processStopWatch = Stopwatch.StartNew();
            int stavAutomatu = 0;

            while (carWash.Running)
            {
                Stopwatch timingStopWatch = Stopwatch.StartNew();

                processStopWatch.Stop();
                var elapsedTimeSeconds = processStopWatch.Elapsed.TotalSeconds;

                switch (stavAutomatu)
                {
                    case 0:


                }


            }
        }




        public void Dispose()
    {
        try
        {
            _thread.Interrupt();
            _thread.Join();
        }
        catch (Exception e)
        {

        }
    }
}
}
