using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using EFCoreTutorial.Models;

namespace EFCoreTutorial
{
    public class MusicContext : DbContext
    {
        public DbSet<Song> Songs { get; set; }
    }
}
