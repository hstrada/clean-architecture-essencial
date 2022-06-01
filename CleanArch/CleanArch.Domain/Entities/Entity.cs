using CleanArch.Domain.Validation;
using System;
using System.Collections.Generic;

namespace CleanArch.Domain.Entities
{
    public abstract class Entity
    {
        public int Id { get; protected set; }
        // createdAt, updatedAt
    }
}
