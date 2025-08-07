using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Persistence.Context
{
    public class CarBookContext:DbContext
    {
        public CarBookContext(DbContextOptions<CarBookContext> options) : base(options) { }

        // Örnek DbSet'ler
        public DbSet<About> Abouts { get; set; }
        public DbSet<Banner> Banners  { get; set; }
        public DbSet<Brand> Brands  { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarDescription> CarDescriptions  { get; set; }
        public DbSet<CarFeature> CarFeatures { get; set; }
        public DbSet<CarPricing> carPricings { get; set; }
        public DbSet<Category> categories  { get; set; }
        public DbSet<Contact> contacts { get; set; }
        public DbSet<Feature> features  { get; set; }
        public DbSet<FooterAdress> footerAdresses  { get; set; }
        public DbSet<Location> locations  { get; set; }
        public DbSet<Pricing> pricings  { get; set; }
        public DbSet<Service> services  { get; set; }
        public DbSet<SocialMedia> socialMedias  { get; set; }
        public DbSet<Testimonial> testimonials { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
