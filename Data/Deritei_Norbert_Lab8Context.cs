using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Deritei_Norbert_Lab8.Models;

namespace Deritei_Norbert_Lab8.Data
{
    public class Deritei_Norbert_Lab8Context : DbContext
    {
        public Deritei_Norbert_Lab8Context (DbContextOptions<Deritei_Norbert_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Deritei_Norbert_Lab8.Models.Book> Book { get; set; }

        public DbSet<Deritei_Norbert_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Deritei_Norbert_Lab8.Models.Category> Category { get; set; }

        public DbSet<Deritei_Norbert_Lab8.Models.BookCategory> BookCategory { get; set; }
    }
}
