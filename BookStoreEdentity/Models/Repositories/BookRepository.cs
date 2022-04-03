using System.Collections.Generic;
using System.Linq;

namespace BookStoreEdentity.Models.Repositories
{
    public class BookRepository : IBookStoreRepository<Book>
    {
        List<Book> books;

        public BookRepository()
        {
            books = new List<Book>()
            {
                new Book() { Id = 1, Title = "C#",Description ="No description",Author=new Author{ Id =2  }},
                new Book() { Id = 2, Title = "Java",Description ="No Date",Author=new Author()},
                new Book() { Id = 3, Title = "PHP",Description ="No description",Author=new Author()},
            };
        }
        public void Add(Book entity)
        {
            books.Add(entity);
        }

        public void Delete(int id)
        {
            Book book = Find(id);
            books.Remove(book);
        }

        public Book Find(int id)
        {
            var book = books.SingleOrDefault(b => b.Id == id);
            return book;
        }

        public IList<Book> List()
        {
            return books;
        }

        public void Update(Book newBook,int id)
        {
            Book book=Find(id);
            book.Title = newBook.Title;
            book.Description = newBook.Description;
            book.Author=newBook.Author;
        }
    }
}
