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

        public SemaforState predniSemafor { get; private set; } = SemaforState.Cervena;
        public SemaforState zadniSemafor { get; private set; } = SemaforState.Cervena;

        public CarState autoPozice { get;  set; }

        private CarWashDTO _CarWashState { get; set; }
        public CarWashDTO CarWashState { get { return _CarWashState; } private set { var changed = (value != _CarWashState); _CarWashState = value; if (changed) OnCarWashStateChanged?.Invoke(this, _CarWashState); } }

        public delegate void ChangedCarWashState(object sender, CarWashDTO CarWashState);
        public event ChangedCarWashState OnCarWashStateChanged;

        // booleans pro vstup uživatele
        public bool jeAutoPripraveno { get; private set; } = false;

        private bool Running { get; set; } = false;


        public int WorkingCycleMs = 5000;

        private Thread _thread = new Thread(new ParameterizedThreadStart(ThreadProcedure));

        private static void ThreadProcedure(object obj)
        {
            var carWash = (CarWash)obj;
            var processStopWatch = Stopwatch.StartNew();
            int stavAutomatu = 0;

            // nastaveni pocatecniho stavu
            carWash.autoPozice = CarState.cekaNaPrijezd;


            while (true)
            {
                Stopwatch timingStopWatch = Stopwatch.StartNew();

                processStopWatch.Stop();
                var elapsedTimeSeconds = processStopWatch.Elapsed.TotalSeconds;

                switch (stavAutomatu)
                {
                   case 0:
                        if (carWash.autoPozice == CarState.cekaNaMycku)
                        {
                            carWash.predniVrataOtevrena = true;
                            carWash.predniSemafor = SemaforState.Želená;

                            carWash.CarWashState = UpdateDTO(carWash);

                            stavAutomatu = 1;
                        }
                        break;

                    case 1:
                        if (carWash.autoPozice == CarState.uvnitrMycky)
                        {
                            carWash.predniVrataOtevrena = false;
                            carWash.zadniVrataOtevrena = false;
                            carWash.predniSemafor = SemaforState.Cervena;
                            carWash.zadniSemafor = SemaforState.Cervena;

                            carWash.CarWashState = UpdateDTO(carWash);

                            // aktivace procesu mytí
                            carWash.Running = true;
                            stavAutomatu = 2;
                        }
                        break;

                    case 2:
                        if (carWash.Running == false)
                        {
                            carWash.zadniVrataOtevrena = true;
                            carWash.zadniSemafor = SemaforState.Želená;

                            carWash.CarWashState = UpdateDTO(carWash);

                            stavAutomatu = 3;
                        }
                        break;

                    case 3:
                        if (carWash.autoPozice == CarState.zaMyckou)
                        {
                            carWash.zadniVrataOtevrena = false;
                            carWash.zadniSemafor = SemaforState.Cervena;

                            carWash.CarWashState = UpdateDTO(carWash);

                            stavAutomatu = 0;
                        }
                        break;


                }

                if(carWash.Running)
                {
                    processStopWatch.Restart();

                    timingStopWatch.Stop();

                    var toWaitMs = carWash.WorkingCycleMs - (int)timingStopWatch.ElapsedMilliseconds;
                    toWaitMs = toWaitMs < 1 ? 1 : toWaitMs;

                    try
                    {
                        Thread.Sleep(toWaitMs);
                        carWash.Running = false;
                    }
                    catch (ThreadInterruptedException)
                    {
                        carWash.Running = false;


                        carWash.Dispose();
                    }
                }


            }
        }

        public CarWash()
        {
            Running = false;
            _thread.Start(this);
        }

        private static CarWashDTO UpdateDTO(CarWash self)
        {
            var CarWashDTO = new CarWashDTO(self.predniVrataOtevrena, self.zadniVrataOtevrena, self.predniSemafor, self.zadniSemafor);
            return CarWashDTO;
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
                Console.WriteLine(e.Message);
            }
    }
}
}
