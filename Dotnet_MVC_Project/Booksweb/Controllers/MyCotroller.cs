using Microsoft.AspNetCore.Mvc;

public class MyController : Controller{
    private readonly ILogger<MyController> _logger;
    public MyController(ILogger<MyController> logger)
    {
        _logger=logger;
    }
}