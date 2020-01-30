using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasEstudiante
{
    class Universidades
    {
        private string nombreUniversidad;
        private string docenteUniversidad;
        private string alumnosUniversidad;
        private string carrerasUniversidad;
        private List<Carreras> listaCarerras = new List<Carreras>();
        private List<Materia> listaMaterias = new List<Materia>();
        private List<Docente> listaDocentes = new List<Docente>();
        private List<Universitario> listUniversitarios = new List<Universitario>();

        public void Universidad(string nombreUniversidad, string docenteUniversidad, string alumnoUniversidad, string carreraUniversidad)
        {
            this.nombreUniversidad = nombreUniversidad;
            this.docenteUniversidad = docenteUniversidad;
            this.alumnosUniversidad = alumnoUniversidad;
            this.carrerasUniversidad = carreraUniversidad;
        }
        public void registrarDocente(Docente docentes)
        {
            listaDocentes.Add(docentes);
        }
        public void registrarMateria(Materia materias)
        {
            listaMaterias.Add(materias);
        }

        public void RegistrarUniversitario(Universitario universitario)
        {
            listUniversitarios.Add(universitario);
        }


        public List<Materia> GetMaterias()
        {
            return listaMaterias;
        }

        public void mostrarMateria()
        {
            Console.WriteLine("Las Materias Elegidas son...");
            foreach (var item in listaMaterias)
            {
                Console.WriteLine("   * " + item.getNombreMateria());
            }
        }
        public void eliminarMateria()
        {
            Console.WriteLine("Escriba la Materia que desea eliminar: ");
            string materiaEliminar = Console.ReadLine();
            List<Materia> auxMaterias = new List<Materia>();
            foreach (var item in listaMaterias)
            {
                auxMaterias.Add(item);
            }

            foreach (var item in auxMaterias)
            {
                if (item.getNombreMateria() == materiaEliminar)
                {
                    listaMaterias.Remove(item);
                }
                
            }
            
        }
       
        public void registrarCarrera(Carreras carrera)
        {
            listaCarerras.Add(carrera);
        }
        public void mostrarCarrera()
        {
            Console.WriteLine("La Carrera elegida es: ");
            foreach (var item in listaCarerras)
            {
                Console.WriteLine(item.getNombreCarerra());

            }
        }
        
        public Universidades(string nombreUniversidad)
        {
            this.nombreUniversidad = nombreUniversidad;
        }
        public string getNombreUniversidad()
        {
            return nombreUniversidad;
        }

        public string getDocenteUniversidad()
        {
            return docenteUniversidad;
        }

        public string getAlumnoUnivesirdad()
        {
            return alumnosUniversidad;
        }

        public string getCarreraUniversidad()
        {
            return carrerasUniversidad;
        }

        public List<Docente> GetDocentes()
        {
            return listaDocentes;
        }


        public List<Universitario> GetUniversitarios()
        {
            return listUniversitarios;
        }

    }
}
