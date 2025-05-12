namespace ErpSalvador.Interfaces
{
    public interface IDepartamentoService
    {
        public Departamento ValidarDepartamento(Departamento departamento);
        Task<Departamento> CriarDepartamentoAsync(Departamento departamento);
        Task<Departamento> LerDepartamentoAsync(int id);
        Task<IEnumerable<Departamento>> LerTodosOsDepartamentosAsync();
        Task<Departamento> AtualizarDepartamentoAsync(Departamento departamento);
        Task<bool> ApagarDepartamentoAsync(int id);
    }
}
