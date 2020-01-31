using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Websis
{
    public class Program
    {
        static void Main(string[] args)
            {
                int op;
                Console.WriteLine("BIENVENIDO A LA WEBSIS");
                Console.WriteLine("INGRESE EL NUMERO LA OPERACION QUE DESEA");
                Console.WriteLine("AGREGAR DOCENTE(1), AGREGAR CARRERA(2), AGREGAR ESTUDIANTE(3)");
                op = Int32.Parse(Console.ReadLine());
            if (op < 3 && op > 0)
            {
                switch (op)
                {
                    case 1:
                        {
                            Console.WriteLine("INGRESE NOMBRE DEL DOCENTE QUE DESEA AGREGAR");
                            string nombreDoc = Console.ReadLine();
                            Docente docente = new Docente(nombreDoc);
                            docente.registrarDoc(docente);
                            Console.WriteLine("LOS DOCENTES REGUISTRADOS HASTA EL MOMENTO SON:");
                            docente.getImprimirDocentes();
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("INGRESE EL NOMBRE DE LA CARRERA QUE DESEA AGREGAR");
                            string nombreCarr = Console.ReadLine();
                            Carrera carrera = new Carrera(nombreCarr);
                            carrera.registrarCarr(carrera);
                            Console.WriteLine("LAS CARRERAS REGISTRADAS HASTA EL MOMENTO SON:");
                            carrera.getImprimirCarreras();
                        }
                        break;
                    case 3:
                        {
                            //Console.WriteLine("INGRESE EL NOMBRE DEL ESTUDIANTE QUE DESEA AGREGAR");
                            //string matuniv = Console.ReadLine();
                            //Carrera Carrera = new Carrera(matuniv);
                            //Console.WriteLine("Las materias de la universidad son:");
                            //Carrera.getImprimirCarreras();
                        }
                        break;
                }
            }
            else
            {
                Console.WriteLine("El numero no es valido");
            }
            Console.ReadKey();
        }
    }
}
