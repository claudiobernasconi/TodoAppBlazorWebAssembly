namespace TodoAppBlazorWebAssembly.Server.Services;

public interface ITodoService
{
    public IEnumerable<TodoItem> GetAll();
    public void Add(TodoItem item);
    public void Delete(string text);
}
