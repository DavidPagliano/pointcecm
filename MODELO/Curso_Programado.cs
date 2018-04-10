using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
	public class Curso_Programado
	{
		public int ID_Curso_programado { get; set; }
		public AÑO Año { get; set; }
		public NIVEL Nivel { get; set; }
		public GRADO Grado { get; set; }
		public CURSO Curso { get; set; }
		public string Seccion { get; set; }
		public MAESTRO Docente { get; set; }
	}
}
