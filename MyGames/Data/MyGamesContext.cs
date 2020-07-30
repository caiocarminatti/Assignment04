using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyGames.Models;

namespace MyGames.Data
{
    public class MyGamesContext : DbContext
    {
        public MyGamesContext (DbContextOptions<MyGamesContext> options)
            : base(options)
        {
        }

        public DbSet<MyGames.Models.Game> Game { get; set; }
    }
}
