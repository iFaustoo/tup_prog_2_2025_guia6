using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Guia_6
{
    public class Persona
    {

        protected string nombre;

        public string Nombre
        {
            get { return nombre; }

            set
            {
                Match match = Regex.Match(value, @"^\s*(?<apellido>[\p{L}\s]{2,}?),\s*(?<nombres>[\p{L}\s]{2,})\s*$");
                if (match.Success == false)
                {
                    throw new FormatoNombreNoValidoExcpetion();
                }
                nombre = value;
            }
        }
        

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        public override string ToString()
        {
            return $"{nombre}";
        }

        public int CompareTo(Persona? other)
        {
            if (other != null)
                return nombre.CompareTo(other.nombre);
            return -1;
        }

    }
}
