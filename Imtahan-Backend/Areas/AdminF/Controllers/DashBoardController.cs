using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Imtahan_Backend.Areas.AdminF.Controllers
{
    [Area("AdminF")]
    [Authorize(Roles = "Admin")]
    public class DashBoardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
