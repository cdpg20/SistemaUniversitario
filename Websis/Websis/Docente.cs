using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Websis
{
    public class Docente : Persona
    {
        private string codigoDocente;
        private List<Materia> listaMateriasDoc = new List<Materia>();

        public Docente(string nombre)
        {
            base.Nombre = nombre;
        }

        public Docente(string nombre, string apellido, DateTime fechaNacimiento, int ci, char s)
        {
            base.Nombre = nombre;
            base.Apellido = apellido;
            base.FechaNacimento = fechaNacimiento;
            base.CI = ci;
            this.codigoDocente = fechaNacimiento.Year.ToString() + fechaNacimiento.Month.ToString() + ci;
            base.S = s;
        }

        public List<Materia> getMateriasDocente()
        {
            return listaMateriasDoc;
        }

        public string getNombreDocente()
        {
            return base.Nombre;
        }

        public string getApellidoDocente()
        {
            return base.Apellido;
        }

        public string getNombreCompletoDocente()
        {
            return base.Nombre + base.Apellido;
        }

        public string getCodigoDocente()
        {
            return codigoDocente;
        }

        public void agregarMateriaDoc(Materia materia)
        {
            listaMateriasDoc.Add(materia);
        }

        public void getImprimirMateriaDocente()
        {
            foreach (var materiaDocente in listaMateriasDoc)
            {
                Console.WriteLine(materiaDocente.getNombre());
            }
        }
    }
}
