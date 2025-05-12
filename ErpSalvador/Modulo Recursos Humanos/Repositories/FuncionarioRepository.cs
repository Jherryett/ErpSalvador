namespace ErpSalvador.Repositories
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        private readonly SystemContext _context;

        public FuncionarioRepository(SystemContext context)
        { 
            _context = context;                 
        }

        public async Task<Funcionario> CreateFuncionarioAsync(Funcionario funcionario) 
        { 
            _context.Funcionarios.Add(funcionario);
            await _context.SaveChangesAsync();
            return funcionario;
        }

        public async Task<Funcionario> ReadFuncionarioAsync(int id) 
        {
            return await _context.Funcionarios.FindAsync(id);        
        }

        public async Task<IEnumerable<Funcionario>> ReadAllFuncionarioAsync() 
        { 
            return await _context.Funcionarios.ToListAsync();            
        }

        public async Task<Funcionario> UpdateFuncionarioAsync(Funcionario funcionario) 
        {
            _context.Funcionarios.Update(funcionario);
            await _context.SaveChangesAsync();
            return funcionario;
        }

        public async Task<bool> DeleteFuncionarioAsync(int id) 
        {
            Funcionario funcionarioParaApagar = await _context.Funcionarios.FindAsync(id);          
            _context.Funcionarios.Remove(funcionarioParaApagar);
            return await _context.SaveChangesAsync() > 0;        
        }
    }
}
