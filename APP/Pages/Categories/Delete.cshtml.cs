using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APP.Data;
using APP.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace APP.Pages.Categories
{
    [BindProperties]
    public class Delete : PageModel
    {
        private readonly ILogger<Delete> _logger;
        private readonly ApplicationDbContext _db;
        // [BindProperty]
        public Category Category { get; set; }

        public Delete(ILogger<Delete> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public void OnGet(int id)
        {
            Category =_db.Category.Find(id);
        }

        public async Task<IActionResult> OnPost(){
             
            var categoryFromDb =_db.Category.Find(Category.Id);
            if(categoryFromDb != null){
                _db.Category.Remove(categoryFromDb);
                await _db.SaveChangesAsync();
                TempData["success"] = "Deleted successfully";
                return RedirectToPage("Index");                    
            }              
             
            return Page();
            
        }
    }
}
