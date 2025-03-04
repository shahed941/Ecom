using Ecom.Core.Entity.Product;
using Ecom.Core.Entity.Product.Product;
using Ecom.Core.Interface;
using Ecom.Infrastrcure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Infrastrcure.Repository
{
    public class PhotoRepository : GenericRepository<Photo>, IPhotoRepository
    {


        public PhotoRepository(AppDbContext context) : base(context)
        {
      
        }
    }
}
