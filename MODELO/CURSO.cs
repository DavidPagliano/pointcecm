using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
	public class CURSO
	{
		public int ID_Curso { get; set; }
		public AÑO Año { get; set; }
		public NIVEL Nivel { get; set; }
		public GRADO Grado { get; set; }
		public CURSO Curso { get; set; }
		public string Descripcion { get; set; }
		public decimal Horas_teoricas { get; set; }
		public decimal Horas_practicas { get; set; }

	}
}
