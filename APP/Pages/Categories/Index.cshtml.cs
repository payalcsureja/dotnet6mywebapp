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
    public class Index : PageModel
    {
        private readonly ILogger<Index> _logger;
        private readonly ApplicationDbContext _db;


        public IEnumerable<Category> Categories { get; set; }

        public Index(ILogger<Index> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public void OnGet()
        {
            Categories = _db.Category;
        }
    }
}
