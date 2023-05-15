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
}
