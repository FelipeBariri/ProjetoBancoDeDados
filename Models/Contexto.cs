using Microsoft.EntityFrameworkCore;

namespace ProjetoBancoDeDados.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> Options) : base(Options)
        {

        }

        public DbSet<Eventos> Eventos { get; set; }
        public DbSet<Pagamentos> Pagamentos { get; set; }
        public DbSet<Passagens> Passagens { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Inscricoes> Inscricoes { get; set; }
    }
}