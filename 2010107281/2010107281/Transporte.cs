using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010107281
{
    class Transporte : ServicioTuristico
    {
        private TipoTransporte _tipoTransporte;
        private CategoriaTransporte _categoriaTransporte;

        public Transporte(string numero) : base(numero)
        {
        }

        public TipoTransporte tipTra { get { return _tipoTransporte; } }
        public CategoriaTransporte catTra { get { return _categoriaTransporte; } }
    }
}
