﻿using Microsoft.EntityFrameworkCore;
using ProEventos.Domain.Models;

namespace ProEventos.Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Lote> Lotes { get; set; }
        public DbSet<Palestrante> Palestrantes { get; set; }
        public DbSet<PalestranteEvento> PalestrantesEventos { get; set; }
        public DbSet<RedeSocial> RedesSociais { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<PalestranteEvento>()
                .HasKey(pe => new { pe.EventoId, pe.PalestranteId });

            builder.Entity<Evento>()
                .HasMany(e => e.RedesSociais)
                .WithOne(re => re.Evento)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Palestrante>()
                .HasMany(e => e.RedesSociais)
                .WithOne(re => re.Palestrante)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
