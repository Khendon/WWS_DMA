using System;
using System.Data.Entity;
using WWS_DMA.Domain.Entities;

namespace WWS_DMA.Domain.Concrete
{
    public class AppDbContext : DbContext
    {
        public DbSet<JobDetail> JobDetails { get; set; }
        public DbSet<ClientDetail> ClientDetails { get; set; }
        public DbSet<Modelling> Modellings { get; set; }
        public DbSet<RunDetail> RunDetails { get; set; }
        public DbSet<GaugeDetail> GaugeDetails { get; set; }
        public DbSet<GaugeData> GaugeDatas { get; set; }
    }
}
