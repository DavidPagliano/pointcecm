using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
	public class HORARIO
	{
		public int ID_Horario { get; set; }
		public AÑO año { get; set; }
		public NIVEL Nivel { get; set; }
		public ICollection<GRADO> Grado { get; set; }
		public string Seccion { get; set; }
		public HORA Hora { get; set; }
		public ICollection<AMBIENTE> Ambientes { get; set; }
	}
}
