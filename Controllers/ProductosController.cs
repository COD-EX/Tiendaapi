using Microsoft.AspNetCore.Mvc;
using Tiendaapi.Datos;
using Tiendaapi.Modelo;

namespace Tiendaapi.Controllers
{

    //haciendo primero la referencia
    [ApiController]

    //Rutas
    [Route("api/prueba")]
    public class ProductosController
    {
        //nuestro primer proceso

        [HttpGet]
        public async Task<ActionResult<List<MProductos>>> Get()
        {
            var funcion = new DProductos();
            var lista = await funcion.Mostrarproductos();
            return lista;
        } 
    }
}
