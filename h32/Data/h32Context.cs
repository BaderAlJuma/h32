#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using h32.Models;

namespace h32.Data
{
    public class h32Context : DbContext
    {
        public h32Context()
        {
        }

        public h32Context (DbContextOptions<h32Context> options)
            : base(options)
        {
        }

        public DbSet<h32.Models.Laptop> Laptop { get; set; }
    }
}
