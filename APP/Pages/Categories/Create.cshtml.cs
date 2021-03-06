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
    public class Create : PageModel
    {
        private readonly ILogger<Create> _logger;
        private readonly ApplicationDbContext _db;
        // [BindProperty]
        public Category Category { get; set; }

        public Create(ILogger<Create> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost(){

            if(Category.Name == Category.DisplayOrder.ToString()){
                ModelState.AddModelError(string.Empty, "NAme and Display order can not be same.");
            }

            if(ModelState.IsValid){
                await _db.Category.AddAsync(Category);
                await _db.SaveChangesAsync();
                TempData["success"] = "Created successfully";
                return RedirectToPage("Index");
            }
            return Page();
            
        }
    }
}
