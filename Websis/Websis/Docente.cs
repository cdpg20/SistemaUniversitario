using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Websis
{
    public class Docente
    {
        string matDoc;
        private List<Docente> listaMateriasDoc = new List<Docente>();

        public Docente(string matDoc)
        {
            this.matDoc = matDoc;
        }

        public string getMateriaDoc()
        {
            return matDoc;
        }

        public void anadirMatDoc(Docente MateriaDoc)
        {
            listaMateriasDoc.Add(MateriaDoc);
        }
        public void getImprimirMateriaDocente()
        {
            foreach (var materiaDocente in listaMateriasDoc)
            {
                Console.WriteLine(materiaDocente.getMateriaDoc());
            }
        }
    }
}
