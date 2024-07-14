using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DrakeDiscographyPractice.Models;

namespace DrakeDiscographyPractice.Data
{
    public class DrakeDbContext : DbContext
    {
        public DrakeDbContext (DbContextOptions<DrakeDbContext> options)
            : base(options)
        {
        }

        public DbSet<DrakeDiscographyPractice.Models.Album> Album { get; set; } = default!;
        public DbSet<DrakeDiscographyPractice.Models.Song> Song { get; set; } = default!;
    }
}
