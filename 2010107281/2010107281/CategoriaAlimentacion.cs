using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010107281
{
    public class CategoriaAlimentacion
    {
        public string seleccionCategoriaAlimentacion(int ale)
        {
            if(ale == 1)
            {
                return "Basico";
            }else if (ale == 2)
            {
                return "VIP";
            }
            else
            {
                return "Normal";
            }
        }

    }
}
