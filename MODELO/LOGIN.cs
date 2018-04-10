using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
   public class LOGIN
    {
        public int Id_Login { get; set; }
        public USUARIO Usuario { get; set; }
        public string Contraseña { get; set; }
		public string Recuperar_contraseña { get; set; }
		public bool Activo { get; set; }
    }
}
