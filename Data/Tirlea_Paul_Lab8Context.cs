using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tirlea_Paul_Lab8.Models;

namespace Tirlea_Paul_Lab8.Data
{
    public class Tirlea_Paul_Lab8Context : DbContext
    {
        public Tirlea_Paul_Lab8Context (DbContextOptions<Tirlea_Paul_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Tirlea_Paul_Lab8.Models.Book> Book { get; set; }

        public DbSet<Tirlea_Paul_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Tirlea_Paul_Lab8.Models.Category> Category { get; set; }
    }
}
