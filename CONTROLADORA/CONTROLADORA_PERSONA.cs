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

		public void AGREGAR_PERSONA(MODELO.PERSONA opersona)
		{
			escuela.Persona.Add(opersona);
			escuela.SaveChanges();
		}

		public void MODIFICAR_PERSONA(MODELO.PERSONA oPersona)
		{
			escuela.Entry(oPersona).State = System.Data.Entity.EntityState.Modified;
			escuela.SaveChanges();
		}

		public void ELIMINAR_MAESTRO(MODELO.PERSONA opersona)
		{
			escuela.Persona.Remove(opersona);
			escuela.SaveChanges();
		}

		public List<MODELO.PERSONA> OBTENER_PERSONA()
		{
		  return escuela.Persona.ToList();
		}
	}
}
