using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasEstudiante
{
    public class Materia
    {
        private int codigoMateria;
        private string nombreMateria;
        private int notasMateria;

        private Docente docente;


        public Materia(string nombreMateria)
        {
            this.nombreMateria = nombreMateria; 
        }

       

        public int getCodigoMateria()
        {
            return codigoMateria;
        }

        public string getNombreMateria()
        {
            return nombreMateria;
        }

        public int getNotasMateria()
        {
            return notasMateria;
        }

        public void SetDocente(Docente docente)
        {
            this.docente = docente;
            this.docente.SetMateria(this);
        }

        
    }
}
