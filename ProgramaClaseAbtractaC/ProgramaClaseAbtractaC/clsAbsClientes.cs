using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaClaseAbtractaC
{
    public abstract class clsAbsClientes
    {
        public abstract int Id { get; set; }
        public abstract string Nombre { get; set; }
        public abstract string Clave { get; set; }
        public abstract string RFC { get; set; }
        public int string TipoRegimen { get; set; }
        public abstract string NombreContact { get; set; }

       

    }
}
