using ECommerce_MW.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ECommerce_MW.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly DataBaseContext _context; //no debe estar inicializada 

        public CategoriesController(DataBaseContext context)//inyeccion de dependencia 
        {
            _context = context;
        }

        // GET: Categories
        public async Task<IActionResult> Index()//se debe crear la vista del index *click derecho addview
        {
            return View(await _context.Categories.ToListAsync());
        }

        // GET: Categories/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.Categories == null)
            {
                return NotFound();
            }

            var category= await _context.Categories
                .FirstOrDefaultAsync(m => m.Id == id);//Sirve para traer un dato y coincidirlo con la tabla, trae el primero que encuentre 
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }
    }
}
