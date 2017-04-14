using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010107281
{
    class Hospedaje : ServicioTuristico
    {
        private string _nomSerTur;
        private string _ruc;

        public Hospedaje(string numero) : base(numero)
        {
        }

        private TipoHospedaje _tipoHospedaje;
        private ClasificacionHospedaje _clasificacionHospedaje;
        private CategoriaHospedaje _categoriaHospedaje;
        private ServicioHospedaje _servicioHospedaje;
               
        public TipoHospedaje tipHos { get { return _tipoHospedaje; } }
        public ClasificacionHospedaje claHos { get { return _clasificacionHospedaje; } }
        public CategoriaHospedaje catHos { get { return _categoriaHospedaje; } }
        public ServicioHospedaje serHos { get { return _servicioHospedaje; } }
    }
}
