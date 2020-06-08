using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Games.Models;

namespace Games.Data
{
    public class GameContext : DbContext
    {
        public GameContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Games.Models.Game> Game { get; set; }
    }
}
