using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010107281
{
    public class CategoriaTransporte
    {
        public string seleccionCategoriaTransporte(int ale)
        {
            if (ale.Equals(1))
            {
                return "Basico";
            }
            else if (ale.Equals(2))
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
