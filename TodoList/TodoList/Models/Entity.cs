namespace TodoList.Models;

public abstract class Entity
{
    protected Entity()
    {
        
    }

    protected Entity(int ıd):this() 
    {
        Id = ıd;
    }

    public int Id { get; set; }
}
