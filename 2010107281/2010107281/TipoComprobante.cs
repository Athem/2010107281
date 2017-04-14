using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010107281
{
    public class TipoComprobante
    {
        string _numero;

        public TipoComprobante(string numero)
        {
            _numero = numero;
        }

        public string Numero { get { return _numero; } }

        public string seleccionTipoComprobante(int ale)
        {
            if (ale == 1)
            {
                return "Factura";
            }
            else
            {
                return "Boleta";
            }
        }
    }
}
