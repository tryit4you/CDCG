using CDCG.API.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CDCG.API.Data.Interfaces
{
    public interface IBookRepository:IRepository<Book>
    {
        IQueryable<Book> GetBooksByCategory(string categoryId);
        IQueryable<Book> GetBooksByType(string typeId);
        IEnumerable<Book> RelatedBooks(string id);
        IEnumerable<Book> Top5Download { get; }
    }
}
