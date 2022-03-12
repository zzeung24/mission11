using System;
using System.Linq;

namespace Bookstore.Models
{
    public class EFBookstoreRepository: IBookstoreRepository
    {
        private BookstoreContext context { get; set; }

        public EFBookstoreRepository (BookstoreContext temp)
        {
            context = temp;
        }

        IQueryable<Books> IBookstoreRepository.Books => context.Books;

        public void SaveBooks(Books b)
        {
            context.SaveChanges();
        }

        public void CreateBooks(Books b)
        {
            context.Add(b);
            context.SaveChanges();
        }

        public void DeleteBooks(Books b)
        {
            context.Remove(b);
            context.SaveChanges();
        }
    }
}
