using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    public class EFBookstoreRepository : IBookstoreRepository
    {
        private BookstoreDbContext _context;

        //constructor
        public EFBookstoreRepository (BookstoreDbContext context)
        {
            _context = context;
        }


        public IQueryable<Book> Books => _context.Books;
    }
}