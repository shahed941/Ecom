using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Core.Entity.Product
{
    public class Category : BaseEntity<int>
    {
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public ICollection<Products> products { get; set; } = new HashSet<Products>();
    }
}
