using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010107281
{
    public class Persona
    {        
        public string seleccionNombre(int ale)
        {
            
            if (ale == 1)
            {
                return "Juan Perez";
            }
            else if (ale == 2)
            {
                return "Pedro Gomez";
            }
            else if (ale == 3)
            {
                return "Miguel Zapata";
            }
            else
            {
                return "Armando Casas";
            }
        }
    }
}
