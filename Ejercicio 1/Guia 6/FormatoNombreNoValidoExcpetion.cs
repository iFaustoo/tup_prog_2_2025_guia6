using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_6
{
    public class FormatoNombreNoValidoExcpetion : ApplicationException
    {

        public FormatoNombreNoValidoExcpetion() : base("Nombre ingresado no cumple con el formato")
        {

        }

        public FormatoNombreNoValidoExcpetion(string message) : base(message)
        {
            
        }


        public FormatoNombreNoValidoExcpetion(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
