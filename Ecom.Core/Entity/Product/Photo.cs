using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Core.Entity.Product.Product
{
    public class Photo : BaseEntity<int>
    {
        public string    PhotoName { get; set; }
        public int    ProductId { get; set; }
        public virtual Products Products { get; set; }
    }
}
