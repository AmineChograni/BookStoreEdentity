using System.Collections.Generic;
using System.Linq;

namespace BookStoreEdentity.Models.Repositories
{
    public class AuthorRepository : IBookStoreRepository<Author>
    {

        IList<Author> authors;

        public AuthorRepository()
        {
            authors = new List<Author>()
            {
                new Author{Id = 1, FullName ="CHOGRANI Amine"},
                new Author{Id = 1, FullName ="BOURKHA Hamza"},
                new Author{Id = 1, FullName ="HILALI AbiZaid"},
            };
        }

        public void Add(Author entity)
        {
            authors.Add(entity);
        }

        public void Delete(int id)
        {
            Author author = Find(id);
            authors.Remove(author);
        }

        public Author Find(int id)
        {
            var author = authors.SingleOrDefault(b => b.Id == id);
            return author;
        }

        public IList<Author> List()
        {
            return authors;
        }

        public void Update(Author newAuthor, int Id)
        {
            Author author = Find(Id);
            author.FullName= newAuthor.FullName;
        }
    }
}
