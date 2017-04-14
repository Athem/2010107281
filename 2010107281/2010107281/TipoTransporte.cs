using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010107281
{
    public class TipoTransporte
    {
        public string seleccionTipoTransporte(int ale)
        {
            if (ale == 1)
            {
                return "Bus";
            }
            else if (ale == 2)
            {
                return "Limosina";
            }
            else
            {
                return "Auto";
            }
        }
    }
}
