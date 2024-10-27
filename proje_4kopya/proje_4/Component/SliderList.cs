using Microsoft.AspNetCore.Mvc;
using proje_4.Data;

namespace proje_4.Component
{
    public class SliderList : ViewComponent
    {
        private readonly ApplicationDbContext _context;

        public SliderList(ApplicationDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var result = _context.Slider.ToList();
            return View(result);
        }
    }
}