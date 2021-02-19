using NUnit.Framework;
using FluentAssertions;

using E13.Sample.Domain;

namespace E13.Sample.Domain.Tests
{
    public class TaskTests
    {
        [Test]
        public void ShortDescription_Description20Length_NoChange()
        {
            var arranged = "Lorem ipsum dolor si";
            var expected = arranged;

            var t = new Task
            {
                Description = arranged
            };

            t.ShortDescription.Should().Be(expected);
        }

        [Test]
        public void ShortDescription_DescriptionLongerThan20_Substring()
        {
            var arranged = "Lorem ipsum dolor sit amet, consectetur adipiscing elit";
            var expected = "Lorem ipsum dolor si...";

            var t = new Task
            {
                Description = arranged
            };

            t.ShortDescription.Should().Be(expected);
        }
    }
}
