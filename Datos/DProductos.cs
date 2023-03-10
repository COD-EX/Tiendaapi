using System.Data;
using System.Data.SqlClient;
using Tiendaapi.Conexion;
using Tiendaapi.Modelo;
namespace Tiendaapi.Datos
{
    public class DProductos
    {
        ConexionDB cn = new ConexionDB();
        public async Task <List<MProductos>> Mostrarproductos()
        {
            var lista = new List<MProductos>();
            using(var sql = new SqlConnection(cn.cadenaSQL()))
            {
                using(var cmd = new SqlCommand("mostrarProductos", sql))
                {
                    await sql.OpenAsync();
                    cmd.CommandType = CommandType.StoredProcedure;
                    using(var item = await cmd.ExecuteReaderAsync())
                    {
                        while (await item.ReadAsync())
                        {
                            var mproductos = new MProductos();
                            mproductos.id = (int)item["id"];                       
                            mproductos.descripcion = (string)item["descripcion"];
                            mproductos.precio = (decimal)item["precio"];
                            lista.Add(mproductos);
                        }
                    }
                }
                return lista;
            }
        }
    }
}
