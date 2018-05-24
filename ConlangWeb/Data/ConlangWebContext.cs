using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ConlangWeb.Models;

namespace ConlangWeb.Data
{
    public class ConlangWebContext : DbContext
    {
        public ConlangWebContext (DbContextOptions<ConlangWebContext> options)
            : base(options)
        {
        }

        public DbSet<ConlangWeb.Models.Word> Word { get; set; }
    }
}
