namespace DATOS
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Data.Entity.ModelConfiguration.Conventions;
    public class ESCUELA : DbContext
    {
        private static ESCUELA instancia;
        public static ESCUELA Obtener_instacia()
        {
            if (instancia == null)
            {
                instancia = new ESCUELA();
            }
            return instancia;
        }
        // El contexto se ha configurado para usar una cadena de conexión 'ESCUELA' del archivo 
        // de configuración de la aplicación (App.config o Web.config). De forma predeterminada, 
        // esta cadena de conexión tiene como destino la base de datos 'DATOS.ESCUELA' de la instancia LocalDb. 
        // 
        // Si desea tener como destino una base de datos y/o un proveedor de base de datos diferente, 
        // modifique la cadena de conexión 'ESCUELA'  en el archivo de configuración de la aplicación.
        public ESCUELA()
            : base("name=ESCUELA")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<TableAttributeConvention>();
            base.OnModelCreating(modelBuilder);
        }
        // Agregue un DbSet para cada tipo de entidad que desee incluir en el modelo. Para obtener más información 
        // sobre cómo configurar y usar un modelo Code First, vea http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
		public virtual DbSet<MODELO.ALUMNO> alumnos { get; set; }
		public virtual DbSet<MODELO.MAESTRO> maestros { get; set; }
		public virtual DbSet<MODELO.LOGIN> logins { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}