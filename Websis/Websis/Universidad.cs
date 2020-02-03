using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Websis
{
    public class Universidad
    {
        string nombreEst;
        string nombreDoc;
        string nombreCarr;
        private List<Universidad> listaCarrera = new List<Universidad>();
        private List<Universidad> listaEstudiante = new List<Universidad>();
        private List<Universidad> listaDocentes = new List<Universidad>();

        public Universidad(string nombreEst, string nombreDoc, string nombreCarr)
        {
            this.nombreEst = nombreEst;
            this.nombreDoc = nombreDoc;
            this.nombreCarr = nombreCarr;
        }

        public string getNombreEst()
        {
            return nombreEst;
        }

        public string getNombreDoc()
        {
            return nombreDoc;
        }

        public string getNombreCarr()
        {
            return nombreCarr;
        }

        public void registrarEst(Universidad nombreEst)
        {
            listaEstudiante.Add(nombreEst);
        }

        public void getImprimirEstudiantes()
        {
            foreach (var nombreEstudiante in listaEstudiante)
            {
                Console.WriteLine(nombreEstudiante.getNombreEst());
            }
        }

        public void registrarDoc(Universidad nombreDoc)
        {
            listaDocentes.Add(nombreDoc);
        }

        public void getImprimirDocentes()
        {
            foreach (var nombredocente in listaDocentes)
            {
                Console.WriteLine(nombredocente.getNombreDoc());
            }
        }

        public void registrarCarr(Universidad nombreCarr)
        {
            listaEstudiante.Add(nombreCarr);
        }

        public void getImprimirCarrera()
        {
            foreach (var nombreCarrera in listaCarrera)
            {
                Console.WriteLine(nombreCarrera.getNombreCarr());
            }
        }

    }
}
