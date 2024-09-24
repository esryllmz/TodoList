
using TodoList.Models;

namespace TodoList.Repository;

public class ICategoryRepository : IRepository<Category>
{
    Category IRepository<Category>.AddUser(Category item)
    {
        throw new NotImplementedException();
    }

    Category? IRepository<Category>.DeleteUser(int id)
    {
        throw new NotImplementedException();
    }

    List<Category> IRepository<Category>.GetAll()
    {
        throw new NotImplementedException();
    }

    Category? IRepository<Category>.GetById(int id)
    {
        throw new NotImplementedException();
    }

    Category? IRepository<Category>.UpdateUser(Category item)
    {
        throw new NotImplementedException();
    }
}
