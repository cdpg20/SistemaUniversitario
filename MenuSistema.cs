using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasEstudiante
{
    class MenuSistema
    {
        private Universidades umss;
        public MenuSistema()
        {
            umss = new Universidades("San Simon");
            
        }
        public void mostrarMenuPrincipal()
        {


            while (true)
            {
                Console.WriteLine("<--MENU SISTEMA-->");
                Console.WriteLine("Selecciones el Rol con el que desa ingresar:");
                Console.WriteLine("(Inserte el numero del rol que desee)");
                Console.WriteLine(" 1. Rector o Decano");
                Console.WriteLine(" 2. Docente");
                Console.WriteLine(" 3. Universitario");
                int rol = int.Parse(Console.ReadLine());

                switch (rol)
                {
                    case 1:
                        Console.WriteLine(" 1.Crear Carrera");
                        Console.WriteLine(" 2.Crear Materia");
                        Console.WriteLine(" 3.Crear Docente");
                        Console.WriteLine(" 4.Crear Universitario");
                        Console.WriteLine("(Inserte el numero de la opcion que desee)");
                        int optionAdmin = int.Parse(Console.ReadLine());
                        CreateOptionAdmin(optionAdmin);

                        break;
                    case 2:
                        Console.WriteLine(" 1.Selecciona Materia");
                        Console.WriteLine(" 2.Deseleccionar materia");
                        Console.WriteLine(" 3.Horario.");
                        Console.WriteLine("(Inserte el numero de la opcion que desee)");

                        break;

                    case 3:
                        Console.WriteLine(" 1.Tomar Materia. \n 2.Ver Horario. \n 3.Abandonar Materia.");
                        Console.WriteLine();
                        Console.WriteLine("Selecciona una opcion...");
                        break;
                    default:
                        Console.WriteLine("No existe esa opcion");
                        Console.WriteLine();
                        Console.WriteLine("Selecciona una opcion...");
                        break;
                }

                
            }
                     
        }

        private void CreateOptionAdmin(int optionAdmin)
        {
            switch (optionAdmin)
            {
                case 1:
                    {
                        CreateCarrera();
                    }
                    break;
                case 2:
                    {
                        CreateMateria();
                    }
                break;
                case 3:
                    {
                        CreateDocente();
                    }
                    break;
                case 4:
                    {
                        CreateUniversitario();
                    }
                    break;
                default:
                    {
                       
                    }
                    break;
            }
        }

        private void CreateDocente()
        {
            Console.WriteLine("Ingresar nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingresar Apellido");
            string apellido = Console.ReadLine();
            Console.WriteLine("Ingresar CI");
            int ci = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar fecha Nacimiento");
            DateTime fechaNacimiento =  DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar Sexo");
            char sex = Console.ReadLine()[0];
            
            Docente docente = new Docente(nombre, apellido, fechaNacimiento, ci, sex);
            umss.registrarDocente(docente);
            
            

        }


        private void CreateUniversitario()
        {
            Console.WriteLine("Ingresar nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingresar Apellido");
            string apellido = Console.ReadLine();
            Console.WriteLine("Ingresar CI");
            int ci = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar fecha Nacimiento");
            DateTime fechaNacimiento = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar Sexo");
            char sex = Console.ReadLine()[0];

            bool DonotExit = true;
            while (true)
            {
                foreach (var estudiante in umss.GetUniversitarios())
                {
                    if (estudiante.CI.Equals(ci))
                    {
                        
                        Console.WriteLine($"el Ci={ci} esta uso por el estudiante={estudiante.Name}");
                        Console.WriteLine("Ingresar Nuevo CI");
                        ci = int.Parse(Console.ReadLine());
                        DonotExit = false;
                    }
                }

                if (DonotExit)
                {
                    break;
                }

            }

            Universitario universitario = new Universitario(nombre, apellido,ci, fechaNacimiento, sex);
            umss.RegistrarUniversitario(universitario);
        }

        public void CreateCarrera()
        {
            Console.WriteLine("Ingresar el Nombre de la carrera");
            string name = Console.ReadLine();
            Carreras carrera = new Carreras(name);
            umss.registrarCarrera(carrera);


        }

        public void CreateMateria()
        {
            Console.WriteLine("Inserta nombre de materia");
            string name = Console.ReadLine();
            Materia materia = new Materia(name);
            umss.registrarMateria(materia);
        }

        public void administrador()
        {
            Console.WriteLine("    << CREAR CARRERA >>");
            Console.WriteLine("Nombre Carrera: ");
            string nombreCarrera = Console.ReadLine();
            Console.WriteLine("    ** CREAR MATERIA **");
            Console.WriteLine("Nombre Materia: ");
            string nombreMateria = Console.ReadLine();
            Console.WriteLine("    ## CREAR DOCENTE ##");
            Console.WriteLine("Nombre Docente: ");
            string nombreDocente = Console.ReadLine();
            Console.ReadKey();
        }
        public void docente()
        {
            Console.WriteLine("    << SELECCIONAR MATERIA >>");
            Console.WriteLine("Nombre Materia: ");
            string nombreMateria = Console.ReadLine();
            Console.WriteLine("    << DESHACER MATERIA >>");
            Console.WriteLine("Nombre Materia: ");
            string nombreMateriaDeshacer = Console.ReadLine();
            Console.WriteLine("    << HORARIO >>");
            Console.WriteLine("Horario: ");
            string horario = Console.ReadLine();
            Console.ReadKey();
        }
        public void universitario()
        {
            Console.WriteLine("    << TOMAR MATERIA >>");
            Console.WriteLine("Nombre Materia: ");
            string tomarMateria = Console.ReadLine();
            Console.WriteLine("    << VER HORARIO >>");
            Console.WriteLine("Horario: ");
            string verHorario = Console.ReadLine();
            Console.WriteLine("    << ABANDONAR MATERIA >>");
            Console.WriteLine("Nombre de Materia para abandonar: ");
            string materiaAbandonar = Console.ReadLine();
            Console.ReadKey();
        }


        public void AsignarMateriaAdocente()
        {
            int i = 0;
            foreach (var docente in umss.GetDocentes())
            {
                Console.WriteLine($"{i} --Nombre={docente.Name}, ci={docente.CI}");
                i++;
            }
            Console.WriteLine("Selecionar Docente");
            int readDocenteOption =  int.Parse(Console.ReadLine());
            Docente docenteSelecionado = umss.GetDocentes().ElementAt(readDocenteOption);

            int j = 0;
            foreach (var materia in umss.GetMaterias())
            {
                Console.WriteLine($"{i} --Nombre={materia.getNombreMateria()}");
                j++;
            }
            Materia materiaSeleccionada = umss.GetMaterias().ElementAt(j);

            materiaSeleccionada.SetDocente(docenteSelecionado);

        }
        
    }
}
