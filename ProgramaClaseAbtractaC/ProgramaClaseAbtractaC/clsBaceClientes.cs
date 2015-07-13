using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaClaseAbtractaC
{
    public class clsBaceClientes : clsAbsClientes
    {
        public override int Id { get; set; }
        public override string Nombre { get; set;}
        public override string Clave { get; set; }
        public override string RFC { get; set; }
        public override int Tiporegimen { get; set; }
        public override string NombreContact { get; set; }

    }
}
