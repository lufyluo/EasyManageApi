using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AppDomain.Entities;
using ModelConfiguration;

namespace AppDomain.Maps
{
    public class AddressMap : EntityMappingConfiguration<AddressEntity>
    {
        public override void Map(EntityTypeBuilder<AddressEntity> b)
        {
            b.Property(n => n.Name).HasMaxLength(10).IsRequired();
        }
    }
}
