using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010107281
{
    public class ServicioHospedaje
    {
        public string seleccionServicioHospedaje(int ale)
        {
            if (ale.Equals(1))
            {
                return "Lavanderia";
            }
            else if (ale.Equals(2))
            {
                return "Planchado";
            }
            else
            {
                return "Room Servicio";
            }
        }
    }
}
