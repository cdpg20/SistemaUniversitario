using System;


namespace Websis
{
    public class MenuDocente
    {
        public void CrearDocente()
        {
            int op;
            do
            {
                Console.WriteLine("Ingrese su Nombre:");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese su Apellido:");
                string apellido = Console.ReadLine();
                Console.WriteLine("Ingrese su C.I.:");
                int ci = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese su Fecha de Nacimiento:");
                DateTime fechaNacimiento = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Ingresar Sexo");
                char sex = Console.ReadLine()[0];
                Docente docente = new Docente(nombre, apellido, fechaNacimiento, ci, sex);
                Console.WriteLine("BIENVENIDO" + docente.getNombreCompletoDocente());
                Console.WriteLine("INGRESE LA OPCION QUE DESEA REALIZAR:");
                Console.WriteLine("INSCRIBIRSE A UNA MATERIA(1), RETIRAR UNA MATERIA(2), VER MATERIAS INSCRITAS(3), VER HORARIO(4)");
                op = Int32.Parse(Console.ReadLine());
                if (op < 5 && op > 0)
                {
                    switch (op)
                    {
                        case 1:
                            {
                                Console.WriteLine("Ingrese la materia a la que desa inscribirse:");
                                string materia = Console.ReadLine();
                                Materia mat = new Materia(materia);
                            }
                            break;
                    }
                    break;

                }
            }
            while (op < 5 && op > 0);
            Console.ReadKey();
        }
    }
}
