using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Npgsql;
using TRCAplicacion.Models;

namespace TRCAplicacion.Controllers.CompraProveedor
{
    internal class CompraProveedorController
    {
        ConexionModel conex = null;
        CompraProveedorC objCompraProveedor = null;
        System.Data.DataTable dt = null;

        public CompraProveedorController(CompraProveedorC parObjCompraProveedor)
        {
            objCompraProveedor = parObjCompraProveedor;
        }





    }
}
