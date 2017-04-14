using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _2010107281   
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r= new Random();
          
            //rnd.Next(min, max)
            int rnd = r.Next(1, 4); //Cliente Empleado 
            int rnd1 = r.Next(1, 3); //TipoHospedaje  Categoria ServicioHospedaje
            int rnd2 = r.Next(0, 2); //ClasificacionHospedaje
            int rnd3 = r.Next(0, 1);
            int rnd4 = r.Next(0, 2);
            int rnd5 = r.Next(0, 3);
            int rnd6 = r.Next(0, 5);
            int rnd7 = r.Next(0, 2);
            int rnd8 = r.Next(0, 2);
            int rnd9 = r.Next(0, 2);
            int rnd10 = r.Next(0, 2);

            var central = new VentaPaquete();

            Console.WriteLine("------------Bienvenido al Servicio Turistico EL FINAL FELIZ -------------------");
            Console.WriteLine();
            central.AgregarNombre(rnd);
            central.AgregarEmpleado(rnd1);
            Console.WriteLine();
            central.AgregarMedioPago(rnd2);
            Console.WriteLine();
            Console.WriteLine("--> Comprobante de Pago: ");            
            central.AgregarComprobantePago(rnd3);
            Console.WriteLine();
            Console.WriteLine("--> Alimentación: ");           
            central.AgregarCategoriaAlimentacion(rnd4);
            Console.WriteLine();
            Console.WriteLine("--> Hospedaje: ");
            Console.WriteLine();
            central.AgregarTipoHospedaje(rnd5);
            central.AgregarClasificacionHospedaje(rnd6);
            central.AgregarCategoriaHospedaje(rnd7);
            central.AgregarServicioHospedaje(rnd8);
            Console.WriteLine();
            Console.WriteLine("--> Transporte: ");
            Console.WriteLine();
            central.AgregarTipoTransporte(rnd9);
            central.AgregarCategoriaTransporte(rnd10);
            Console.WriteLine();


        }
    }
}
