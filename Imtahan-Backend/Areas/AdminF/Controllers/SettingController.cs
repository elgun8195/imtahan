using Imtahan_Backend.DAL;
using Imtahan_Backend.Extensions;
using Imtahan_Backend.Helpers;
using Imtahan_Backend.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imtahan_Backend.Areas.AdminF.Controllers
{
    [Area("AdminF")]
    [Authorize(Roles = "Admin")]

    public class SettingController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public SettingController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
           Setting setting = _context.Settings.FirstOrDefault();
            return View(setting);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return View();
            }
            Setting Setting = _context.Settings.Find(id);
            if (Setting == null)
            {
                return View();
            } 

            _context.Settings.Remove(Setting);

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Setting Setting)
        {

            Setting db = new Setting();

            db.Facebook = Setting.Facebook;
            db.Twitter = Setting.Twitter;
            db.Linkedin = Setting.Linkedin;
            db.Instargarm = Setting.Instargarm;
            db.Skype = Setting.Skype; 

            _context.Settings.Add(db);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }




        public IActionResult Update(int? id)
        {
            if (id == null)
            {
                return View();
            }
            Setting Setting = _context.Settings.Find(id);
            if (Setting == null)
            {
                return View();
            }

            return View(Setting);
        }

        [HttpPost]

        public async Task<IActionResult> Update(int? id, Setting Setting)
        {
            


            if (id == null)
            {
                return View();
            }
            Setting db = _context.Settings.Find(id);
            if (db == null)
            {
                return View();
            }
            Setting existName = _context.Settings.FirstOrDefault(x => x.Twitter.ToLower() == Setting.Twitter.ToLower());

            if (existName != null)
            {
                if (existName != db)
                {
                    ModelState.AddModelError("Twitter", "Twitter Already Exist");
                }
                return View(Setting);
            }

            db.Facebook = Setting.Facebook;
            db.Twitter = Setting.Twitter;
            db.Linkedin = Setting.Linkedin;
            db.Instargarm = Setting.Instargarm;
            db.Skype = Setting.Skype;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }




        public IActionResult Detail(int? id)
        {
            if (id == null)
            {
                return View();
            }
            Setting Setting = _context.Settings.Find(id);
            if (Setting == null)
            {
                return View();
            }

            return View(Setting);
        }


    }
}
