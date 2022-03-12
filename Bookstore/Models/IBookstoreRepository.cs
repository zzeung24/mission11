using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    public interface IBookstoreRepository
    {
        IQueryable<Books> Books { get; }

        public void SaveBooks(Books b);
        public void CreateBooks(Books b);
        public void DeleteBooks(Books b);
    }
}
