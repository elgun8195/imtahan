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

    public class TeamController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public TeamController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index()
        {
            List<Team> teams = _context.Teams.ToList();
            return View(teams);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return View();
            }
            Team team = _context.Teams.Find(id);
            if (team == null)
            {
                return View();
            }
            Helper.DeleteImage(_env, team.Image, "images");
            _context.Teams.Remove(team);

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Create()
        {
            return View();  
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Team team)
        {
            if (ModelState["Photo"].ValidationState==Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();
            }

            if (!team.Photo.IsImage())
            {
                ModelState.AddModelError("Photo","Photo only");
            }

            if (team.Photo.CheckSize(20000))
            {
                ModelState.AddModelError("Photo","20mbdan botuk ola bilmez");
            }

            Team db = new Team();
            string filename = await team.Photo.SaveImage(_env,"images");
            db.Image = filename;

            db.Facebook = team.Facebook;
            db.Twitter = team.Twitter;
            db.Linkedin = team.Linkedin;
            db.Instargarm = team.Instargarm;
            db.Desc = team.Desc;
            db.Name = team.Name;
            db.Position = team.Position;

            _context.Teams.Add(db);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }




        public IActionResult Update(int? id)
        {
            if (id==null)
            {
                return View();
            }
            Team team = _context.Teams.Find(id);
            if (team==null)
            {
                return View();
            }

            return View(team);
        }

        [HttpPost]

        public async Task<IActionResult> Update(int? id ,Team team)
        {
            if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();
            }

            if (!team.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Photo only");
            }

            if (team.Photo.CheckSize(20000))
            {
                ModelState.AddModelError("Photo", "20mbdan botuk ola bilmez");
            }


            if (id == null)
            {
                return View();
            }
            Team db = _context.Teams.Find(id);
            if (db == null)
            {
                return View();
            }
            Team existName = _context.Teams.FirstOrDefault(x=>x.Name.ToLower()==team.Name.ToLower());

            if (existName!=null)
            {
                if (existName!=db)
                {
                    ModelState.AddModelError("Name","Name Already Exist");
                }
                return View(team);
            }

            string filename = await team.Photo.SaveImage(_env, "images");
            db.Image = filename;

            db.Facebook = team.Facebook;
            db.Twitter = team.Twitter;
            db.Linkedin = team.Linkedin;
            db.Instargarm = team.Instargarm;
            db.Desc = team.Desc;
            db.Name = team.Name;
            db.Position = team.Position;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        


        public IActionResult Detail(int? id)
        {
            if (id == null)
            {
                return View();
            }
            Team team = _context.Teams.Find(id);
            if (team == null)
            {
                return View();
            }

            return View(team);
        }
    }
}
