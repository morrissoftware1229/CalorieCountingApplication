using CalorieCountingApplication.Models;
using CalorieCountingApplication.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CalorieCountingApplication.Controllers
{
    public class EntriesController : Controller
    {
        private readonly CalorieCountingApplicationContext _context;

        public EntriesController(CalorieCountingApplicationContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> AddItem()
        {
            Entry entry = new Entry();
            entry.Foods = new List<Food>(_context.Foods);
            entry.Exercises = new List<Exercise>(_context.Exercises);
            return View(entry);
        }

        public async Task<IActionResult> PostFoodItem([Bind("FoodEntryId,Food,Amount,CalorieCount,DateTime")] FoodEntry foodEntry)
        {
            if (ModelState.IsValid)
            {
                _context.Add(foodEntry);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(AddItem));
            }
            return View(foodEntry);
        }

        public async Task<IActionResult> SeeDailyLog()
        {
            return View(await _context.FoodEntries.ToListAsync());
        }
    }
}
