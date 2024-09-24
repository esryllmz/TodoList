

using TodoList.Models;

namespace TodoList.Repository;

public interface IRepository<TEnity>
    where TEnity : Entity,new()
{

    List<TEnity> GetAll();
    TEnity AddUser(TEnity item);
    TEnity? DeleteUser(int id);
    TEnity? UpdateUser(TEnity item);
    TEnity? GetById(int id);
   


}
