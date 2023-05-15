using Microsoft.AspNetCore.Mvc;
using TodoAppBlazorWebAssembly.Server.Services;

namespace TodoAppBlazorWebAssembly.Server.Controllers;

[ApiController]
[Route("[Controller]")]
public class TodoController : ControllerBase
{
    private readonly ITodoService _todoService;

    public TodoController(ITodoService todoService)
    {
        _todoService = todoService;
    }

    [HttpGet]
    public IEnumerable<TodoItem> Get()
    {
        return _todoService.GetAll();
    }

    [HttpPost]
    public void Post(TodoItem item)
    {
        _todoService.Add(item);
    }

    [HttpDelete("{text}")]
    public void Delete(string text)
    {
        _todoService.Delete(text);
    }

    [HttpPost("complete")]
    public void Complete(TodoItem item)
    {
        _todoService.Complete(item);
    }

    [HttpPost("uncomplete")]
    public void Uncomplete(TodoItem item)
    {
        _todoService.Uncomplete(item);
    }
}
