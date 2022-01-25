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
    public class Create : PageModel
    {
        private readonly ILogger<Create> _logger;
        private readonly ApplicationDbContext _db;

        public Category Category { get; set; }

        public Create(ILogger<Create> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost(Category category){
            await _db.Category.AddAsync(category);
            await _db.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
