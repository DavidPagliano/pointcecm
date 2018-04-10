using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
	public class GRADO
	{
		public int ID_Grado { get; set; }
		public NIVEL Nivel { get; set; }
		public GRADO Grado { get; set; }
	}
}
