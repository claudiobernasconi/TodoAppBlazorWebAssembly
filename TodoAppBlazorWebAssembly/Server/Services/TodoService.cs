namespace TodoAppBlazorWebAssembly.Server.Services;

public class TodoService : ITodoService
{
    private readonly IList<TodoItem> _items;

    public TodoService()
    {
        _items = new List<TodoItem> {
            new TodoItem("Wash Clothes"),
            new TodoItem("Clean Desk")
        };
    }

    public IEnumerable<TodoItem> GetAll()
    {
        return _items.ToList();
    }
}
