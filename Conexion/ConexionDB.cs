namespace Tiendaapi.Conexion
{
    public class ConexionDB
    {
        //creación de variable llamado connectionstring como vacío
        private string connectionString = string.Empty;

        //constructor ConexionDB
        public ConexionDB()
        {
            //creación de variable encapsulada
            var constructor = new ConfigurationBuilder().SetBasePath
                (Directory.GetCurrentDirectory()).AddJsonFile ("appsettings.json").Build();
            connectionString = constructor.GetSection("ConnectionStrings:conexionmaestra").Value;
        }
        //Ahora para que nuestra conexión sea reconocido desde cualquier parte de nuestro proyecto o como público escribimos lo siguiente
        public string cadenaSQL()//un nombre del método cualquiera
        {
            return connectionString; //retorna la conexión
        }
    }
}
