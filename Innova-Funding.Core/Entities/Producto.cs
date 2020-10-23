using System;
using System.Collections.Generic;
using System.Text;

namespace Innova_Funding.Core.Entities
{
    public class Producto
    {
        public int Id { get; set; }

        public string name { get; set; }

        public string type { get; set; }

        public decimal price { get; set; }

        public decimal SalePrice => price + ((price * 18)/100);

    }
}
