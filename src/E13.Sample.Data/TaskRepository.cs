using E13.Common.Data.Db;
using E13.Sample.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace E13.Sample.Data
{
    public class TaskRepository : Repository<Task>
    {
        public TaskRepository(SampleContext ctx) : base(ctx) { }

        public IEnumerable<IGrouping<Category?, Task>> ForOwnerByCatgory(string ownedBy)
        {
            return DbSet
                .Where(t => t.OwnedBy == ownedBy)
                .Include(t => t.Category)
                .AsNoTracking()
                .ToList()
                .GroupBy(t => t.Category);
        }
    }
}
