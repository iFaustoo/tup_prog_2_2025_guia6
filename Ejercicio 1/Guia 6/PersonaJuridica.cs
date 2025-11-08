using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_6
{
    internal class PersonaJuridica : Persona
    {

        string cuit;


        public PersonaJuridica(string nombre, string cuit) : base(nombre)
        {
            this.cuit = cuit;
            if (ValidarCUIT() == false)
            {
                throw new FormatoCUITNoValidoException();
            }
        }

        public override string ToString()
        {
            return $"Nombre: {nombre} - CUIT: {cuit}";
        }

        protected bool ValidarCUIT()
        {
            int[] p = { 5, 4, 3, 2, 7, 6, 5, 4, 3, 2 };
            bool esValido = cuit.Length == 11;
            int n = 0;
            int acum = 0;
            while (n < 10 && esValido)
            {
                esValido &= char.IsNumber(cuit[n]);
                if (esValido)
                {
                    acum += (int)char.GetNumericValue(cuit[n]) * p[n];
                }
                n++;
            }

            if (esValido == true)
            {
                int dv = 0;
                int mod = acum % 11;
                if (mod == 0) dv = 0;
                else if (mod == 1) dv = 1;
                else { dv = 11 - mod; }

                esValido &= dv == (int)char.GetNumericValue(cuit[10]);
            }
            return esValido;
        }
    }
}
