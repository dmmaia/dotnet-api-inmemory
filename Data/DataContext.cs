using Microsoft.EntityFrameworkCore;
namespace test_api_dotnet.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options)
			: base(options)
		{
		}

		public DbSet<Product> Products {get; set;}
		public SbSet<Category> Categories {get; set;}
	}
}