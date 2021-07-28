using Catalog.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Entities
{
    public class PropertyGroup : Entity
    {
        public PropertyGroup(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
        public int Position { get; private set; }
        public bool Protected { get; private set; }
    }
}
