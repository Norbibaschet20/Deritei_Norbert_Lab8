using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Deritei_Norbert_Lab8.Data;
using Deritei_Norbert_Lab8.Models;

namespace Deritei_Norbert_Lab8.Pages.BookCategories
{
    public class IndexModel : PageModel
    {
        private readonly Deritei_Norbert_Lab8.Data.Deritei_Norbert_Lab8Context _context;

        public IndexModel(Deritei_Norbert_Lab8.Data.Deritei_Norbert_Lab8Context context)
        {
            _context = context;
        }

        public IList<BookCategory> BookCategory { get;set; }

        public async Task OnGetAsync()
        {
            BookCategory = await _context.BookCategory
                .Include(b => b.Book)
                .Include(b => b.Category).ToListAsync();
        }
    }
}
