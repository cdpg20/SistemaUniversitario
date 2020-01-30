using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasEstudiante
{
    public class Docente : Persona
    {
        
        private string codigoDocente;
        private Materia materia;

        public Docente(string nombreDocente)
        {
            base.Name = nombreDocente;
           
        }


        public Docente(string name, string lastName, DateTime fechaNacimiento, int ci, char s)
        {
            base.Name = name;
            base.LastName = lastName;
            base.FechaNacimento = fechaNacimiento;
            base.CI = ci;
            this.codigoDocente = fechaNacimiento.Year.ToString() + fechaNacimiento.Month.ToString() + ci;
            base.S = s;
        }

        public string getNombreDocente()
        {
            return base.Name;
        }

        public string getCodigoDocente()
        {
            return codigoDocente;
        }


        public void SetMateria(Materia materia)
        {
            this.materia = materia;
            
        }

        public Materia getMateriaDocente()
        {
            return materia;
        }

    }
}
