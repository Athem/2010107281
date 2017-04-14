using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010107281
{
    public class VentaPaquete //central
    {        
        List<Paquete> _Paquete;
        List<MedioPago> _MedioPago;
        List<ComprobantePago> _ComprobantePago;
        List<ServicioTuristico> _ServicioTuristico;
        List<Cliente> _Cliente;
        List<Empleado> _Empleado;
        private Persona _Persona;
        public VentaPaquete()
        {
            _Paquete = new List<Paquete>();
            _MedioPago = new List<MedioPago>();
            _ComprobantePago = new List<ComprobantePago>();
            _ServicioTuristico = new List<ServicioTuristico>();
            _Cliente = new List<Cliente>();
            _Empleado = new List<Empleado>();
        } 
        public void AgregarNombre(String numero)
        {
            //if(_Paquete.Count == 10)
               //return;
        
            _Cliente.Add(new Cliente(numero.ToString()));
            _Empleado.Add(new Empleado(numero.ToString()));
            string _nomCli = _Persona.seleccionNombre(Convert.ToInt16(numero));
            string _nomEmp = _Persona.seleccionNombre(Convert.ToUInt16(numero));

            Console.WriteLine("Nombre del Cliente:" ,_nomCli);
            Console.WriteLine("Nombre del Empleado:", _nomEmp);

        }
        public void Agregar(string numero)
        {
            //if(_Paquete.Count == 10)
            //return;

            _ComprobantePago.Add(new ComprobantePago(numero));
            _MedioPago.Add(new MedioPago(numero));
            _ServicioTuristico.Add(new ServicioTuristico(numero));
            //_Paquete.Add(new Paquete(numero));
           

        }
        public void Eliminar(string numero)
        {
            _ComprobantePago.Remove(new ComprobantePago(numero));
            _MedioPago.Remove(new MedioPago(numero));
            _ServicioTuristico.Remove(new ServicioTuristico(numero));
            //_Paquete.Remove(new Paquete(numero));
            _Cliente.Remove(new Cliente(numero));
            _Empleado.Remove(new Empleado(numero));
        }
        public void RegistrarVenta(string numero)
        {
            Empleado _nomEmp = new Empleado(numero);
            Cliente _nomCli = new Cliente(numero);
            ComprobantePago _comPag = new ComprobantePago(numero);
            MedioPago _medPag = new MedioPago(numero);
            ServicioTuristico _serTur = new ServicioTuristico(numero);
            //Llamada _llamada = new Llamada(_fonoDestino);

        }

    }
}
