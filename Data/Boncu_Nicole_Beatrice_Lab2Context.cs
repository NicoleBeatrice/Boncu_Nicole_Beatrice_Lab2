using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Boncu_Nicole_Beatrice_Lab2.Models;

namespace Boncu_Nicole_Beatrice_Lab2.Data
{
    public class Boncu_Nicole_Beatrice_Lab2Context : DbContext
    {
        public Boncu_Nicole_Beatrice_Lab2Context(DbContextOptions<Boncu_Nicole_Beatrice_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Boncu_Nicole_Beatrice_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Boncu_Nicole_Beatrice_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Boncu_Nicole_Beatrice_Lab2.Models.Category> Category { get; set; }

        public DbSet<Boncu_Nicole_Beatrice_Lab2.Models.Author> Author { get; set; }

        public DbSet<Boncu_Nicole_Beatrice_Lab2.Models.Member> Member { get; set; }

        public DbSet<Boncu_Nicole_Beatrice_Lab2.Models.Borrowing> Borrowing { get; set; }
    }
}
