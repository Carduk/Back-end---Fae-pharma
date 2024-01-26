using Back_end.Entidades;
using Back_end.Repositorios;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace Back_end.Controllers
{
    [Route("api/cliente")]
    public class clienteController
    {
        private readonly interfazCliente info;
        public clienteController(interfazCliente info)
        {
            this.info = info;
        }

        [HttpGet]
        public List<cliente> get() => info.verClientes();

        [HttpGet("{rut}")]
        public cliente get(String rut) => info.comprobarCliente(rut);

        [HttpPut]
        public void put() { }

        [HttpDelete]
        public void delete() { }

        [HttpPost] 
        public void post() { }
    }

}
