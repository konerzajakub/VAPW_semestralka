using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAPW_backend
{

    public class CarWashDTO
    {
        public bool predniVrataOtevrena { get; private set; }
        public bool zadniVrataOtevrena { get; private set; }
        public SemaforState predniSemafor { get; private set; }
        public SemaforState zadniSemafor { get; private set; }

        public CarWashDTO(bool _predniVrataOtevrena, bool _zadniVrataOtevrena, SemaforState _predniSemafor, SemaforState _zadniSemafor)
        {
            predniVrataOtevrena = _predniVrataOtevrena;
            zadniVrataOtevrena = _zadniVrataOtevrena;
            predniSemafor = _predniSemafor;
            zadniSemafor = _zadniSemafor;
        }
    }
}


