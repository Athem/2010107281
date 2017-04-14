using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010107281
{
    public class ClasificacionHospedaje
    {
     
        public string seleccionClasificacionHospedaje(int aleClasi) //1 - 5 estrellas  ✰
        {
            switch (aleClasi)
            {
                case 1:
                    return "✰";
                    break;

                case 2:
                    return "✰✰";
                    break;

                case 3:
                    return "✰✰✰";
                    break;
                case 4:
                    return "✰✰✰✰";
                    break;

                default:
                    return "✰✰✰✰✰";
                    break;
            }
        }
    }
}
