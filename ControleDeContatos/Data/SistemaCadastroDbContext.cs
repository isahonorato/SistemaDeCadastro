using ControleDeContatos.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleDeContatos.Data
{
    public class SistemaCadastroDbContext : DbContext
    {
        public SistemaCadastroDbContext(DbContextOptions<SistemaCadastroDbContext> options) : base(options)
        {

        }
        public DbSet<ContatoModel> CONTATOS { get; set; }
    }
}
