using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010107281
{
    public class MedioPago
    {
        string _numero;

        public MedioPago(string numero)
        {
            _numero = numero;
        }
        public string seleccionMedioPago(int ale)
        {
            if (ale == 1)
            {
                return "Efectivo";
            }
            else if (ale == 2)
            {
                return "Vía Web";
            }
            else
            {
                return "Tarjeta de Crédito";    
            }
        }
    }
}
