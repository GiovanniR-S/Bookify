using System;
using System.Collections.Generic;
using System.Text;

namespace Bookify.Domain.Abstractions;
public abstract class Entity
{
    public Entity(Guid id) => Id = id;

    public Guid Id { get; init; }

}
