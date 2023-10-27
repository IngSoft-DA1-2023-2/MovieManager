using BusinessLogic;
using Microsoft.EntityFrameworkCore.InMemory.Storage.Internal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagerTest
{
    public static class TestContextFactory
    {
        public static MovieManagerContext CreateContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<MovieManagerContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString());
            return new MovieManagerContext(optionsBuilder.Options);
        }
    }
}
