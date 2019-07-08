using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using capaEntidad;
using System.Data;

namespace capaNegocio
{
    public class NegEmpleados
    {
        DatEmpleados objdato = new DatEmpleados();
        public DataTable Listado()
        {
            return objdato.Listado();
        }

    }
}
