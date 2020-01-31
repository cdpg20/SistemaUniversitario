using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Websis
{
    public class Datos
    {
        string nombreDoc;
        string nombreCarr;
        private List<Docente> listaDocentes = new List<Docente>();

        public Datos(string nombreDoc, string nombreCarr)
        {
            this.nombreCarr = nombreCarr;
            this.nombreDoc = nombreDoc;
        }
    }
}
