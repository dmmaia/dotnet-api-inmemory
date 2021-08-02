using Microsoft.EntityFrameworkCore;
using test_api_dotnet.Models;
namespace test_api_dotnet.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options)
			: base(options)
		{
		}

		public DbSet<Product> Products {get; set;}
		public DbSet<Category> Categories {get; set;}
	}
}