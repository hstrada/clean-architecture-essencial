using CleanArch.Domain.Entities;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CleanArch.Domain.Tests
{
    public class ProductUnitTest1
    {
        [Fact(DisplayName = "CreateProduct_WithValidParameters_ResultObjectValidState")]
        public void CreateProduct_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new Product(1, "Product Name", "Product Description", 9.99m, 99, "ProductImage");
            action
                .Should()
                .NotThrow<CleanArch.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "CreateProduct_WithNegativeId_DomainExceptionInvalidId")]
        public void CreateProduct_WithNegativeId_DomainExceptionInvalidId()
        {
            Action action = () => new Product(-1, "Product Name", "Product Description", 9.99m, 99, "ProductImage");
            action
                .Should()
                .Throw<CleanArch.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("ID is invalid.");
        }

        [Fact(DisplayName = "CreateProduct_WithShortName_DomainExceptionInvalidId")]
        public void CreateProduct_WithShortName_DomainExceptionInvalidId()
        {
            Action action = () => new Product(1, "Pr", "Product Description", 9.99m, 99, "ProductImage");
            action
                .Should()
                .Throw<CleanArch.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid Name. Too short. Minimum 3 characters.");
        }


        [Fact(DisplayName = "CreateProduct_WithImageTooLong_DomainExceptionInvalidImage")]
        public void CreateProduct_WithImageTooLong_DomainExceptionInvalidImage()
        {
            Action action = () => new Product(1, "Product Name", "Product Description", 9.99m, 99,
                "ProductImageProductImageProductImageProductImageProductImageProductImageProductImageProductImageProductImageProductImageProductImageProductImageProductImageProductImageProductImageProductImageProductImageProductImageProductImageProductImageProductImageProductImageProductImageProductImageProductImageProductImageProductImageProductImage");
            action
                .Should()
                .Throw<CleanArch.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid image name. Too long. Maximum 250 characters.");
        }

        [Fact(DisplayName = "CreateProduct_WithNullImageName_DomainExceptionInvalidImage")]
        public void CreateProduct_WithNullImageName_DomainExceptionInvalidImage()
        {
            Action action = () => new Product(1, "Product Name", "Product Description", 9.99m, 99, null);
            action
                .Should()
                .NotThrow<CleanArch.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "CreateProduct_WithNullImageName_NotNullReferenceException")]
        public void CreateProduct_WithNullImageName_NotNullReferenceException()
        {
            Action action = () => new Product(1, "Product Name", "Product Description", 9.99m, 99, null);
            action
                .Should()
                .NotThrow<NullReferenceException>();
        }

        [Fact(DisplayName = "CreateProduct_WithEmptyImageName_DomainExceptionInvalidImage")]
        public void CreateProduct_WithEmptyImageName_DomainExceptionInvalidImage()
        {
            Action action = () => new Product(1, "Product Name", "Product Description", 9.99m, 99, "");
            action
                .Should()
                .NotThrow<CleanArch.Domain.Validation.DomainExceptionValidation>();
        }

        [Theory(DisplayName = "CreateProduct_WithInvalidStockValue_DomainExceptionInvalidStock")]
        [InlineData(-5)]
        public void CreateProduct_WithInvalidStockValue_DomainExceptionInvalidStock(int productStockCount)
        {
            Action action = () => new Product(1, "Product Name", "Product Description", 9.99m, productStockCount, "ProductImage");
            action
                .Should()
                .Throw<CleanArch.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid Stock value.");
        }

        [Fact(DisplayName = "CreateProduct_WithInvalidPriceValue_DomainExceptionInvalidPrice")]
        public void CreateProduct_WithInvalidPriceValue_DomainExceptionInvalidPrice()
        {
            Action action = () => new Product(1, "Product Name", "Product Description", -9.99m, 10, "ProductImage");
            action
                .Should()
                .Throw<CleanArch.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid Price value.");
        }
    }
}
