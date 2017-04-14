using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010107281
{
    public class TipoHospedaje
    {
      public string seleccionTipoHospedaje(int aleTipo) //hotel hostal backpacker
        {
            switch (aleTipo)
            {
                case 1 :
                    return "Hostal";
                    break;

                case 2 :
                    return "Hotel";
                    break;

                case 3:
                    return "Departamento";
                    break;

                default:
                    return "backpacker";
                    break;
            }
        }
    }
}
