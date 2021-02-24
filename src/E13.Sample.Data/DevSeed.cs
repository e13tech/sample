using E13.Common.Data.Db;
using E13.Sample.Domain;
using System;

namespace E13.Sample.Data
{
    public class DevSeed : IDataSeed<SampleContext>
    {
        public const string Owner1 = "Owner 1";
        public const string Owner2 = "Owner 2";

        public void Seed(SampleContext context)
        {
            context.Database.EnsureCreated();

            var categoryA = new Category("Category A")
            {
                Id = Guid.NewGuid()
            };
            var categoryB = new Category("Category B")
            {
                Id = Guid.NewGuid()
            };
            context.Categories.Add(categoryA);
            context.Categories.Add(categoryB);
            
            var taskA1 = new Task("Task A1")
            {
                Id = Guid.NewGuid(),
                Category = categoryA,
                OwnedBy = Owner1
            };
            var taskA2 = new Task("Task A2")
            {
                Id = Guid.NewGuid(),
                Category = categoryA,
                OwnedBy = Owner2
            };

            var taskB1 = new Task("Task B1")
            {
                Id = Guid.NewGuid(),
                Category = categoryB,
                OwnedBy = Owner1
            };
            var taskB2 = new Task("Task B2")
            {
                Id = Guid.NewGuid(),
                Category = categoryB,
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
