using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Websis
{
    public class Materia
    {
        private string nombre;
        private List<Docente> listaDocentes = new List<Docente>();
        private List<Estudiante> listaEstudiantes = new List<Estudiante>();

        public Materia(string nombre)
        {
            this.nombre = nombre;
        }

        public void agregarDocente (Docente docente)
        {
            listaDocentes.Add(docente);
        }

        public void agregarEstudiante(Estudiante estudiante)
        {
            listaEstudiantes.Add(estudiante);
        }

        public List<Docente> getDocentes()
        {
            return listaDocentes;
        }

        public List<Estudiante> getEstudiantes()
        {
            return listaEstudiantes;
        }

        public String getNombre() 
        {
            return nombre;
        }
        
        public void getImprimirDocentesAsignados()
        {
            foreach (var nombredocente in listaDocentes)
            {
                Console.WriteLine(nombredocente.getNombreDocente());
            }
        }
        public void getImprimirAlumnosInscritos()
        {
            foreach (var nombreEstudiante in listaEstudiantes)
            {
                Console.WriteLine(nombreEstudiante.getNombreEstudiante());
            }
        }
    }
}
