using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasEstudiante
{
    class Program
    {
        static void Main(string[] args)
        {
            //carreraYMaterias();
            //alumnoYDocente();
            mostrarRoles();
        }
        public static void carreraYMaterias()
        {
            Console.WriteLine("Inserte Nombre de la Universidad a la que desea inscribirse:");
            string nombreUniversidad = Console.ReadLine();
            Universidades universidades = new Universidades(nombreUniversidad);

            int count = 0;
            do
            {
                count++;
                Console.WriteLine("Ingrese el Nombre de la Carrera que desea tomar: ");
                string nombreCarrera = Console.ReadLine();
                Carreras carrera = new Carreras(nombreCarrera);
                universidades.registrarCarrera(carrera);

            } while (count < 1);
            universidades.mostrarCarrera();

            int countM = 0;
            do
            {
                countM++;
                Console.WriteLine("Ingrese las materias que desea tomar:");
                string nombreMateria = Console.ReadLine();
                Materia materias = new Materia(nombreMateria);
                universidades.registrarMateria(materias);

            } while (countM < 2);
            universidades.mostrarMateria();
            universidades.eliminarMateria();
            universidades.mostrarMateria();

            Console.ReadKey();
        }
        public static void alumnoYDocente()
        {
            int a = 0;
            do
            {
                a++;
                Console.WriteLine("Inserte el nombre del estudiante que desea inscribir: ");
                Console.WriteLine("NOMBRE COMPLETO: ");
                string nombreEstudiante = Console.ReadLine();
                Universitario univesitario = new Universitario(nombreEstudiante);
                //Console.WriteLine("CODIGO: " + univesitario.getCodigoSanSimon());

                Console.WriteLine("El Universitario Inscrito es:" + nombreEstudiante);
               // Console.WriteLine("Con el codigo: " + univesitario.getCodigoSanSimon());

                Universidades universidades = new Universidades("");
                Console.WriteLine("Ingrese los nombres de los docente: ");
                int countD = 0;
                do
                {
                    countD++;
                    Console.WriteLine("NOMBRE DOCENTE:");
                    string nombreDocente = Console.ReadLine();
                    Docente docentes = new Docente(nombreDocente);

                } while (countD < 3);
            } while (a < 2);
           
            Console.ReadKey();

        }
        public static void mostrarRoles()
        {


            MenuSistema menuSistema = new MenuSistema();
            menuSistema.mostrarMenuPrincipal();
        }
        public static void mostrarAdmiDocenteUniversitario()
        {
            MenuSistema menuSistema = new MenuSistema();
            menuSistema.administrador();
        }

    }
}
