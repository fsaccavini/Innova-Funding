using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Innova_Funding.Core.Entities;
using Innova_Funding.Core.Interfaces;
using Innova_Funding.Infraestructure.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Innova_Funding.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly IProductoRepository _productoRepository;

        public ProductoController(IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetProductos()
        {



            var productos = await _productoRepository.GetProductos();
            return Ok(productos);

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductos(int id)
        {



            var producto = await _productoRepository.GetProducto(id);
            return Ok(producto);

        }


        

        [HttpGet("{min}/{max}")]
        public async Task<IActionResult> GetProductos(decimal min, decimal max)
        {



            var productos = await _productoRepository.GetProductosPrecio(min,max);
            return Ok(productos);

        }

        [HttpPost]
        public async Task<IActionResult> PostProductos(Producto producto)
        {
            await _productoRepository.InsertProducto(producto);
            return Ok(producto);

        }
    }
}
