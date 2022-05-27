using CleanArch.Domain.Validation;
using System;
using System.Collections.Generic;

namespace CleanArch.Domain.Entities
{
    public sealed class Product
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public int Stock { get; private set; }
        public string Image { get; private set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public Product(string name, string description, decimal price, int stock, string image) {
            ValidateDomain(name, description, price, stock, image);
        }

        public Product(int id, string name, string description, decimal price, int stock, string image) {
            DomainExceptionValidation.When(id < 0, "ID is invalid.");
            Id = id;
            ValidateDomain(name, description, price, stock, image);
        }

        public Update(string name, string description, decimal price, int stock, string image, int categoryId) {
            ValidateDomain(name, description, price, stock, image);
            CategoryId = categoryId;
        }

        private void ValidateDomain(string name, string description, decimal price, int stock, string image) {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name),
                "Invalid Name. Name is required.");

            DomainExceptionValidation.When(name.Length < 3,
                "Invalid Name. Too short. Minimum 3 characters.");
            
            DomainExceptionValidation.When(string.IsNullOrEmpty(description),
                "Invalid Description. Description is required.");

            DomainExceptionValidation.When(price < 0,
                "Invalid Price value.");
            
            DomainExceptionValidation.When(stock < 0,
                "Invalid Stock value.");
            
            DomainExceptionValidation.When(image.Length > 255,
                "Invalid image name. Too long. Maximum 250 characters.");

            Name = name;
            Description = description;
            Price = price;
            Stock = stock;
            Image = image;

        }
    }
}
