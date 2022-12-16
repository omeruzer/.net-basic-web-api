using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webdot.Models;
using webdot.Repository;

namespace webdot.Services
{
    public class BookManager : IBookService
    {
        private readonly IGenericRepository<Book> _repository;

        public BookManager(IGenericRepository<Book> repsitory)
        {
            _repository = repsitory;
        }
        public Book add(Book model)
        {
            return _repository.add(model);
        }

        public List<Book> getAll()
        {
            return _repository.getAll();
        }

        public Book getById(int id)
        {
            return _repository.getById(id);
        }

        public Book remove(int id)
        {
            return _repository.remove(id);
        }

        public Book update(Book model, int id)
        {
            return _repository.update(model,id);
        }
    }
}