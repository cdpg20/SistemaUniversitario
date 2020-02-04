using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Websis
{
    public class Universidad
    {
        string nombreUniversidad;
        private List<Carrera> listaCarreras = new List<Carrera>();

        public Universidad( string nombreUniversidad)
        {
            this.nombreUniversidad = nombreUniversidad;
        }

        public String getNombre()
        {
            return nombreUniversidad;
        }

        public void agregarCarrera(Carrera nombreCarr)
        {
            listaCarreras.Add(nombreCarr);
        }

        public void getImprimirCarreras()
        {
            foreach (var nombreCarrera in listaCarreras)
            {
                Console.WriteLine(nombreCarrera.getNombre());
            }
        }

    }
}
