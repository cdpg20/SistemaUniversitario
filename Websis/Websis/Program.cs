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
        int opAd;
        int opDoc;
        int opEst;
        int rol;
        int x;
        int n;
        x = 1;
        n = 100;


            while (x<n)
            {
                Console.WriteLine("BIENVENIDO A LA WEBSIS");
                Console.WriteLine("INGRESE EL NUMERO DEL ROL CON EL QUE DESEA INGRESAR:");
                Console.WriteLine("INGRESAR COMO ADMINISTRADOR(1), INGRESAR COMO DOCENTE(2), INGRESAR COMO ESTUDIANTE(3)");
                rol = Int32.Parse(Console.ReadLine());
                if (rol < 4 && rol > 0)
                {
                    switch (rol)
                    {
                        case 1:
                            Console.WriteLine("AGREGAR DOCENTE(1), AGREGAR CARRERA(2), AGREGAR ESTUDIANTE(3)");
                            opAd = Int32.Parse(Console.ReadLine());
                            if (opAd < 4 && opAd > 0)
                            {
                                switch (opAd)
                                {
                                    case 1:
                                        {
                                            Console.WriteLine("INGRESE NOMBRE DEL DOCENTE QUE DESEA AGREGAR");
                                            string nombreDoc = Console.ReadLine();
                                            Universidad docente = new Universidad(nombreDoc);
                                            docente.registrarDoc(docente);
                                            Console.WriteLine("LOS DOCENTES REGUISTRADOS HASTA EL MOMENTO SON:");
                                            docente.getImprimirDocentes();
                                        }
                                        break;
                                    case 2:
                                        {
                                            Console.WriteLine("INGRESE EL NOMBRE DE LA CARRERA QUE DESEA AGREGAR");
                                            string nombreCarr = Console.ReadLine();
                                            Universidad nombreCarrera = new Universidad(nombreCarr);
                                            nombreCarrera.registrarCarr(nombreCarrera);
                                            Console.WriteLine("LAS CARRERAS REGISTRADAS HASTA EL MOMENTO SON:");
                                            nombreCarrera.getImprimirCarrera();
                                        }
                                        break;
                                    case 3:
                                        {
                                            Console.WriteLine("INGRESE NOMBRE DEL ESTUDIANTE QUE DESEA AGREGAR");
                                            string nombreEst = Console.ReadLine();
                                            Universidad nombreEstudiante = new Universidad(nombreEst);
                                            nombreEstudiante.registrarEst(nombreEstudiante);
                                            Console.WriteLine("LOS ESTUDIANTES REGUISTRADOS HASTA EL MOMENTO SON:");
                                            nombreEstudiante.getImprimirEstudiantes();
                                        }
                                        break;
                                }
                                break;
                            }
                            else
                            {
                                Console.WriteLine("El numero no es valido");
                            }
                            break;
                        case 2:
                            Console.WriteLine("INSCRIBIRSE A UNA MATERIA (1), RETIRAR UNA MATERIA(2), AGREGAR NOTAS DE ESTUDIANTE(3)");
                            opDoc = Int32.Parse(Console.ReadLine());
                            if (opDoc < 4 && opDoc > 0)
                            {
                                switch (opDoc)
                                {
                                    case 1:
                                        {
                                            Console.WriteLine("INGRESE NOMBRE DE LA MATERIA A LA QUE DESEA REGISTRARSE");
                                            string matDoc = Console.ReadLine();
                                            Docente MateriaDoc = new Docente(matDoc);
                                            MateriaDoc.anadirMatDoc(MateriaDoc);
                                            Console.WriteLine("USTED ESTA REGISTRADO EN LAS SIGUIENTES MATERIAS:");
                                            MateriaDoc.getImprimirMateriaDocente();
                                        }
                                        break;
                                    case 2:
                                        {
                                            Console.WriteLine("INGRESE EL NOMBRE DE LA MATERIA QUE QUIERE RETIRAR");
                                            string retMatDoc = Console.ReadLine();
                                            Docente retMateriaDoc = new Docente(retMatDoc);
                                            retMateriaDoc.anadirMatDoc(retMateriaDoc); //ELIMINAR MATERIAS
                                            Console.WriteLine("USTED ESTA REGISTRADO EN LAS SIGUIENTES MATERIAS:");
                                            retMateriaDoc.getImprimirMateriaDocente();
                                        }
                                        break;
                                    case 3:
                                        {
                                            //Console.WriteLine("INGRESE LA MATERIA DE LA QUE DESEE VER SUS NOTAS:");
                                            //string nombreEst = Console.ReadLine();
                                            //Estudiante estudiante = new Estudiante(nombreEst);
                                            //estudiante.registrarEst(estudiante);
                                            //Console.WriteLine("LAS NOTAS DE LA MATERIA SON:");
                                            //estudiante.getImprimirEstudiantes();
                                        }
                                        break;
                                }
                                break;
                            }
                            else
                            {
                                Console.WriteLine("El numero no es valido");
                            }
                            break;
                        case 3:
                            Console.WriteLine("INSCRIBIRSE A UNA MATERIA (1), RETIRAR UNA MATERIA(2), VER NOTAS(3)");
                            opDoc = Int32.Parse(Console.ReadLine());
                            if (opDoc < 4 && opDoc > 0)
                            {
                                switch (opDoc)
                                {
                                    case 1:
                                        {
                                            Console.WriteLine("INGRESE NOMBRE DE LA MATERIA A LA QUE DESEA REGISTRARSE");
                                            string matDoc = Console.ReadLine();
                                            Docente MateriaDoc = new Docente(matDoc);
                                            MateriaDoc.anadirMatDoc(MateriaDoc);
                                            Console.WriteLine("USTED ESTA REGISTRADO EN LAS SIGUIENTES MATERIAS:");
                                            MateriaDoc.getImprimirMateriaDocente();
                                        }
                                        break;
                                    case 2:
                                        {
                                            Console.WriteLine("INGRESE EL NOMBRE DE LA MATERIA QUE QUIERE RETIRAR");
                                            string retMatDoc = Console.ReadLine();
                                            Docente retMateriaDoc = new Docente(retMatDoc);
                                            retMateriaDoc.anadirMatDoc(retMateriaDoc); //ELIMINAR MATERIAS
                                            Console.WriteLine("USTED ESTA REGISTRADO EN LAS SIGUIENTES MATERIAS:");
                                            retMateriaDoc.getImprimirMateriaDocente();
                                        }
                                        break;
                                    case 3:
                                        {
                                            //Console.WriteLine("INGRESE LA MATERIA DE LA QUE DESEE VER SUS NOTAS:");
                                            //string nombreEst = Console.ReadLine();
                                            //Estudiante estudiante = new Estudiante(nombreEst);
                                            //estudiante.registrarEst(estudiante);
                                            //Console.WriteLine("LAS NOTAS DE LA MATERIA SON:");
                                            //estudiante.getImprimirEstudiantes();
                                        }
                                        break;
                                }
                                break;
                            }
                            else
                            {
                                Console.WriteLine("El numero no es valido");
                            }
                            break;
                    }
                else
                {
                Console.WriteLine("El numero no es valido");
                }
                Console.ReadKey();
                }
        }
        }
    }
}
