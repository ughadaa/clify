using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using clify.Data;
using clify.Models;

namespace clify.Controllers
{
    public class CommandController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CommandController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET: /command
        public IActionResult Index()
        {
            var Commands = _db.Commands.ToList();
            ViewData["Commands"] = Commands;
            return View();
        }

        // GET: /command/create
        public IActionResult Create()
        {
            return View();
        }
        // POST: /command/create
        [HttpPost]
        public IActionResult Create([Bind("name","des")]CommandModel command)
        {
            _db.Commands.Add(command);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
