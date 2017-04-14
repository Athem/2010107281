using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010107281
{
    public class Alimentacion :ServicioTuristico
    {        
        private CategoriaAlimentacion _categoriaAlimentacion;

        public Alimentacion(string numero) : base(numero)
        {
        }

        public CategoriaAlimentacion catAli { get { return _categoriaAlimentacion; } }
    }
}
