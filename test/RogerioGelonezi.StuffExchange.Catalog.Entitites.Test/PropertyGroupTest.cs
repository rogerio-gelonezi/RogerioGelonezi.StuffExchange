using FluentAssertions;
using RogerioGelonezi.StuffExchange.Catalog.Entities;
using System;
using Xunit;

namespace RogerioGelonezi.StuffExchange.Entitites.Test
{
    public class PropertyGroupTest
    {
        [Fact]
        public void CtroWithSuccess()
        {
            // assert 
            var name = "GroupName";

            // act
            var model = new PropertyGroup(name);

            // assert
            model.Should().NotBeNull();
            model.Name.Should().BeEquivalentTo(name);
            model.Id.Should().BeEmpty();
        }
    }
}
