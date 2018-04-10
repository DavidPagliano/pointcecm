using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
	public class MATRICULA
	{
		public int ID_Matricula { get; set; }
		public AÑO Año { get; set; }
		public USUARIO Usuario { get; set; }
		public NIVEL Nivel { get; set; }
		public GRADO Grado { get; set; }
	}
}
