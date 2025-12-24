using AkademiQPortfolio.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AkademiQPortfolio.Controllers
{
    public class StatisticsController : Controller
    {
        private readonly AppDbContext _context;
        public StatisticsController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult StatisticsCards()
        {
            var messageCount = _context.Messages.Count();
            var messageCountByIsReadTrue = _context.Messages.Where(x => x.IsRead == true).Count();
            var messageCountByIsReadFalse = _context.Messages.Where(x => x.IsRead == false).Count();
            var skillCount = _context.Skills.Count();
            var skillAvgValue = _context.Skills.Average(x => x.SkillValue);
            var skillValueBiggerThan70 = _context.Skills.Where(x => x.SkillValue >= 70).Count();

            ViewBag.MessageCount = messageCount;
            ViewBag.SkillCount = skillCount;
            ViewBag.MessageCountByIsReadTrue = messageCountByIsReadTrue;
            ViewBag.messageCountByIsReadFalse = messageCountByIsReadFalse;
            ViewBag.SkillAvgValue = skillAvgValue;
            ViewBag.SkillValueBiggerThan70 = skillValueBiggerThan70;

            return View();
        }
    }
}