using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAPW_backend
{

    // Data Transfer Object pro komunikaci s frontendem
    public class CarWashDataEnkapsulace
    {
        // Stav vrat & semaforů
        public bool predniVrataOtevrena { get; private set; }
        public bool zadniVrataOtevrena { get; private set; }
        public SemaforState predniSemafor { get; private set; }
        public SemaforState zadniSemafor { get; private set; }

        public CarWashDataEnkapsulace(bool _predniVrataOtevrena, bool _zadniVrataOtevrena, SemaforState _predniSemafor, SemaforState _zadniSemafor)
        {
            // Konstruktor třídy, který nastavuje hodnoty z parametru
            predniVrataOtevrena = _predniVrataOtevrena;
            zadniVrataOtevrena = _zadniVrataOtevrena;
            predniSemafor = _predniSemafor;
            zadniSemafor = _zadniSemafor;
        }
    }
}


