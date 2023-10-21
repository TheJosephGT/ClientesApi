using ClienteApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ClienteApi.DAL
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
        public DbSet<Clientes> Clientes { get; set; }
    }
}
