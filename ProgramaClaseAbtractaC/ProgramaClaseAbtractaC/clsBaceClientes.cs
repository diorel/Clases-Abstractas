using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaClaseAbtractaC
{
    public class clsBaceClientes : clsAbsClientes
    {

        public clsBaceClientes()
        {
            Id = 0;
            Nombre = string.Empty;
            Clave = string.Empty;
            RFC = string.Empty;
            TipoRegimen = 0;
            Nombrecontacto = string.Empty; 
        }

        public clsBaceClientes(int pId, string pNombre, string pClave, string pRFC, int pTipoRegimen, string pNombrecontacto)
        {
            Id = pId;
            Nombre = pNombre;
            Clave = pClave;
            RFC = pRFC;
            TipoRegimen = pTipoRegimen;
            Nombrecontacto = pNombrecontacto;
 
        }


        public override int Id { get; set; }
        public override string Nombre { get; set;}
        public override string Clave { get; set; }
        public override string RFC { get; set; }
        public override int TipoRegimen { get; set; }
        public override string Nombrecontacto { get; set; }

    }
}
