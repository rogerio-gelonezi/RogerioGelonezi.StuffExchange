using System;
using Catalog.Entities;
using Catalog.Repositories.Abstractions.Abstractions;
using Catalog.Repositories.Abstractions.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Repositories
{
    public class RepositoryPropertyGroup : RepositoryAbstract<PropertyGroup>, IRepositoryPropertyGroup
    {
        public RepositoryPropertyGroup(CatalogContext context) : base(context) { }
    }
}
