namespace TodoAppBlazorWebAssembly.Server.Services;

public interface ITodoService
{
    public IEnumerable<TodoItem> GetAll();
}
