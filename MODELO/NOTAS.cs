using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
	public class NOTAS
	{   public int ID_Notas { get; set; }
        public ICollection<ALUMNO> Alumnos { get; set; } 
		public NIVEL Nivel { get; set; }
		public GRADO Grado { get; set; }
		public CURSO Curso { get; set; }
		public string Seccion { get; set; }
		public ICollection<MAESTRO> Docentes { get; set; }
		public int p1 { get; set; }
		public int p2 { get; set; }
		public int p3 { get; set; }
		public int p4 { get; set; }
		public int p5 { get; set; }
		public int p6 { get; set; }
		public int p7 { get; set; }
		public int p8 { get; set; }
		public int p9 { get; set; }
		public int p10 { get; set; }
	}
}
