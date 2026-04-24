using Microsoft.EntityFrameworkCore;
using SchoolApp.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolApp.Tests.Helpers
{
    public static class TestDbContextFactory
    {
        public static SchoolMvc9Context Create()
        {
            DbContextOptions<SchoolMvc9Context> options;
            
            
            options = new DbContextOptionsBuilder<SchoolMvc9Context>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            return new SchoolMvc9Context(options);
        }
    }
}
