﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRCAplicacion.Controllers.PuntoReunion
{
    internal class MunicipioC
    {
        private string pais;
        private string departamento;
        private string municipio;

        public string Pais { get => pais; set => pais = value; }
        public string Departamento { get => departamento; set => departamento = value; }
        public string Municipio { get => municipio; set => municipio = value; }
    }
}
