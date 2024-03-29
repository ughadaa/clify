﻿using System;
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

  /*          foreach(var cmd in Commands)
            {
                if(cmd.sub == "Storage")
                {
                    List<CommandModel> storageCmds = new List<CommandModel>();

                    storageCmds.Add(cmd);
                    ViewData["storageCmds"] = storageCmds;
                    return View("Storage");
                }
            }*/

            return View();
        }

        // GET: command/docker
        public IActionResult Docker()
        {
            var Commands = _db.Commands.ToList();
            ViewData["Commands"] = Commands;
            return View();
        }

        // GET: command/docker
        public IActionResult Git()
        {
            var Commands = _db.Commands.ToList();
            ViewData["Commands"] = Commands;
            return View();
        }

        // GET: command/storage
        public IActionResult Storage()
        {
            var Commands = _db.Commands.ToList();
            ViewData["Commands"] = Commands;
            return View();
        }
        public IActionResult Files()
        {
            var Commands = _db.Commands.ToList();
            ViewData["Commands"] = Commands;
            return View();
        }
        public IActionResult Localization()
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
        public IActionResult Create([Bind("name","des", "category", "sub")]CommandModel command)
        {
            _db.Commands.Add(command);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: /command/Edit
        public IActionResult Edit(int? Id)
        {
            var Command = _db.Commands.ToList().Find(c => c.id == Id);
            if(Id == null || Command == null)
            {
                return View("_NotFound");
            }
            ViewData["Command"] = Command;
            return View();
        }

        // POST: /command/Edit/id
        [HttpPost]
        public IActionResult Edit([Bind("id", "name", "des", "category", "sub")] CommandModel command)
        {
            //var Command = _db.Commands.ToList().Find(c => c.id == Id);
            _db.Commands.Update(command);
            _db.SaveChanges();
            ViewData["Command"] = command;
            return RedirectToAction("Index");
        }

        //POST: /command/delete/id
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var Command = _db.Commands.ToList().FirstOrDefault(c => c.id == id);
            _db.Commands.Remove(Command);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }

    }



    }
