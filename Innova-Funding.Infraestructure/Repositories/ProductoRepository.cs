using Innova_Funding.Core.Entities;
using Innova_Funding.Core.Interfaces;
using Innova_Funding.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Innova_Funding.Infraestructure.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly Innova_FundingContext _context;
        public ProductoRepository(Innova_FundingContext context) {
            _context = context;
        }
        public async Task<IEnumerable<Producto>> GetProductos()
        {
            ////////
            ///
            var productos = await _context.Productos.ToListAsync();
            return productos;

        }

        public async Task<IEnumerable<Producto>> GetProductosPrecio(decimal min, decimal max)
        {
            ////////
            ///
            var productos = await _context.Productos.Where(x => x.price>=min && x.price <=max).ToListAsync();
            return productos;

        }

        public async Task<Producto> GetProducto(int id)
        {
            ////////
            ///
            var producto = await _context.Productos.FirstOrDefaultAsync(x=> x.Id==id);
            return producto;

        }

        public async Task InsertProducto(Producto producto) {


            _context.Productos.Add(producto);
            await _context.SaveChangesAsync();

        }
    }
}
