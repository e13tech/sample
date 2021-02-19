using NUnit.Framework;

using E13.Sample.Data;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.Extensions.Logging.Console;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using FluentAssertions;
using System.Linq;

namespace E13.Sample.Data.Tests
{
    public class TaskRepositoryTests
    {
        private SampleContext Context { get; set; }
        private TaskRepository Repo { get; set; }

        [SetUp]
        public void SetUp()
        {
            var options = new DbContextOptionsBuilder<SampleContext>()
              .UseInMemoryDatabase($"{Guid.NewGuid()}")
              .Options;

            Context = new SampleContext(options, new NullLogger<SampleContext>());
            new DevSeed().Seed(Context);

            Repo = new TaskRepository(Context);
        }

        [TearDown]
        public void TearDown()
        {
            Context.Dispose();
        }

        [Test]
        public void TestMethod1()
        {
            Repo.Count().Should().Be(4);

            var t = Repo.ForOwnerByCatgory(DevSeed.Owner1);

            t.Count().Should().Be(2);
            t.All(g => g.Key.Tasks.Count == 1).Should().BeTrue();
            t.All(g => g.Key.Tasks.All(t => t.OwnedBy == DevSeed.Owner1)).Should().BeTrue();
        }
    }
}
