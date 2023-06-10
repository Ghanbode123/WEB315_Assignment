using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using History.Models;

    public class RazorPagesMovieContext : DbContext
    {
        public HistoryContext (DbContextOptions<RazorPagesMovieContext> options)
            : base(options)
        {
        }

        public DbSet<HistoryContext.Models.History> History { get; set; }
    }
