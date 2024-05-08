using System.Security.Policy;
using System.Windows.Forms;
using VAPW_backend;
using static VAPW_backend.CarWash;
using Timer = System.Windows.Forms.Timer;


namespace VAPW_frontend
{
    public partial class Form1 : Form
    {

        CarWash mycka;
        Point puvodniPozicePorsche;
        bool handleEvents = true;

        public Form1()
        {
            InitializeComponent();
            mycka = new CarWash();

            puvodniPozicePorsche = Porsche.Location;

            mycka.OnCarWashStateChanged += OnChangedCarWashState;

            //timer.Tick += new EventHandler(CheckCarWash);
            //timer.Interval = 100;
            //timer.Start();

        }

        private void OnChangedCarWashState(object sender, CarWashDTO CarWashState)
        {
            if (handleEvents)
            {
                Invoke(new Action(() =>
                {
                    //doSemaphor(InSemafor, CarWashState.InputSemafor);
                    //doSemaphor(OutSemafor, CarWashState.OutputSemafor);
                    //doGates(InGate, CarWashState.InputVrataOpen);
                    //doGates(OutGate, CarWashState.OutputVrataOpen);

                    // semafory
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


                    // vrata
                    if (CarWashState.predniVrataOtevrena == false)
                    {
                        vstupniVrata.Location = new Point(478, 439);
                    }

                    if (CarWashState.predniVrataOtevrena == true)
                    {
                        vstupniVrata.Location = new Point(478, 233);
                    }

                    if (CarWashState.zadniVrataOtevrena == false)
                    {
                        vyjezdoveVrata.Location = new Point(906, 423);
                    }

                    if (CarWashState.zadniVrataOtevrena == true)
                    {
                        vyjezdoveVrata.Location = new Point(906, 233);
                    }

                }));
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form2 okenko = new Form2();
            okenko.ShowDialog();
        }

        private void prijetPred_btn_Click(object sender, EventArgs e)
        {
            if (mycka.autoPozice == CarState.cekaNaPrijezd)
            {
                Porsche.Location = new Point(puvodniPozicePorsche.X + 170, puvodniPozicePorsche.Y);
                mycka.autoPozice = CarState.cekaNaMycku;
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void jetDovnitr_btn_Click(object sender, EventArgs e)
        {
            if (mycka.autoPozice == CarState.cekaNaMycku && predniSemafor.BackColor == Color.Green && vstupniVrata.Location.Y < 300)
            {
                Porsche.Location = new Point(Porsche.Location.X + 400, puvodniPozicePorsche.Y);
                mycka.autoPozice = CarState.uvnitrMycky;
            }
        }


        private void vyjet_btn_Click(object sender, EventArgs e)
        {
            if (mycka.autoPozice == CarState.uvnitrMycky && zadniSemafor.BackColor == Color.Green)
            {
                Porsche.Location = new Point(Porsche.Location.X + 400, puvodniPozicePorsche.Y);

                for (int iter = 0; iter < 400; iter++)
                {
                    //Porsche.Location = new Point(puvodniPozicePorsche.X + iter + 400, puvodniPozicePorsche.Y);
                }



                mycka.autoPozice = CarState.zaMyckou;
            }
        }
    }
}
