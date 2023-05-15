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

    public void Add(TodoItem item)
    {
        _items.Add(item);
    }

    public void Delete(string text)
    {
        var item = _items.Single(x => x.Text == text);
        _items.Remove(item);
    }

    public void Complete(TodoItem item)
    {
        var todoItem = _items.Single(i => i.Text == item.Text);
        todoItem.Completed = true;
    }

    public void Uncomplete(TodoItem item)
    {
        var todoItem = _items.Single(i => i.Text == item.Text);
        todoItem.Completed = false;
    }
}
