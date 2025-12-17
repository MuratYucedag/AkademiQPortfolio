using Microsoft.AspNetCore.Mvc;

namespace AkademiQPortfolio.Controllers
{
    public class SkillController : Controller
    {
        public IActionResult SkillList()
        {
            return View();
        }
    }
}
//SkillNewController