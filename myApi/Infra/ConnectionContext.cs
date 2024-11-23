using Microsoft.EntityFrameworkCore;
using myApi.model;

namespace myApi.Infra
{
    //iniciando a conexão com o banco de dados
    public class ConnectionContext : DbContext
    {
        //mapeamento no banco de dados
        public DbSet<Fabricante> Fabricantes { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql(
                "Server=localhost;" +
                "Port=5432;Database=WebApi;" +
                "User Id=postgres;" +
                "Password=1210;");
    }
}
