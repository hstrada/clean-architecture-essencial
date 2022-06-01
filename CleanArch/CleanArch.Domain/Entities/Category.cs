using CleanArch.Domain.Validation;
using System;
using System.Collections.Generic;

namespace CleanArch.Domain.Entities
{
    public sealed class Category : Entity
    {
        public string Name { get; private set; }

        public Category(string name)
        {
            ValidateDomain(name);
        }

        public Category(int id, string name)
        {
            DomainExceptionValidation.When(id < 0, "ID is invalid.");
            Id = id;
            ValidateDomain(name);
        }

        public ICollection<Product> Products { get; private set; }

        private void ValidateDomain(string name)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Name is required.");

            DomainExceptionValidation.When(name.Length < 3, "Name is too short. Minimum required 3.");

            Name = name;
        }
    }
}
