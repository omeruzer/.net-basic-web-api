using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webdot.Models;

namespace webdot.Services
{
    public interface IBookService
    {
        Book add(Book model);
        List<Book> getAll();

        Book getById(int id);

        Book update(Book model,int id);

        Book remove(int id);
    }
}