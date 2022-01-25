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
    public class Edit : PageModel
    {
        private readonly ILogger<Edit> _logger;
        private readonly ApplicationDbContext _db;
        // [BindProperty]
        public Category Category { get; set; }

        public Edit(ILogger<Edit> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public void OnGet(int id)
        {
            Category =_db.Category.Find(id);
        }

        public async Task<IActionResult> OnPost(){

            if(Category.Name == Category.DisplayOrder.ToString()){
                ModelState.AddModelError(string.Empty, "NAme and Display order can not be same.");
            }

            if(ModelState.IsValid){
                _db.Category.Update(Category);
                await _db.SaveChangesAsync();
                TempData["success"] = "Updated successfully";
                return RedirectToPage("Index");
            }
            return Page();
            
        }
    }
}
