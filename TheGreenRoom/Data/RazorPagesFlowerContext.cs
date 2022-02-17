using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesFlower.Models;

    public class RazorPagesFlowerContext : DbContext
    {
        public RazorPagesFlowerContext (DbContextOptions<RazorPagesFlowerContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesFlower.Models.Flower> Flower { get; set; }
    }
