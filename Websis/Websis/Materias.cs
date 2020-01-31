using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Websis
{
    class Materia
    {
        string matuniv;
        string matdoc;
        private List<Materia> listaMateriasUniv = new List<Materia>();
        private List<Materia> listaMateriasDoc = new List<Materia>();
        public Materia(string matuniv, string matdoc)
        {
            this.matuniv = matuniv;
            this.matdoc = matdoc;
        }

        public void registrarMateriaUniv(Materia matu)
        {
            listaMateriasUniv.Add(matu);
        }

        public void registrarMateriaDoc(Materia matd)
        {
            listaMateriasDoc.Add(matd);
        }

    }
}
