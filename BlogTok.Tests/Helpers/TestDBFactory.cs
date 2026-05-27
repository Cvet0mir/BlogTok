using BlogTok.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogTok.Tests.Helpers
{
    public class TestDBFactory
    {
        public static BlogTokDbContext CreateDbContext()
        {
            var options = new DbContextOptionsBuilder<BlogTokDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            var context = new BlogTokDbContext(options);
            context.Database.EnsureCreated();
            return context;
        }
    }
}
