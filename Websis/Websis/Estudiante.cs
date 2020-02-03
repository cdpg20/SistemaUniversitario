using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Websis
{
    public class Estudiante
    {
        string matEst;
        private List<Estudiante> listaMateriasEst = new List<Estudiante>();

        public Estudiante(string matEst)
        {
            this.matEst = matEst;
        }

        public string getMateriaEst()
        {
            return matEst;
        }

        public void anadirMatEst(Estudiante MateriaEst)
        {
            listaMateriasEst.Add(MateriaEst);
        }
        public void getImprimirMateriaEstudiante()
        {
            foreach (var materiaEstudiante in listaMateriasEst)
            {
                Console.WriteLine(materiaEstudiante.getMateriaEst());
            }
        }
    }
}
