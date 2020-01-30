using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasEstudiante
{
    class Carreras
    {
        private string nombreCarrera;
        private int codigoCarrera;
        private string materiaCarrera;
        private List<Materia> listaMaterias = new List<Materia>();
        public Carreras(string nombreCarrera)
        {
            this.nombreCarrera = nombreCarrera;
        }
        public void registrarMateria(Materia materias)
        {
            listaMaterias.Add(materias);
        }

        
        

        public void Carrera(string nombreCarrera, int codigoCarrera, string materiaCarrera, string alumnoRegistradoCarrera, string registrarDocenteCarrera)
        {
            this.nombreCarrera = nombreCarrera;
            this.codigoCarrera = codigoCarrera;
            this.materiaCarrera = materiaCarrera;
            
        }
        public string getNombreCarerra()
        {
            return nombreCarrera;
        }

        public int getCodigoCarrera()
        {
            return codigoCarrera;
        }

        public string getMateriaCarrera()
        {
            return materiaCarrera;
        }

        

       
    }
}
