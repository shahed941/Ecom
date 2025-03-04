using Ecom.Core.Interface;
using Ecom.Infrastrcure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Infrastrcure.Repository
{
    internal class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

      
        public IProductRepository productRepository { get; }

        public ICategoryRepository categoryRepository { get; }

        public IPhotoRepository photoRepository { get; }
        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            productRepository = new ProductRepository(_context);
            categoryRepository = new CategoryRepositroy(_context);
            photoRepository = new PhotoRepository(_context);
        }

    }
}
