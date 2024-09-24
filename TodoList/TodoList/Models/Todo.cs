namespace TodoList.Models;

public sealed class Todo:Entity
{


    public Todo()
    {
        CreatedDate = DateTime.Now;
    }

    public Todo(int id,string title, string description, string startDate, string endDate, string priority, bool ısCompleted, int userId):this()
    {
        Title = title;
        Description = description;
        StartDate = startDate;
        EndDate = endDate;
        Priority = priority;
        IsCompleted = ısCompleted;
        UserId = userId;
    }

    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime CreatedDate { get; set; }
    public string StartDate { get; set; }
    public string EndDate { get; set; }
    public string Priority { get; set; }
    public bool IsCompleted { get; set; }
    public int UserId { get; set; }


}
