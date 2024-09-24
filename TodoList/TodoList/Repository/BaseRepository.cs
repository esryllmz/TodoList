using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.Models;

namespace TodoList.Repository
{
    public abstract class BaseRepository
     {
            List<User> users = new List<User>()
          {
            new User() { Id = 1, Name = "Yusuf", surName = "Aydın", Age = 30, Email = "yusuf@gmail.com", Password = "123456"},
            new User() { Id = 2, Name = "Esra", surName= "Yılmaz", Age = 23, Email = "eso@gmail.com", Password = "234759"},
            new User() { Id = 3, Name = "Sena", surName = "Gengönül", Age = 25, Email = "sena@gmail.com", Password = "345789"}
          };

            List<Todo> todos = new List<Todo>()
          {
            new Todo() { Id = 1, UserId = 1, Title = "Çöp", Description = "Çöplerin atılması.", StartDate = "25.09.2024", EndDate = "26.09.2024", IsCompleted = false, Priority = "Acil"},
            new Todo() { Id = 2, UserId = 2, Title = "Temizlik", Description = "Evin temizlenmesi.",StartDate = "25.09.2024", EndDate = "27.09.2024", IsCompleted = false, Priority = "Ertelenebilir"},
            new Todo() { Id = 3, UserId = 3, Title = "Çim Biçme", Description = "Çimlerin biçilmesi.", StartDate = "26.09.2024", EndDate = "30.09.2024", IsCompleted = false, Priority = "Ertelenebilir"}
          };

  
        protected List<User> Users() {  return users; }
        protected List<Todo> Todos() { return todos; }
    }
}
