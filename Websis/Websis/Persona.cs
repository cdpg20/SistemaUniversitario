using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Websis
{
    public class Persona
    {

        private int ci;
        private char sex;

        public Persona(int ci, string nombre, string apellido, DateTime fechaNacimiento, char s)
        {
            this.ci = ci;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.FechaNacimento = fechaNacimiento;
            sex = s;
        }

        public Persona()
        { }

        public int CI
        {
            get
            {
                return ci;
            }
            set
            {
                ci = value;
            }
        }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public DateTime FechaNacimento { get; set; }

        public Char S;

    }
}
