using Microsoft.EntityFrameworkCore;
using OASv1.Model;

namespace OASv1.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }


    public DbSet<AProductModel> Produtos { get; set; }
}
