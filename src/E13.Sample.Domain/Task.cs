using E13.Common.Domain;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E13.Sample.Domain
{
    public class Task : IEntity, IOwnable, IExpirable
    {
        public Task(string name)
        {
            Name = name;
        }

        [MaxLength(20)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string? Description { get; set; }
        [NotMapped]
        public string? ShortDescription 
        { 
            get
            {
                if (Description == null || Description.Length <= 20)
                    return Description;

                return $"{Description.Substring(0, 20)}...";
            } 
        }

        public Category? Category { get; set; }

        public Guid Id { get; set; }
        public string? CreatedBy { get; set; }
        public string? CreatedSource { get; set; }
        public DateTime Created { get; set; }
        public string? ModifiedBy { get; set; }
        public string? ModifiedSource { get; set; }
        public DateTime Modified { get; set; }

        public string? OwnedBy { get; set; }
        public string? OwnedSource { get; set; }
        public DateTime Owned { get; set; }

        public string? ExpirationBy { get; set; }
        public string? ExpirationSource { get; set; }
        public DateTime Expiration { get; set; }
    }
}
