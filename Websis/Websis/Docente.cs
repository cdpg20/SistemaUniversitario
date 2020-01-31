using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Websis
{
    public class Docente
    {
        string nombreDoc;
        private List<Docente> listaDocentes = new List<Docente>();

        public Docente(string nombreDoc)
        {
            this.nombreDoc = nombreDoc;
        }

        public string getNombreDoc()
        {
            return nombreDoc;
        }

        public void registrarDoc(Docente nombreDoc)
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
    }
}
