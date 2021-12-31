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
    public class DetailsModel : PageModel
    {
        private readonly Deritei_Norbert_Lab8.Data.Deritei_Norbert_Lab8Context _context;

        public DetailsModel(Deritei_Norbert_Lab8.Data.Deritei_Norbert_Lab8Context context)
        {
            _context = context;
        }

        public BookCategory BookCategory { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            BookCategory = await _context.BookCategory
                .Include(b => b.Book)
                .Include(b => b.Category).FirstOrDefaultAsync(m => m.ID == id);

            if (BookCategory == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
