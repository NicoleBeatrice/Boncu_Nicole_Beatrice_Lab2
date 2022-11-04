using Boncu_Nicole_Beatrice_Lab2.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Boncu_Nicole_Beatrice_Lab2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Boncu_Nicole_Beatrice_Lab2.Data.Boncu_Nicole_Beatrice_Lab2Context _context;

        public IndexModel(Boncu_Nicole_Beatrice_Lab2.Data.Boncu_Nicole_Beatrice_Lab2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get; set; } = default!;

        public async Task OnGetAsync()
        {
           
                Book = await _context.Book
                    .Include(b => b.Publisher)
 .ToListAsync();
            
        }
    }
}
