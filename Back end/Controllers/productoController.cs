using Back_end.Repositorios;
using Back_end.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Back_end.Controllers
{
    [Route("api/producto")]
    public class productoController : Controller
    {
        private readonly interfazProducto product;
        public productoController(interfazProducto product)
        {
            this.product = product;
        }
        [HttpGet]
        public List<producto> Get() => product.getProductos();

        [HttpGet("{id}")]
        public producto get(int id) => product.buscarProducto(id);

        [HttpPost]
        public void post() { }
    }

}

