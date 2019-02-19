using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ShittyTwitterApi.Models
{
    public class ShittyTwitterContext : DbContext
    {
        public ShittyTwitterContext (DbContextOptions<ShittyTwitterContext> options)
            :base(options)
        { }

        public DbSet<ShittyTweet> ShittyTweets { get; set; }
    }
}
