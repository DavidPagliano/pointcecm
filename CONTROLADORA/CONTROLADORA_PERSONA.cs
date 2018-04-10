using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
	public class CONTROLADORA_PERSONA
	{
		private static CONTROLADORA_PERSONA instancia;
		public static CONTROLADORA_PERSONA Obtener_instancia()
		{
			if (instancia == null)
			{
				instancia = new CONTROLADORA_PERSONA();
			}
			return instancia;
		}

		DATOS.ESCUELA escuela;

		public CONTROLADORA_PERSONA()
		{
			escuela = new DATOS.ESCUELA();
		}

		public void AGREGAR_MAESTRO(MODELO.MAESTRO omaestro)
		{
			escuela.maestros.Add(omaestro);
			escuela.SaveChanges();
		}

		public void MODIFICAR_MAESTRO(MODELO.MAESTRO omaestro)
		{
			escuela.Entry(omaestro).State = System.Data.Entity.EntityState.Modified;
			escuela.SaveChanges();
		}

		public void ELIMINAR_MAESTRO(MODELO.MAESTRO omaestro)
		{
			escuela.maestros.Remove(omaestro);
			escuela.SaveChanges();
		}

		public List<MODELO.MAESTRO> OBTENER_MAESTRO()
		{
		  return escuela.maestros.ToList();
		}
	}
}
