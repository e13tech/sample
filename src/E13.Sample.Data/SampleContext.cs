using E13.Common.Data.Db;
using E13.Sample.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;

namespace E13.Sample.Data
{
    public class SampleContext : BaseDbContext
    {
        public SampleContext(DbContextOptions opt, ILogger logger)
            : base(opt, logger) { }

        public DbSet<Task> Tasks { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
