
using TodoList.Models;

namespace TodoList.Repository
{
    public class TodoRepository : BaseRepository,ITodoRepository,IUserRepository
    {

        private List<Todo> _todoList()
        {
            return base.Todos();
        }

    
        public User AddUser(User item)
        {
            throw new NotImplementedException();
        }

        public User? DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public User? UpdateUser(User item)
        {
            throw new NotImplementedException();
        }

        public List<Todo> GetAllByTitleContains(string title)
        {
            throw new NotImplementedException();
        }

        List<Todo> IRepository<Todo>.GetAll()
        {
            throw new NotImplementedException();
        }

        public Todo AddUser(Todo item)
        {
            throw new NotImplementedException();
        }

        Todo? IRepository<Todo>.DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public Todo? UpdateUser(Todo item)
        {
            throw new NotImplementedException();
        }

        public Todo? GetById(int id)
        {
            throw new NotImplementedException();
        }

        User? IRepository<User>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
