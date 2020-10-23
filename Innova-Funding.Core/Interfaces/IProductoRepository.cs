using Innova_Funding.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Innova_Funding.Core.Interfaces
{
    public interface IProductoRepository
    {
        Task<IEnumerable<Producto>> GetProductos();

        Task<IEnumerable<Producto>> GetProductosPrecio(decimal min, decimal max);

        Task<Producto> GetProducto(int id);

        Task InsertProducto(Producto producto);


    }
}
