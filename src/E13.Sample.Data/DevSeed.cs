using E13.Common.Data.Db;
using E13.Sample.Domain;
using System;

namespace E13.Sample.Data
{
    public class DevSeed : IDataSeed<SampleContext>
    {
        public const string Owner1 = "Owner 1";
        public const string Owner2 = "Owner 1";

        public void Seed(SampleContext context)
        {
            context.Database.EnsureCreated();

            var categoryA = new Category
            {
                Id = Guid.NewGuid(),
                Name = "Category A"
            };
            var categoryB = new Category
            {
                Id = Guid.NewGuid(),
                Name = "Category B"
            };
            context.Categories.Add(categoryA);
            context.Categories.Add(categoryB);
            
            var taskA1 = new Task
            {
                Id = Guid.NewGuid(),
                Category = categoryA,
                Name = "Task A1",
                OwnedBy = Owner1
            };
            var taskA2 = new Task
            {
                Id = Guid.NewGuid(),
                Category = categoryA,
                Name = "Task A2",
                OwnedBy = Owner2
            };

            var taskB1 = new Task
            {
                Id = Guid.NewGuid(),
                Category = categoryB,
                Name = "Task B1",
                OwnedBy = Owner1
            };
            var taskB2 = new Task
            {
                Id = Guid.NewGuid(),
                Category = categoryB,
                Name = "Task B2",
                OwnedBy = Owner2
            };
            context.Tasks.Add(taskA1);
            context.Tasks.Add(taskA2);
            context.Tasks.Add(taskB1);
            context.Tasks.Add(taskB2);

            context.SaveChanges();
        }
    }
}
