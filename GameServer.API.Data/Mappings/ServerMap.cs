using GameServer.API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameServer.API.Data.Mappings
{
    public class ServerMap : IEntityTypeConfiguration<Server>
    {
        public void Configure(EntityTypeBuilder<Server> builder)
        {
            builder.ToTable("Servers");

            builder.HasKey(p => p.Id);

            builder.Property(u => u.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(u => u.InitialMoney)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(u => u.InitialStatsPoints)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(u => u.HasDisease)
                .IsRequired();
            
            builder.Property(u => u.Shared)
                .IsRequired();
        }
    }
}
