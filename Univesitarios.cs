using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasEstudiante
{
    public class Universitario : Persona
    {
               
        private string codigoEstudiante;
       

        public Universitario(string nombreUniversitario)
        {
            base.Name = nombreUniversitario;
            
            //Universitario.codigoEstudiante++;
            //this.codigoEstudianteSanSimo = this.codigoEstudianteSanSimo + Universitario.codigoEstudiante;
        }

        public Universitario(string nombre, string apellido, int ci, DateTime fechaNacimiento, char s)
        {
            base.Name = nombre;
            base.LastName = apellido;
            base.CI = ci;
            base.FechaNacimento = fechaNacimiento;
            base.S = s;
            codigoEstudiante = fechaNacimiento.Year.ToString() + fechaNacimiento.Month.ToString() + ci;
        }
         
        //public string getNombreUniversitario()
        //{
        //    Console.WriteLine("Inserte el Nombre del estudiante a inscribirse:");
        //    string nombreEstudiante = Console.ReadLine();
           
        //}

        public string getCodigoUniversitario()
        {
            return codigoEstudiante;
        }

        //public string getCarreraUniversitario()
        //{
        //    Console.WriteLine("Elija la carrera a la que desea inscribir al estudiante:");
        //    Console.WriteLine("1. Ing. Sistemas     2. Ing. Civil     3. Derecho ");
        //    char caracter = Console.ReadLine()[0]; 
        //    if (caracter == '1')
        //    {

        //    }
        //    return carreraUniversitario;
        //}
    
    }
}
