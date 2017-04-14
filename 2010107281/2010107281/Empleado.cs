using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010107281
{
    public class Empleado : Persona
    {

        string _numero;

        public Empleado(string numero)
        {
            _numero = numero;
        }
        public string Numero { get { return _numero; } }
    }
}
