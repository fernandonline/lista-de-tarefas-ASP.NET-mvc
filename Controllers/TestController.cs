using Microsoft.AspNetCore.Mvc;


namespace TodoList.Controllers;

public class TestController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

}