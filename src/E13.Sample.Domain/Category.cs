using E13.Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E13.Sample.Domain
{
    public class Category : IEntity
    {
        public Category(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public List<Task> Tasks { get; set; } = new List<Task>();

        public Guid Id { get; set; }
        public string? CreatedBy { get; set; }
        public string? CreatedSource { get; set; }
        public DateTime Created { get; set; }
        public string? ModifiedBy { get; set; }
        public string? ModifiedSource { get; set; }
        public DateTime Modified { get; set; }

    }
}
