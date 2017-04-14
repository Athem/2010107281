using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010107281
{
    public class ComprobantePago
    {       
        private TipoComprobante _tipoComprobante;

        string _numero;

        public ComprobantePago(string numero)
        {
            _numero = numero;
        }

        public TipoComprobante TipCom { get { return _tipoComprobante; } }
    }
}
