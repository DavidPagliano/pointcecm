using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public abstract class PERSONA
    {
		#region Persona
		public int ID_Persona { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public DateTime Fecha_de_nacimiento { get; set; }
        public int Telefono { get; set; }
        public string Direccion { get; set; }
		public string Mail { get; set; }
		#endregion 

		#region Materias
		public decimal Notas { get; set; }
        public string Materias { get; set; }
        public bool Tipo { get; set; }
		#endregion

		#region Trimestres
		public decimal Trimestre_1 { get; set; }
        public decimal Trimestre_2 { get; set; }
        public decimal Trimestre_3 { get; set; }
		#endregion

		public decimal Suma_Total { get; set; }
        public decimal Total { get; set; }
        public abstract decimal Calcular_Notas();

    }

    public class MAESTRO : PERSONA
    {
        public int ID_Maestro { get; set; }
        public string Materia { get; set; }
        public CURSO Curso { get; set; }
        public string Observaciones { get; set; }
        #region Calcular notas
        public override decimal Calcular_Notas()
        {
            if (Trimestre_1 >= 6 && Trimestre_2 >= 6 && Trimestre_3 <= 6)
            {
                Suma_Total = Total;
                throw new Exception("APROBADO");
            }
            else if (Trimestre_1 < 6 && Trimestre_2 < 6 && Trimestre_3 >= 6)
            {
                Suma_Total = Total;
                throw new Exception("DESAPROBADO");
            }
            else if (Trimestre_1 < 6 && Trimestre_2 >= 6 && Trimestre_3 >= 6)
            {
                Suma_Total = Total;
                throw new Exception("APROBADO");
            }
            else if (Trimestre_1 <= 6 && Trimestre_2 <= 6 && Trimestre_3 <= 6)
            {
                Suma_Total = Total;
                throw new Exception("APROBADO");
            }

            return Total;
        }
        #endregion
    }
    public class ALUMNO : PERSONA
    {
        public int ID_Alumno { get; set; }
        public string Estado_de_situacion;
        public int Asistencia { get; set; }
        public int Dia_de_clase { get; set; }
        public int Faltas { get; set; }
        public int Amolestaciones { get; set; }
        public string Firma_del_papa { get; set; }
        public int Firmas { get; set; }
		public string Trabajo_grupal { get; set; }
		public string Tareas_realizadas { get; set; }
		public string Responsabilidad { get; set; }
		public string Participacion_en_clases { get; set; }
		public decimal Horario_de_entrada_del_alumno { get; set; }
		public decimal Horario_de_salida_del_alumno { get; set; }
		public string Observacion_del_alumno { get; set; }
        #region variables
        public string ALUMNO_REGULAR = "REGULAR";
        public string ALUMNO_IRREGULAR = "IRREGULAR";

        public string ALUMNO_SUSPENDIDO = "SUSPENDIDO";
        public string ALUMNO_RECURSANTE = "RECURSANTE";

        public string APROBADO = "APROBADO";
        public string DESAPROBADO = "DESAPROBADO";
        #endregion
        public override decimal Calcular_Notas()
        {
            #region ASISTENCIA
            if (Asistencia == Dia_de_clase)
            {
                Asistencia = int.Parse(ALUMNO_REGULAR);
            }
            else if (Asistencia <= Dia_de_clase)
            {
                Asistencia = int.Parse(ALUMNO_REGULAR);
            }
            else if (Asistencia >= Dia_de_clase)
            {
                Asistencia = int.Parse(ALUMNO_IRREGULAR);
            }
            #endregion

            #region FALTAS
            if (Faltas > 15 && Faltas >= 30)
            {
                if (Firma_del_papa == "")
                {
                    Asistencia = int.Parse(ALUMNO_REGULAR);
                }
                else
                {
                    Asistencia = int.Parse(ALUMNO_IRREGULAR);
                }

            }
            else if (Faltas < 15)
            {
                Asistencia = int.Parse(ALUMNO_REGULAR);
            }
            #endregion

            #region NOTAS TRIMESTRALES
            if (Trimestre_1 >= 6 && Trimestre_2 >= 6 && Trimestre_3 >= 6)
            {
                Suma_Total = Total;
                Estado_de_situacion = APROBADO;
                APROBADO = Materias;
            }
            else if (Trimestre_1 < 6 && Trimestre_2 < 6 && Trimestre_3 >= 6)
            {
                Suma_Total = Total;
                Estado_de_situacion = DESAPROBADO;
                DESAPROBADO = Materias;
            }
            else if (Trimestre_1 > 6 && Trimestre_2 <= 6 && Trimestre_3 >= 6)
            {
                Suma_Total = Total;
                Estado_de_situacion = APROBADO;
                DESAPROBADO = Materias;
            }
            else if (Trimestre_1 <= 6 && Trimestre_2 <= 6 && Trimestre_3 <= 6)
            {
                Suma_Total = Total;
                Estado_de_situacion = DESAPROBADO;
                DESAPROBADO = Materias;
            }
            else if (Trimestre_1 >= 6 && Trimestre_2 < 6 && Trimestre_3 <6)
            {
                Suma_Total = Total;
                Estado_de_situacion = DESAPROBADO;
                DESAPROBADO = Materias;
            }
            #endregion


            return Total;
        }
    }


}
