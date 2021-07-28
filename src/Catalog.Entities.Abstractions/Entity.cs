using System;

namespace Catalog.Entities.Abstractions
{
    public abstract class Entity
    {
        public Guid Id { get; protected set; }
    }
}
