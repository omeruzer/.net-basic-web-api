using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webdot.Repository
{
    public interface IGenericRepository<T>where T :class,new()
    {

        List<T> getAll();
        T getById(int id);
        T add(T model);
        T update(T model,int id);
        T remove(int id);


    }
}