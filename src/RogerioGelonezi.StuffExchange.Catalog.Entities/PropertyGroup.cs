using RogerioGelonezi.StuffExchange.Catalog.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace RogerioGelonezi.StuffExchange.Catalog.Entities
{
    public class PropertyGroup : Entity
    {
        public PropertyGroup(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
        public int Position { get; private set; }
    }
}
