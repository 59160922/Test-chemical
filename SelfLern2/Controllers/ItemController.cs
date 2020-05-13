using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SelfLern2.Data;
using SelfLern2.Models;

namespace SelfLern2.Controllers
{
    public class ItemController : Controller
    {
        public AppDbContext _context;
        public ItemModel _item { get; set; }
        public ItemController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.items = GetItem();
            return View();
        }
        
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ItemModel item)
        {
            _context.Add(item);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IList<ItemModel> GetItem()
        {
            return _context.item.ToList();
        }
        [Route("ItemController/Edit/{id?}")]
        public IActionResult Edit(int? id)
        {
            var item = _context.item.Where(x => x.id == id).FirstOrDefault();
          //  ViewBag.student = item;
            return View(item);
        }
        [HttpPost]
        [Route("ItemController/Edit/{id?}")]
        public ActionResult Edit(ItemModel item)
        {
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
        [Route("ItemController/Delete/{id?}")]
        public IActionResult Delete(int? id)
        {
  
            _context.Remove(_context.item.Single(x => x.id == id));
            _context.SaveChanges();
            //  ViewBag.student = item;
            return RedirectToAction("Index");
        }
    }
}