using TodoList.Models;

namespace TodoList.Repository;

public sealed class UserRepository : BaseRepository, IUserRepository
{

    private List<User> _userList()
    {
        return base.Users();
    }

    public User AddUser(User item)
    {
        throw new NotImplementedException();
    }

    public User? DeleteUser(int id)
    {
        throw new NotImplementedException();
    }

    public List<User> GetAll()
    {
        throw new NotImplementedException();
    }

    public User? UpdateUser(User item)
    {
        throw new NotImplementedException();
    }

    public User? GetById(int id)
    {
        throw new NotImplementedException();
    }
}
