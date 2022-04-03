using BookStoreEdentity.Models;
using System.Collections.Generic;

namespace BookStoreEdentity.ViewModels
{
    public class BookAuthorViewModel
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int AuthorId { get; set; }
        public ICollection<Author> Authors { get; set; }
    }
}
