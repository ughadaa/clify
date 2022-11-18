using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using clify.Models;

namespace clify.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    //public IActionResult cards(int id = -1)
    //{
    //    List<CommandModel> commands = new List<CommandModel>();
    //    commands.Add(new CommandModel(1, "rm file", "Deletes a file or group of files"));
    //    commands.Add(new CommandModel(2, "cd Desktop", "Changes current working directory"));
    //    commands.Add(new CommandModel(3, "mv file1 file2", "Renames file1 to file2"));
    //    commands.Add(new CommandModel(4, "ln -s file softln", "Makes a soft link to file"));

    //    ViewData["commands"] = commands;
    //    ViewData["id"] = id;

    //    return View();
    //}

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

