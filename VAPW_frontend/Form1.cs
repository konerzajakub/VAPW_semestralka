using System.Media;
using System.Security.Policy;
using System.Windows.Forms;
using VAPW_backend;
using static VAPW_backend.CarWash;

// Vybrání správného Timeru
using Timer = System.Windows.Forms.Timer;


namespace VAPW_frontend
{
    public partial class Form1 : Form
    {
        // Deklarace myèky & pùvodní pozice auta
        CarWash mycka;
        Point puvodniPozicePorsche;

        // Defaultnì - eventy
        bool eventMode = true;

        // Timer
        Timer timer = new Timer();

        public Form1()
        {
            InitializeComponent();

            // Inicializace myèky
            mycka = new CarWash();

            // Inicializace auta
            puvodniPozicePorsche = Porsche.Location;

            // Pøidání eventu 
            mycka.OnCarWashStateChanged += OnChangedCarWashState;

            // timer stuff
            timer.Tick += new EventHandler(onCheckCarWash);
            // 100ms
            timer.Interval = 100;
            timer.Start();

        }
        
        // Timer zpùsob kontroly zmìny stavu
        private void onCheckCarWash(object? sender, EventArgs e)
        {
            // Zastavení timeru aby se to nepøekrývalo
            timer.Stop();

            // Pokud není zapnuta kontrola pøes eventy
            if (!eventMode)
            {
                // Zmìna semaforù
                if (mycka.predniSemafor == SemaforState.Želená)
                {
                    predniSemafor.BackColor = Color.Green;
                }

                if (mycka.predniSemafor == SemaforState.Cervena)
                {
                    predniSemafor.BackColor = Color.Red;
                }

                if (mycka.zadniSemafor == SemaforState.Želená)
                {
                    zadniSemafor.BackColor = Color.Green;
                }

                if (mycka.zadniSemafor == SemaforState.Cervena)
                {
                    zadniSemafor.BackColor = Color.Red;
                }

                // Vrata + animace
                if (mycka.predniVrataOtevrena == false)
                {
                    var aktualniPozice = vstupniVrata.Location;
                    if (aktualniPozice.Y == 233)
                    {

                        for (int iter = 0; iter < 223; iter++)
                        {
                            vstupniVrata.Location = new Point(aktualniPozice.X, aktualniPozice.Y + iter);
                        }
                    }


                    vstupniVrata.Location = new Point(478, 439);
                }

                if (mycka.predniVrataOtevrena == true)
                {
                    var aktualniPozice = vstupniVrata.Location;
                    if (aktualniPozice.Y == 426)
                    {
                        for (int iter = 0; iter < 223; iter++)
                        {
                            vstupniVrata.Location = new Point(aktualniPozice.X, aktualniPozice.Y - iter);
                        }
                    }
                    vstupniVrata.Location = new Point(478, 233);
                }

                if (mycka.zadniVrataOtevrena == false)
                {
                    var aktualniPozice = vyjezdoveVrata.Location;
                    if (aktualniPozice.Y == 233)
                    {
                        for (int iter = 0; iter < 223; iter++)
                        {
                            vyjezdoveVrata.Location = new Point(aktualniPozice.X, aktualniPozice.Y + iter);
                        }
                    }
                    vyjezdoveVrata.Location = new Point(906, 439);
                }

                if (mycka.zadniVrataOtevrena == true)
                {
                    var aktualniPozice = vyjezdoveVrata.Location;
                    if (aktualniPozice.Y == 439)
                    {
                        for (int iter = 0; iter < 223; iter++)
                        {
                            vyjezdoveVrata.Location = new Point(aktualniPozice.X, aktualniPozice.Y - iter);
                        }
                    }
                    vyjezdoveVrata.Location = new Point(906, 233);
                }
            }

            // Spuštìní timeru
            timer.Start();
        }

        // Event zpùsob kontroly zmìny stavu
        private void OnChangedCarWashState(object sender, CarWashDataEnkapsulace CarWashState)
        {
            // Pokud kontrola eventù
            if (eventMode)
            {
                Invoke(new Action(() =>
                {
                    // Zmìna semaforù
                    if (CarWashState.predniSemafor == SemaforState.Želená)
                    {
                        predniSemafor.BackColor = Color.Green;
                    }

                    if (CarWashState.predniSemafor == SemaforState.Cervena)
                    {
                        predniSemafor.BackColor = Color.Red;
                    }

                    if (CarWashState.zadniSemafor == SemaforState.Želená)
                    {
                        zadniSemafor.BackColor = Color.Green;
                    }

                    if (CarWashState.zadniSemafor == SemaforState.Cervena)
                    {
                        zadniSemafor.BackColor = Color.Red;
                    }


                    // Zmìna vrat & animace
                    if (CarWashState.predniVrataOtevrena == false)
                    {
                        var aktualniPozice = vstupniVrata.Location;
                        if (aktualniPozice.Y == 233) {

                            for (int iter = 0; iter < 223; iter++)
                            {
                                vstupniVrata.Location = new Point(aktualniPozice.X, aktualniPozice.Y + iter);
                            }
                        }
                        vstupniVrata.Location = new Point(478, 439);
                    }

                    if (CarWashState.predniVrataOtevrena == true)
                    {
                        var aktualniPozice = vstupniVrata.Location;
                        if (aktualniPozice.Y == 426)
                        {
                            for (int iter = 0; iter < 223; iter++)
                            {
                                vstupniVrata.Location = new Point(aktualniPozice.X, aktualniPozice.Y - iter);
                            }
                        }
                        vstupniVrata.Location = new Point(478, 233);
                    }

                    if (CarWashState.zadniVrataOtevrena == false)
                    {

                        var aktualniPozice = vyjezdoveVrata.Location;
                        if (aktualniPozice.Y == 233)
                        {
                            for (int iter = 0; iter < 223; iter++)
                            {
                                vyjezdoveVrata.Location = new Point(aktualniPozice.X, aktualniPozice.Y + iter);
                            }
                        }
                        vyjezdoveVrata.Location = new Point(906, 439);
                    }

                    if (CarWashState.zadniVrataOtevrena == true)
                    {
                        var aktualniPozice = vyjezdoveVrata.Location;
                        if (aktualniPozice.Y == 439)
                        {
                            for (int iter = 0; iter < 223; iter++)
                            {
                                vyjezdoveVrata.Location = new Point(aktualniPozice.X, aktualniPozice.Y - iter);
                            }
                        }
                        vyjezdoveVrata.Location = new Point(906, 233);
                    }
                }));
            }
        }

        // Vytvoøení formu pro výbìr event/timer
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 okenko = new Form2();
            okenko.ShowDialog();

            // Nastavení výsledného výbìru
            eventMode = okenko.useEvents;
        }

        // Tlaèítko pro pohyb auta pøed myèku
        private void prijetPred_btn_Click(object sender, EventArgs e)
        {
            if (mycka.autoPozice == CarState.cekaNaPrijezd)
            {
                //Porsche.Location = new Point(puvodniPozicePorsche.X + 170, puvodniPozicePorsche.Y);

                var aktualniPozice = Porsche.Location;

                for (int iter = 0; iter < 170; iter++)
                {
                    Porsche.Location = new Point(aktualniPozice.X + iter, aktualniPozice.Y);
                }
                // Zmìna pozice auta
                mycka.autoPozice = CarState.cekaNaMycku;
            }
        }

        // ?? co to je za tlaèítko, nejde vidìt v designeru
        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Tlaèítko pro pohyb auta dovnitø myèky
        private void jetDovnitr_btn_Click(object sender, EventArgs e)
        {
            if (mycka.autoPozice == CarState.cekaNaMycku && predniSemafor.BackColor == Color.Green && vstupniVrata.Location.Y < 300)
            {
                //Porsche.Location = new Point(Porsche.Location.X + 400, puvodniPozicePorsche.Y);

                var aktualniPozice = Porsche.Location;

                for (int iter = 0; iter < 400; iter++)
                {
                    Porsche.Location = new Point(aktualniPozice.X + iter, aktualniPozice.Y);
                }
                // Zmìna pozice auta
                mycka.autoPozice = CarState.uvnitrMycky;
            }
        }

        // Tlaèítko pro vyjetí z myèky
        private void vyjet_btn_Click(object sender, EventArgs e)
        {
            if (mycka.autoPozice == CarState.uvnitrMycky && zadniSemafor.BackColor == Color.Green)
            {
                //Porsche.Location = new Point(Porsche.Location.X + 400, puvodniPozicePorsche.Y);

                var aktualniPozice = Porsche.Location;

                for (int iter = 0; iter < 800; iter++)
                {
                    Porsche.Location = new Point(aktualniPozice.X + iter, aktualniPozice.Y);
                }
                // Zmìna pozice auta
                mycka.autoPozice = CarState.zaMyckou;
            }
        }
    }
}
