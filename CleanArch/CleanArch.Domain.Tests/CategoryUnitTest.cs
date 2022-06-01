using CleanArch.Domain.Entities;
using FluentAssertions;
using System;
using Xunit;

namespace CleanArch.Domain.Tests
{
    public class CategoryUnitTest
    {
        [Fact(DisplayName = "Create Category With Valid State")]
        public void CreateCategory_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new Category(1, "Category Name");
            action
                .Should()
                .NotThrow<CleanArch.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "CreateCategory_NegativeIdValue_DomainExceptionInvalidId")]
        public void CreateCategory_NegativeIdValue_DomainExceptionInvalidId()
        {
            Action action = () => new Category(-1, "Category Name");
            action
                .Should()
                .Throw<CleanArch.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("ID is invalid.");
        }

        [Fact(DisplayName = "CreateCategory_ShortNameValue_DomainExceptionShortName")]
        public void CreateCategory_ShortNameValue_DomainExceptionShortName()
        {
            Action action = () => new Category(1, "Ca");
            action
                .Should()
                .Throw<CleanArch.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Name is too short. Minimum required 3.");
        }

        [Fact(DisplayName = "CreateCategory_MissingNameValue_DomainExceptionRequiredName")]
        public void CreateCategory_MissingNameValue_DomainExceptionRequiredName()
        {
            Action action = () => new Category(1, "");
            action
                .Should()
                .Throw<CleanArch.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Name is required.");
        }

        [Fact(DisplayName = "CreateCategory_NullNameValue_DomainExceptionRequiredName")]
        public void CreateCategory_NullNameValue_DomainExceptionRequiredName()
        {
            Action action = () => new Category(1, null);
            action
                .Should()
                .Throw<CleanArch.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Name is required.");
        }

    }
}
