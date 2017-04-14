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
        private Persona persona= new Persona();
        private MedioPago medioPag = new MedioPago();
        private ComprobantePago compPag = new ComprobantePago();
        private TipoComprobante tipo = new TipoComprobante();
        private CategoriaAlimentacion catAlimento = new CategoriaAlimentacion();
        private TipoHospedaje tipHos = new TipoHospedaje();
        private ClasificacionHospedaje claHos = new ClasificacionHospedaje();
        private CategoriaHospedaje catHospe = new CategoriaHospedaje();
        private ServicioHospedaje SerHospe = new ServicioHospedaje();
        private TipoTransporte tipTrans = new TipoTransporte();
        private CategoriaTransporte catTrans = new CategoriaTransporte();


        public VentaPaquete()
        {
            _Paquete = new List<Paquete>();
            _MedioPago = new List<MedioPago>();
            _ComprobantePago = new List<ComprobantePago>();
            _ServicioTuristico = new List<ServicioTuristico>();
            _Cliente = new List<Cliente>();
            _Empleado = new List<Empleado>();
        }

       
        public void AgregarNombre(int numero)
        {        

            string nomCli = persona.seleccionNombre(numero);
            Console.WriteLine("Nombre del Cliente: "+ nomCli);
        }

        public void AgregarEmpleado(int numero)
        {           

            string nomEmp = persona.seleccionNombre(numero);
            Console.WriteLine("Nombre del Empleado: " + nomEmp);
        }

        public void AgregarComprobantePago(int numero)
        {

            string comptipPago = tipo.seleccionTipoComprobante(numero);
            Console.WriteLine("Tipo de Comprobante de Pago: " + comptipPago);
        }

        public void AgregarMedioPago(int numero)
        {           

            string medPag = medioPag.seleccionMedioPago(numero);
            Console.WriteLine("--> Medio de Pago: " + medPag);
        }
        
              
        public void AgregarCategoriaAlimentacion(int numero)
        {
            
            string catAli = catAlimento.seleccionCategoriaAlimentacion(numero);
            Console.WriteLine("Categoria de Alimentación: " + catAli);
              
        }

        public void AgregarTipoHospedaje(int numero)
        {

            string tipoHops = tipHos.seleccionTipoHospedaje(numero);
            Console.WriteLine("Tipo de Hospedaje: " + tipoHops);

        }

        public void AgregarClasificacionHospedaje(int numero)
        {

            string clasHospedaje = claHos.seleccionClasificacionHospedaje(numero);
            Console.WriteLine("Clasificación del Hospedaje: " + clasHospedaje);

        }

        public void AgregarCategoriaHospedaje(int numero)
        {

            string categoriaHosp = catHospe.seleccionCategoriaHospedaje(numero);
            Console.WriteLine("Categoria del Hospedaje: " + categoriaHosp);

        }

        public void AgregarServicioHospedaje(int numero)
        {

            string servicioHosp = SerHospe.seleccionServicioHospedaje(numero);
            Console.WriteLine("Servicio del Hospedaje: " + servicioHosp);

        }

        public void AgregarTipoTransporte(int numero)
        {

            string tipoTrans = tipTrans.seleccionTipoTransporte(numero);
            Console.WriteLine("Tipo de Transporte: " + tipoTrans);

        }

        public void AgregarCategoriaTransporte(int numero)
        {

            string categoriaTrans = catTrans.seleccionCategoriaTransporte(numero);
            Console.WriteLine("Servicio del Hospedaje: " + categoriaTrans);

        }
       

        // public void RegistrarVenta(string numero)
        // {
        // ComprobantePago _comPag = new ComprobantePago(numero);
        // MedioPago _medPag = new MedioPago(numero);
        //ServicioTuristico _serTur = new ServicioTuristico(numero);
        //Console.WriteLine("Tipo de Pago: ", _comPag);
        // Console.WriteLine("Medio de Pago: ", _medPag);
        // Console.WriteLine("Tipo de Hospedaje: ", _medPag);
        // Console.WriteLine("Clasificación de Hospedaje: ", _medPag);
        // Console.WriteLine("Categoria de Hospedaje: ", _medPag);
        //Console.WriteLine("Servicio de Hospedaje: ", _medPag);

        //Llamada _llamada = new Llamada(_fonoDestino);

        //}


    }
}
