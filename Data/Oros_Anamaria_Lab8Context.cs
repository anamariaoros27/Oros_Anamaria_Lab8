using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Oros_Anamaria_Lab8.Models;
using Oros_Anamaria_Lab8;

namespace Oros_Anamaria_Lab8.Data
{
    public class Oros_Anamaria_Lab9Context : DbContext
    {
        public Oros_Anamaria_Lab9Context (DbContextOptions<Oros_Anamaria_Lab9Context> options)
            : base(options)
        {
        }

        public DbSet<Oros_Anamaria_Lab8.Models.Book> Book { get; set; }

        public DbSet<Oros_Anamaria_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Oros_Anamaria_Lab8.Category> Category { get; set; }
    }
}
