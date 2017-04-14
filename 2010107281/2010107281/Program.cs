using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using _2010107281.Entities;
using System.Threading;

namespace _2010107281
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            Random rnd1 = new Random();
            Random rnd2 = new Random();
            //rnd.Next(min, max)
            rnd.Next(0, 4); //Cliente Empleado 
            rnd1.Next(0, 3); //TipoHospedaje  Categoria ServicioHospedaje
            rnd2.Next(0, 4); //ClasificacionHospedaje

            var central = new VentaPaquete();
            Console.WriteLine("Bienvenido");
            central.AgregarNombre(rnd.ToString());
            central.Agregar(rnd1.ToString());
        }
    }
}
