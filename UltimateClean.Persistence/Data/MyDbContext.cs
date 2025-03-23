using Microsoft.EntityFrameworkCore;

namespace UltimateClean.Persistence.Data;

public class MyDbContext(DbContextOptions<MyDbContext> options) : DbContext(options)
{

}
