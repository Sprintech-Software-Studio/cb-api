using cb.Models;
using Microsoft.EntityFrameworkCore;

namespace cb.Infrastructure
{
	public class ConnectionContext : DbContext
	{
		public DbSet<Store> Stores { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<Service> Services { get; set; }

		public ConnectionContext(DbContextOptions<ConnectionContext> options)
			: base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Store>().ToTable("Stores");
		}
	}
}
