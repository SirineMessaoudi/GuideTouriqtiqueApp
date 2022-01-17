using GuideTouristiqueApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuideTouristiqueApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        internal object site;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }
        public DbSet<Models.SiteTouristique> sites { get; set; }
        public DbSet<Models.Hotel> hotels { get; set; }
        public DbSet<Models.Restaurant> restaurants { get; set; }
        public DbSet<Models.Transport> transports { get; set; }
        public DbSet<Models.Activite> activites { get; set; }
        public DbSet<Models.Internaute> personnes { get; set; }
        public DbSet<Models.Bus> buses { get; set; }
        public DbSet<Models.Offre> offres { get; set; }
        public DbSet<Models.Chambre> chambres { get; set; }
        public DbSet<Models.Localisation> localisations { get; set; }
        public DbSet<Models.ServiceTouristique> services { get; set; }


    }
}
