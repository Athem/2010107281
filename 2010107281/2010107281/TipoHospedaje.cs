using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010107281
{
    public class TipoHospedaje
    {
      public string seleccionTipoHospedaje(int ale) //hotel hostal backpacker
        {
            if (ale == 1)
            {
                return "Hostal";
            }
            else if (ale == 2)
            {
                return "Departamento";
            }
            else if(ale == 3)
            {
                return "backpacker";
            }else
            {
                return "Hotel";
            }
            
        }
    }
}
