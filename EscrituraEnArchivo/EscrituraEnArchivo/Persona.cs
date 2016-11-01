using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscrituraEnArchivo
{
    public class Persona
    {
        private string nombre;
        private string clave;

        public Persona(string nombre, string clave)
        {
            this.nombre = nombre;
            this.clave = clave;
        }

        public override string ToString()
        {
            return this.nombre + "," + this.clave;
        }
    }
}
