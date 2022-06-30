using Imtahan_Backend.Helpers;
using Imtahan_Backend.Models;
using Imtahan_Backend.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;

namespace Imtahan_Backend.Controllers
{
    public class AccountController : Controller
    {
        public readonly UserManager<AppUser> _usermanager;

        public readonly SignInManager<AppUser> _signInManager;
        public readonly RoleManager<IdentityRole> _rolemanager;


        public AccountController(UserManager<AppUser> usermanager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> rolemanager)
        {
            _usermanager = usermanager;
            _signInManager = signInManager;
            _rolemanager = rolemanager;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if (!ModelState.IsValid)
            {
                return View(registerVM);
            }

            AppUser appUser = new AppUser()
            { 
                Email = registerVM.Email,
                FullName = registerVM.FullName,
                UserName = registerVM.UserName
            };

            IdentityResult result=await _usermanager.CreateAsync(appUser,registerVM.Password);
            if (!result.Succeeded)
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("","Error detected");
                    return View(registerVM);
                }
            }

            await _usermanager.AddToRoleAsync(appUser,Roless.Admin.ToString());
            await _signInManager.SignInAsync(appUser,true);
            return RedirectToAction("index","home");
        }



        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]


        public async Task<IActionResult> Login(LoginVM loginVM,string returnurl)
        {
            if (!ModelState.IsValid)
            {
                return View(loginVM);
            }
            AppUser appUser=await _usermanager.FindByEmailAsync(loginVM.Email);

            SignInResult result = await _signInManager.PasswordSignInAsync(appUser,loginVM.Password,loginVM.RememberMe,true);

            if (appUser==null)
            {
                return View(loginVM);
            }

            foreach (var item in await _usermanager.GetRolesAsync(appUser))
            {
                if (item==Roless.Admin.ToString())
                {
                    return RedirectToAction("index","dashboard",new {area="adminf"});
                }
            }
            if (returnurl==null)
            {
                return View(loginVM);
            }
            return View(returnurl);


        }
        public async Task<IActionResult> Signout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("index", "home");
        }



        public async Task CreateRole()
        {
            foreach (var item in Enum.GetValues(typeof(Roless)))
            {
                if (!await _rolemanager.RoleExistsAsync(item.ToString()))
                {
                    await _rolemanager.CreateAsync(new IdentityRole { Name=item.ToString()});
                }
            }
        }
    }
}
