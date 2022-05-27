using Microsoft.EntityFrameworkCore;
using SysPatrimonio.Models;

namespace SysPatrimonio.Models
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> opcoes) : base(opcoes)
        {

        }

        public DbSet<DbUsuario> Usuarios { get; set; }

        public DbSet<SysPatrimonio.Models.DbCategoria>? DbCategoria { get; set; }

        public DbSet<SysPatrimonio.Models.DbDepartamento>? DbDepartamento { get; set; }

        public DbSet<SysPatrimonio.Models.DbFornecedor>? DbFornecedor { get; set; }

        public DbSet<SysPatrimonio.Models.DbLocal>? DbLocal { get; set; }
    }
}
