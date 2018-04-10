using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
	public class SERVICIO
	{
		public int Id_Servicio { get; set; }
		public string Descripcion { get; set; }
		public decimal Monto { get; set; }
		public bool Activo { get; set; }
	}
}
