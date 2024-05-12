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
        // Deklarace proměnných

        // Stav vrat
        public bool predniVrataOtevrena { get; private set; } = false;
        public bool zadniVrataOtevrena { get; private set; } = false;

        // Stav semaforu
        public SemaforState predniSemafor { get; private set; } = SemaforState.Cervena;
        public SemaforState zadniSemafor { get; private set; } = SemaforState.Cervena;

        // Stav auta
        public CarState autoPozice { get;  set; }

        // DTO pro komunikaci s frontendem
        private CarWashDataEnkapsulace _CarWashState { get; set; }
        public CarWashDataEnkapsulace CarWashState { get { return _CarWashState; } private set { var changed = (value != _CarWashState); _CarWashState = value; if (changed) OnCarWashStateChanged?.Invoke(this, _CarWashState); } }

        // Delegát pro změnu stavu
        public delegate void ChangedCarWashState(object sender, CarWashDataEnkapsulace CarWashState);
        // Event pro změnu stavu
        public event ChangedCarWashState OnCarWashStateChanged;

        // Stav procesu mytí
        private bool Running { get; set; } = false;

        // Doba trvání jednoho cyklu mytí
        public int WorkingCycleMs = 5000;

        // Vlákno pro obsluhu myčky
        private Thread _thread = new Thread(new ParameterizedThreadStart(ThreadProcedure));

        // Metoda pro obsluhu vlákna
        private static void ThreadProcedure(object obj)
        {
            var carWash = (CarWash)obj;
            var processStopWatch = Stopwatch.StartNew();

            // Stavový automat - 0 = čeká na auto, 1 = auto přijelo, 2 = až se domyje, 3 = auto odjelo
            int stavAutomatu = 0;

            // Inicializace stavu auta
            carWash.autoPozice = CarState.cekaNaPrijezd;

            while (true)
            {
                Stopwatch timingStopWatch = Stopwatch.StartNew();
                processStopWatch.Stop();
                var elapsedTimeSeconds = processStopWatch.Elapsed.TotalSeconds;

                // Stavový automat myčky
                switch (stavAutomatu)
                {
                   case 0:
                        // Jestli auto čeká na myčku, otevřou se přední vrata a semafor se nastaví na zelenou
                        if (carWash.autoPozice == CarState.cekaNaMycku)
                        {
                            carWash.predniVrataOtevrena = true;
                            carWash.predniSemafor = SemaforState.Želená;

                            // Aktualizace DTO
                            carWash.CarWashState = aktualizovatDataEnkapsulace(carWash);

                            stavAutomatu = 1;
                        }
                        break;

                    case 1:
                        // Jestli auto je uvnitř myčky, zavřou se přední vrata a semafor se nastaví na červenou
                        if (carWash.autoPozice == CarState.uvnitrMycky)
                        {
                            carWash.predniVrataOtevrena = false;
                            carWash.predniSemafor = SemaforState.Cervena;
                            carWash.zadniSemafor = SemaforState.Cervena;

                            // Aktualizace DTO
                            carWash.CarWashState = aktualizovatDataEnkapsulace(carWash);

                            // Aktivace procesu mytí
                            carWash.Running = true;

                            stavAutomatu = 2;
                        }
                        break;

                    case 2:
                        // Jestli myčka doběhla, otevřou se zadní vrata a semafor se nastaví na zelenou
                        if (carWash.Running == false)
                        {
                            carWash.zadniVrataOtevrena = true;
                            carWash.zadniSemafor = SemaforState.Želená;

                            // Aktualizace DTO
                            carWash.CarWashState = aktualizovatDataEnkapsulace(carWash);

                            stavAutomatu = 3;
                        }
                        break;

                    case 3:
                        // Jestli auto odjelo, zavřou se zadní vrata a semafor se nastaví na červenou
                        if (carWash.autoPozice == CarState.zaMyckou)
                        {
                            carWash.zadniVrataOtevrena = false;
                            carWash.zadniSemafor = SemaforState.Cervena;

                            // Aktualizace DTO
                            carWash.CarWashState = aktualizovatDataEnkapsulace(carWash);

                            stavAutomatu = 0;
                        }
                        break;


                }

                // Proces myčky
                if (carWash.Running)
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
        // Konstruktor CarWash
        public CarWash()
        {
            Running = false;
            _thread.Start(this);
        }

        // Metoda pro aktualizace DTO
        private static CarWashDataEnkapsulace aktualizovatDataEnkapsulace(CarWash self)
        {
            var CarWashDTO = new CarWashDataEnkapsulace(self.predniVrataOtevrena, self.zadniVrataOtevrena, self.predniSemafor, self.zadniSemafor);
            return CarWashDTO;
        }

        // Ukončení threadu
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
