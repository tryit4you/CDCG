﻿using CDCG.API.Data.Interfaces;
using CDCG.API.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CDCG.API.Data.Repositories
{
    public class BookRepository : BaseRepository<Book>, IBookRepository
    {
        private readonly DataDbContext _context;
        public BookRepository(DataDbContext context):base(context)
        {
        }
        public IEnumerable<Book> Top5Download => throw new NotImplementedException();

        public IQueryable<Book> GetBooksByCategory(string categoryId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Book> GetBooksByType(string typeId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> RelatedBooks(string id)
        {
            throw new NotImplementedException();
        }
    }
}
