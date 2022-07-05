using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRCAplicacion.Controllers.PuntoReunion
{
    internal class MunicipioC
    {
        private string municipio;
        private string departamento;

        public string Municipio { get => municipio; set => municipio = value; }
        public string Departamento { get => departamento; set => departamento = value; }
    }
}
