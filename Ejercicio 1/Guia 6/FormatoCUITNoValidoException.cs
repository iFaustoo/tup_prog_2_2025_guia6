using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_6
{
    public class FormatoCUITNoValidoException : ApplicationException
    {

        public FormatoCUITNoValidoException() : base("CUIT ingresado no valido")
        {

        }

        public FormatoCUITNoValidoException(string message) : base(message)
        {

        }

        public FormatoCUITNoValidoException(string message, Exception inner) : base(message, inner)
        {

        }

    }
}
