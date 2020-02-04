using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Websis
{
    public class Carrera
    {
        private string nombre;
        private List<Materia> listaMaterias = new List<Materia>();
        private List<Estudiante> listaEstudiantes = new List<Estudiante>();
        private List<Docente> listaDocentes = new List<Docente>();

        public Carrera(string nombre)
        {
            this.nombre = nombre;
        }

        public String getNombre()
        {
            return nombre;
        }

        public void agregarMateria(Materia materia)
        {
            listaMaterias.Add(materia);
        }
        
        public List<Materia> getMaterias()
        {
            return listaMaterias;
        }

        public void agregarEstudiante(Estudiante estudiante)
        {
            listaEstudiantes.Add(estudiante);
        }
        public void agregarDocente(Docente docente)
        {
            listaDocentes.Add(docente);
        }

        public List<Estudiante> getEstudiantes()
        {
            return listaEstudiantes;
        }

        public List<Docente> getDocentes()
        {
            return listaDocentes;
        }
    }
}
