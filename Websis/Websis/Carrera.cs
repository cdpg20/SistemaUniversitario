using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Websis
{
    public class Carrera
    {
        string nombreCarr;
        private List<Carrera> listaCarerra = new List<Carrera>();

        public Carrera(string nombreCarr)
        {
            this.nombreCarr = nombreCarr;
        }

        public string getNombreCarrera()
        {
            return nombreCarr;
        }

        public void registrarCarr(Carrera nombreCarr)
        {
            listaCarerra.Add(nombreCarr);
        }


        public void getImprimirCarreras()
        {
            foreach (var nombrecarrera in listaCarerra)
            {
                Console.WriteLine(nombrecarrera.getNombreCarrera());
            }
        }
    }
}
