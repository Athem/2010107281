using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010107281
{
    public class ClasificacionHospedaje
    {
     
        public string seleccionClasificacionHospedaje(int ale) //1 - 5 estrellas  ✰
        {
            if (ale.Equals(1))
            {
                return "1 Estrella ";//✰
            }
            else if (ale.Equals(2))
            {
                return "2 Estrella ";//✰✰
            }
            else if(ale.Equals(3))
            {
                return "3 Estrella ";//✰✰✰
            }
            else if(ale.Equals(4))
            {
                return "4 Estrella ";//✰✰✰✰
            }
            else
            {
                return "5 Estrella ";//✰✰✰✰✰
            }
                        
        }
    }
}
