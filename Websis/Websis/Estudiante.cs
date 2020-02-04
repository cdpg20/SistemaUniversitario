using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Websis
{
    public class Estudiante : Persona
    {
        string codigoEstudiante;
        private List<Materia> listaMateriasEst = new List<Materia>();

        public Estudiante(string nombre)
        {
            base.Nombre = nombre;
        }

        public Estudiante(string nombre, string apellido, int ci, DateTime fechaNacimiento, char s)
        {
            base.Nombre = nombre;
            base.Apellido = apellido;
            base.CI = ci;
            base.FechaNacimento = fechaNacimiento;
            base.S = s;
            codigoEstudiante = fechaNacimiento.Year.ToString() + fechaNacimiento.Month.ToString() + ci;
        }

        public List<Materia> getMateriaEstudiantes()
        {
            return listaMateriasEst;
        }

        public string getCodigoEstudiante()
        {
            return codigoEstudiante;
        }

        public string getNombreEstudiante()
        {
            return base.Nombre;
        }
        public string getApellidoEstudiante()
        {
            return base.Apellido;
        }

        public string getNombreCompletoEstudiante()
        {
            return base.Nombre + base.Apellido;
        }

        public void anadirMatEst(Materia materia)
        {
            listaMateriasEst.Add(materia);
        }

        public void getImprimirMateriaEstudiante()
        {
            foreach (var materiaEstudiante in listaMateriasEst)
            {
                Console.WriteLine(materiaEstudiante.getNombre());
            }
        }
    }
}
