using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCLibrary1.Models;

namespace MVCLibrary1.Data
{
    public class MVCLibrary1Context : DbContext
    {
        public MVCLibrary1Context (DbContextOptions<MVCLibrary1Context> options)
            : base(options)
        {
        }

        public DbSet<MVCLibrary1.Models.Book> Book { get; set; } = default!;
    }
}
