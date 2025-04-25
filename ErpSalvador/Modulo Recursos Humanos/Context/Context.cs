namespace ErpSalvador.Context
{
    public class SystemContext : DbContext
    {
        public SystemContext(DbContextOptions<SystemContext> options) : base(options)
        { }

        public DbSet<EnderecoFuncionario> EnderecoFuncionarios { get; set; }
        public DbSet<Beneficio> Beneficios { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Funcao> Funcoes { get; set; }

    }
}
