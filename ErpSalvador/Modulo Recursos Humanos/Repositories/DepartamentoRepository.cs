namespace ErpSalvador.Repositories
{
    public class DepartamentoRepository : IDepartamentoRepository
    {
        private readonly SystemContext _context;

        public DepartamentoRepository(SystemContext context)
        { 
            _context = context;                 
        }

        public async Task<Departamento> CreateDepartamentoAsync(Departamento departamento) 
        { 
            _context.Departamentos.Add(departamento);
            await _context.SaveChangesAsync();
            return departamento;
        }

        public async Task<Departamento> ReadDepartamentoAsync(int id) 
        {
            return await _context.Departamentos.FindAsync(id);        
        }

        public async Task<IEnumerable<Departamento>> ReadAllDepartamentoAsync() 
        { 
            return await _context.Departamentos.ToListAsync();            
        }

        public async Task<Departamento> UpdateDepartamentoAsync(Departamento departamento) 
        {
            _context.Departamentos.Update(departamento);
            await _context.SaveChangesAsync();
            return departamento;
        }

        public async Task<bool> DeleteDepartamentoAsync(int id) 
        {
            Departamento departamentoParaApagar = await _context.Departamentos.FindAsync(id);          
            _context.Departamentos.Remove(departamentoParaApagar);
            return await _context.SaveChangesAsync() > 0;        
        }



























    }
}
