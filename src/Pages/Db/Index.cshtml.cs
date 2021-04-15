using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoCrafts.WebSite.Models;
using ContosoCrafts.WebSite.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ContosoCrafts.WebSite.Pages.Db
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ContosoCrafts.WebSite.Data.ProductContext _context;
        public IndexModel(ILogger<IndexModel> logger,
            ContosoCrafts.WebSite.Data.ProductContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IList<Product> Products { get; set; }
        public void OnGet()
        {
            Products = _context.Products.ToList();
        }
    }
}
