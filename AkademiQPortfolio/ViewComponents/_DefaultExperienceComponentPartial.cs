using AkademiQPortfolio.Data;
using Microsoft.AspNetCore.Mvc;

namespace AkademiQPortfolio.ViewComponents
{
    public class _DefaultExperienceComponentPartial:ViewComponent
    {
        private readonly AppDbContext _context;

        public _DefaultExperienceComponentPartial(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
           
            var experienceList = _context.Experiences.ToList();
            return View(experienceList);
        }
    }
}
