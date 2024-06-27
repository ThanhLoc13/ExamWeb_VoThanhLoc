using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamWeb_VoThanhLoc.Models;
namespace ExamWeb_VoThanhLoc.Controllers
{
    public class MusicController : Controller
    {
        private readonly ApplicationDbContext _db;
        public MusicController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var dsDiaNhac = _db.DiaNhacs.ToList();
            var tongsoluong = _db.DiaNhacs.Sum(x => x.SoLuong);
            ViewBag.SUM = tongsoluong;
            return View(dsDiaNhac);
        }
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(DiaNhac diaNhac)
        {
            if (ModelState.IsValid)
            {
                _db.DiaNhacs.Add(diaNhac);
                _db.SaveChanges();
                TempData["success"] = "Đã thêm 1 đĩa nhạc";
                return RedirectToAction("Index");
            }
            return View(diaNhac);
        }
        public IActionResult Update(int id)
        {
            var diaNhac  = _db.DiaNhacs.Find(id);
            var diaNhac1 = _db.DiaNhacs.SingleOrDefault(x => x.Id == id);
            if (diaNhac != null)
                return View(diaNhac);

            return NotFound();
        }

        [HttpPost]
        public IActionResult Update(DiaNhac diaNhac)
        {
            if (ModelState.IsValid)
            {
                _db.DiaNhacs.Update(diaNhac);
                _db.SaveChanges();
                TempData["success"] = "Đã cập nhật 1 đĩa nhạc";
                return RedirectToAction("Index");
            }
            return View(diaNhac);
        }
    }
}