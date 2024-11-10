using Microsoft.EntityFrameworkCore;
using T1_Sanchez_JuanManuel.Models;

namespace T1_Sanchez_JuanManuel.Datos
{
    public class ApplicationDbContext:DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Distribuidor> Distribuidor { get; set; }
    }

}
