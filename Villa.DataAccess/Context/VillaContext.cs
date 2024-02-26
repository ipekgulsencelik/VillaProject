using Microsoft.EntityFrameworkCore;
using MongoDB.EntityFrameworkCore.Extensions;
using Villa.Entity.Entities;

namespace Villa.DataAccess.Context
{
	public class VillaContext : DbContext
	{
		public VillaContext(DbContextOptions options) : base(options) { }

		public DbSet<Banner> Banners { get; set; }
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<Counter> Counters { get; set; }
		public DbSet<Deal> Deals { get; set; }
		public DbSet<Feature> Features { get; set; }
		public DbSet<FrequentlyQuestion> FrequentlyQuestions { get; set; }
		public DbSet<Message> Messages { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Video> Videos { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Banner>(x => x.ToCollection("Banners"));
			modelBuilder.Entity<Contact>(x => x.ToCollection("Contacts"));
			modelBuilder.Entity<Counter>(x => x.ToCollection("Counters"));
			modelBuilder.Entity<Deal>(x => x.ToCollection("Deals"));
			modelBuilder.Entity<Feature>(x => x.ToCollection("Features"));
			modelBuilder.Entity<FrequentlyQuestion>(x => x.ToCollection("FrequentlyQuestions"));
			modelBuilder.Entity<Message>(x => x.ToCollection("Messages"));
			modelBuilder.Entity<Product>(x => x.ToCollection("Products"));
			modelBuilder.Entity<Video>(x => x.ToCollection("Videos"));
		}
	}
}